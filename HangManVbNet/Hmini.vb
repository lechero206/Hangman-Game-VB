Option Strict Off
Option Explicit On
Imports System.IO

Module ini
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationname As String, ByVal lpKeyName As String, ByVal lsString As String, ByVal lplFilename As String) As Integer
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationname As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	Public Const SerialNum As String = "59-43-C99"
	Public Const INIFILENAME As String = "hm.ini"
	Public Const EKey As String = "94022" 'Chr$(57) & Chr$(52) & Chr$(48) & Chr$(50) & Chr$(50)  'encrypt key - "94022"
    Public file As String
    Public appname As String
    Public keyname As String
    Public Kvalue As String
	
    Public Sub WriteIni(ByRef MyValue As String)

        Dim m As String
        Dim lpKeyName, lpAppName, lpFileName, lpString As String
        Dim U As Integer

        lpAppName = appname
        lpKeyName = keyname
        lpString = MyValue
        lpFileName = file
        U = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName)
        If U = 0 Then
            'file is missing
            m = "A file is missing or corrupted!"
            MsgBox(m, 16, "Error - 15")
            End
        End If
    End Sub
	
    Public Sub ReadIni(ByRef result As String)
        Dim m As String
        Dim X As Integer
        Dim lpAppName, lpKeyName, lpDefault, lpFileName As String
        Dim lpReturnedString As String
        Dim nSize As Integer

        lpAppName = appname
        lpKeyName = keyname
        lpDefault = CStr(0)
        lpFileName = file

        lpReturnedString = New String(Chr(0), 50) 'fill with nulls
        nSize = 0

        X = GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, lpReturnedString, Len(lpReturnedString), lpFileName)
        If X = 0 Then
            'file is missing
            m = "A file is missing or corrupted!"
            MsgBox(m, 16, "Error - 15")
            End
        Else
            result = Trim(lpReturnedString)
        End If
    End Sub
	
	Public Sub ShowNagScreen()
		'display nag screen shareware message
        frmNotice.ShowDialog()
    End Sub

	Public Sub GetIniFileSettings(ByRef NFile As Short, ByRef gSound As Short)
        'open the hm.ini file in the application directory and get initial settings for category of words
		Dim TmpNum As String
		
        appname = "Category"
        keyname = "File"
        TmpNum = ""

		readini(TmpNum)
		NFile = Val(TmpNum)

        appname = "Settings"
        keyname = "PlaySound"

        readini(TmpNum)
        gSound = Val(TmpNum)

    End Sub

	Public Sub PutIniFileSettings(ByRef Num As Short, ByRef gSound As Short)
        'open the hm.ini file in the application directory and output initial settings for category of words
		Dim TmpNum As String
		
        appname = "Category"
        keyname = "File"

		TmpNum = Str(Num)
        WriteIni(TmpNum)

        appname = "Settings"
        keyname = "PlaySound"

        TmpNum = Str(gSound)
        WriteIni(TmpNum)

    End Sub

	Public Sub GetIntPathSettings()
        'set path settings to application directory
		On Error GoTo Errorhandler
		
        'set mypath to the application directory
        MyPath = My.Application.Info.DirectoryPath  'added for .net
        '        MsgBox(MyPath, 16, "Error - 15")

        file = My.Application.Info.DirectoryPath & "\" & INIFILENAME

        Exit Sub

Errorhandler: 
        'need to research this problem, may need to create directory if not exist
        Resume Next

    End Sub

	Public Sub CheckForNewInstall()
        'check hm.ini file for new install, compare key for serial number,
        'if key = 59-43-C99 then new else it should be valid date

		Dim NKey As String
        Dim MyDay, MyMonth, MyYear As String
        Dim MyDate As String
        Dim MyDate2 As Object
		Dim X As Integer
		Dim TmpStr As String
		Dim lpString, lpFileName, lpAppName, lpKeyName, lpDefault As String
		Dim f As Short
		Dim CurDate As Date
        Dim DaysUsed As Short
        Dim m As String

        Dim Now As DateTime = DateTime.Now 'added for .net

        lpFileName = file
		lpAppName = "Serial"
		lpKeyName = "Key"
		lpDefault = "0"
		NKey = Space(31)
		'X will return the length of chars in NKey
        X = GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, NKey, 30, lpFileName)
        'NKey must be 9 chars in length
		If X <= 8 Then
			'NKey is less than 9 chars in length
            m = "A file is missing or corrupted!"
			MsgBox(m, 16, "Error - 16")
			End
		Else
			NKey = Left(NKey, X)
			NKey = LTrim(RTrim(NKey))
			If NKey = SerialNum Then

                MyDate = Format(Now, "MM/dd/yyyy")
                'strip MyDate to Month, Day, and Year
				'start at postion 1 and select the next 2 chars
                MyMonth = Mid(MyDate, 1, 2) 'Month(MyDate)
                'start at postion 4 and select the next 2 chars
                MyDay = Mid(MyDate, 4, 2) 'Day(MyDate)
				'start at postion 7 and select the next 2 chars
                MyYear = Mid(MyDate, 7, 4) 'Year(MyDate)
                TmpStr = MyMonth & "-" & MyDay & "-" & "C" & MyYear
                'TmpStr = MyMonth & "-" & "05" & "-" & "C" & MyYear

                'output installed date to file hm.ini in application directory
                lpString = TmpStr

                X = WritePrivateProfileString(lpAppName, lpKeyName, lpString, lpFileName)
                f = FreeFile()

                FileOpen(f, MyPath & "\values.dat", OpenMode.Output)
                TmpStr = MyMonth & "/" & MyDay & "/" & MyYear
                'TmpStr = MyMonth & "/" & "05" & "/" & MyYear

                'output installed date to file values.dat in application directory
				PrintLine(f, Encrypt(TmpStr, EKey)) 'use print for output
				FileClose(f)
            Else
                'get date of when the software was installed from values.dat
                'also values.dat must be a valid file in directory
                TmpStr = Encrypt(GetCrypt(), EKey)
                'if user erases or changes the info in the values.dat file
                'tmpstr will be returned as empty or null
                If (Not IsNothing(TmpStr) Or TmpStr Is System.DBNull.Value.ToString) Then
                    MyDate2 = DateValue(TmpStr)
                    CurDate = CDate(Format(Now, "MM/dd/yyyy"))
                    'determine how many days between MyDate and CurDate
                    DaysUsed = DateDiff(Microsoft.VisualBasic.DateInterval.Day, MyDate2, CurDate)
                    gDaysUsed = DaysUsed
                    'cannot use program more than 30 days
                    If (DaysUsed > 30 Or DaysUsed < 0) Then
                        'output a 1 when program is used over 30 days
                        gExpired = 1
                        'comment out for demo
                        PutIniExpired(gExpired)
                        'show expired screen and exit program
                        frmExpired.ShowDialog()
                        End
                    End If
                Else
                    'file is corrupted
                    m = "A file is missing or corrupted!"
                    MsgBox(m, 16, "Error - 17")
                    End
                End If
			End If
        End If
        'date game was installed
        'MsgBox(TmpStr)
    End Sub

	Public Function Encrypt(ByRef Secret As String, ByRef CryptKey As String) As String
		'secret$ = the string you wish to encrypt or decrypt.
		'CryptKey = the password (EKey=94022) used to encrypt the string.
        Dim X, L, Char_X As Short
		
		L = Len(CryptKey)
		For X = 1 To Len(Secret)
            Char_X = Asc(Mid(CryptKey, (X Mod L) - L * CShort((X Mod L) = 0), 1))
            Mid(Secret, X, 1) = Chr(Asc(Mid(Secret, X, 1)) Xor Char_X)
		Next 
		Encrypt = Secret
        'MsgBox("Secret= " & Secret)
    End Function

	Private Function GetCrypt() As String
        'reads the current encrypted password from the file values.dat in app.dir
		Dim f, n As Short
		Dim r, m As String
		
		On Error GoTo NoCrypt
        f = FreeFile()
		r = ""
        FileOpen(f, MyPath & "\values.dat", OpenMode.Binary)
		r = Space(LOF(f) - 2)
        FileGet(f, r)
		FileClose(f)
		GetCrypt = r
		Exit Function
		
NoCrypt: 
		'file is missing
        m = "A file is missing or corrupted!"
		MsgBox(m, 16, "Error - 18")
		End
		Resume 
    End Function

	Public Sub GetIniExpired(ByRef gExpired As Short)
		'check if program was used over 30 days
        'open the hm.ini file in the application directory
		'and check if program was used over 30 days
		'by checking initial settings for category of words
		
		Dim TmpNum As String
        Dim appname As String
        Dim keyname As String

        appname = "Category"
        keyname = "GFile"
        TmpNum = ""
        ReadIni(TmpNum)
        gExpired = Val(TmpNum)
		
	End Sub
	
	Public Sub PutIniExpired(ByRef gExpired As Short)
		'output a 1 when program is used over 30 days
        'open the hm.ini file in the application directory
		'and output a 1 when program is used over 30 days
		
		Dim TmpNum As String
        Dim appname As String
        Dim keyname As String

        appname = "Category"
        keyname = "GFile"
		TmpNum = Str(gExpired)
        WriteIni(TmpNum)
    End Sub

End Module