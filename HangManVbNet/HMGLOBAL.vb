Option Strict Off
Option Explicit On
Imports System.IO

Module HMGLOBAL
    Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Integer) As Integer

	Public Const HWND_BROADCAST As Integer = &HFFFF
	Public Const WM_FONTCHANGE As Short = &H1Ds
	
	'number of characters in alphabet
	Public Const MAXCHARS As Short = 26
	'Global Const MAXWORDS = 3500
	Public Const MAXARRAY As Short = 14 '0 to 14
	
	'MAXHOLD is the maximum chars in word
	Public Const MAXHOLD As Short = 15
	
	'an empty letter slot in the word
	Public Const NOLETTER As Short = -1
	
	'Delay
	Public Const NEWDELAY As Double = 2#
	
	'word structure - word to guess from list
	Structure WORDINFO
		Dim Letter As String
		Dim Used As Short 'True if letter has been guessed
	End Structure
	
	'word information, what letter is in what slot
	Public WInfo(MAXHOLD) As WORDINFO
	Public LInfo(MAXHOLD) As WORDINFO
	
    Structure FILEINFO
        Dim TmpNum As Short
        <VBFixedString(15)> Public TmpStr As String
    End Structure

    Public MyRecord As FILEINFO

    'man structure - which part to show in list
    '1=Head 2=Body 3=Larm 4=Rarm 5=Lleg 6=Rleg
    'following items added for beginner level
    '7=Lhand 8=Rhand 9=Lfoot 10=Rfoot
    Structure MANINFO
        Dim flag As Short
    End Structure

    'man information, which part to show in list 0 thru 9, 10 items in array
    Public MInfo(9) As MANINFO

    'card structure, info where card is on form and what value card has
    Structure CARDINFO
        Dim FormIndex As Short 'hold location on form index
        Dim CardIndex As Short 'hold location of card
        Dim CardVal As Short 'hold card value
        Dim CardFlag As Short 'true id matched
    End Structure

    Public Wnum As Short 'holds start of empty space in array
    Public gNum As Short 'index to word in data file
    Public gWord As String 'hold new word to guess
    Public gSound As Short 'flag, true when sound is on
    Public gExpired As Short 'flag, true when over 30 days
    Public gDaysLeft As Integer 'number of days in demo
    Public gDaysUsed As Integer ' number of days used
    Public gExpireFlag As Short 'set to false to turn off demo

    Public gFont As Short 'flag, true when font is found
    Public gLevel As Short 'mode of player, true for advanced
    Public gFileok As Short 'flag for file found
    Public MaxNum As Short 'number of body parts - 6
    Public MaxGames As Short 'number of games in play
    Public MaxWins As Short 'number of wins in play
    Public Beginner As Short
    Public Intermediate As Short
    Public Advanced As Short
    Public MustReDeal As Short 'when to redeal cards
    Public InPlay As Short 'when games is started
    Public FCard As Short 'first card selected for user
    Public NFile As Short 'number of file to use for category
    Public MyPath As String     'Object 'current path c:\windows
    Public MyFile As String     'Object 'set to cs.ini file
    Public NewCards As Object 'true to refresh new backs
    Public MAXWORDS As Integer

    Public Style As String
    Public Title As String
    Public Help As String
    Public Msg As String
    Public Ans As String

    'messageBox
    Public Const HM_MSG As String = "Hang Man!" ' used in title of msgbox
    Public Const MB_OK As Short = 0
    Public Const MB_OKCANCEL As Short = 1 ' define buttons
    Public Const MB_YESNOCANCEL As Short = 3
    Public Const MB_YESNO As Short = 4
    Public Const MB_ICONSTOP As Short = 16
    Public Const MB_ICONQUESTION As Short = 32 ' define icons
    Public Const MB_ICONEXCLAMATION As Short = 48
    Public Const MB_ICONINFORMATION As Short = 64
    Public Const MB_DEFBUTTON2 As Short = 256
    Public Const IDYES As Short = 6
    Public Const IDNO As Short = 7
    Public Const IDCANCEL As Short = 2
    Public Const IDOK As Short = 1 ' define other
    Public Const MB_DEFBUTTON1 As Short = 0
    Public Const MB_DEFBUTTON3 As Short = 512
    ' Message box beep constants
    Public Const MB_DEFBEEP As Short = -1
    Public Const MB_ICONASTERISK As Short = 64
    Public Const MB_ICONHAND As Short = 16
    ' WinsndPlaySound constants
    Public Const SND_SYNC As Short = 0
    Public Const SND_ASYNC As Short = 1
    Public Const SND_NODEFAULT As Short = 2
    Public Const SND_LOOP As Short = 8
    Public Const SND_NOSTOP As Short = 16

    ' MCI Buttons
    Public Const MIDIOPEN As Short = 0
    Public Const MIDIPLAY As Short = 1
    Public Const MIDISTOP As Short = 2
    Public Const MIDICLOSE As Short = 3

    ' Windows API Sound functions
    Declare Sub MessageBeep Lib "user32" (ByVal BeepType As Short)
    Declare Function WinsndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Public Sub GetAlphaLetter(ByRef Index As Short, ByRef AlphaLetter As String)
        'convert index to letter of alphabet and assign the char to AlphaLetter
        Select Case Index
            Case 0
                AlphaLetter = "A"
            Case 1
                AlphaLetter = "B"
            Case 2
                AlphaLetter = "C"
            Case 3
                AlphaLetter = "D"
            Case 4
                AlphaLetter = "E"
            Case 5
                AlphaLetter = "F"
            Case 6
                AlphaLetter = "G"
            Case 7
                AlphaLetter = "H"
            Case 8
                AlphaLetter = "I"
            Case 9
                AlphaLetter = "J"
            Case 10
                AlphaLetter = "K"
            Case 11
                AlphaLetter = "L"
            Case 12
                AlphaLetter = "M"
            Case 13
                AlphaLetter = "N"
            Case 14
                AlphaLetter = "O"
            Case 15
                AlphaLetter = "P"
            Case 16
                AlphaLetter = "Q"
            Case 17
                AlphaLetter = "R"
            Case 18
                AlphaLetter = "S"
            Case 19
                AlphaLetter = "T"
            Case 20
                AlphaLetter = "U"
            Case 21
                AlphaLetter = "V"
            Case 22
                AlphaLetter = "W"
            Case 23
                AlphaLetter = "X"
            Case 24
                AlphaLetter = "Y"
            Case 25
                AlphaLetter = "Z"
        End Select
    End Sub

    Public Sub DataFileExist(ByRef MyFile As String, ByRef gFileok As Short)
        'check for file in directory
        Dim filefound As String
        Dim filetosearch As String
        Dim TmpNum As String

        filetosearch = My.Application.Info.DirectoryPath & MyFile
        filefound = Dir(filetosearch, FileAttribute.Normal)
        '    MsgBox filetosearch
        If filefound = "" Then
            gFileok = False
        Else
            FileOpen(9, My.Application.Info.DirectoryPath & MyFile, OpenMode.Random, , , Len(MyRecord))
            'FileOpen(9, My.Application.Info.DirectoryPath & MyFile, OpenMode.Random, , , )
            Do While Not EOF(9)
                FileGet(9, MyRecord)
                TmpNum = CStr(MyRecord.TmpNum)
                If CDbl(TmpNum) <= 0 Then
                    gFileok = False
                Else
                    gFileok = True
                End If
                Exit Do
            Loop
            FileClose(9)
        End If

    End Sub

    Public Function FileExists(ByRef filename As String) As Short
        Dim X As Short

        X = FreeFile()
        On Error Resume Next
        FileOpen(X, filename, OpenMode.Input)
        If Err.Number = 0 Then
            FileExists = True
            FileClose(X)
        Else
            FileExists = False
        End If
    End Function

    Public Sub GetWordsFromFile(ByRef gNum As Short, ByRef gWord As String, ByVal tfile As String)
        'read words from data file
        Dim TempStr As String
        Dim TempNum As String
        Dim I As Short
        Dim ch As String
        Dim newch As String

        On Error GoTo BadData

        'infile is input data file, with words
        FileOpen(9, My.Application.Info.DirectoryPath & tfile, OpenMode.Random, , , Len(MyRecord))
        Do While Not EOF(9)
            FileGet(9, MyRecord)
            TempNum = CStr(MyRecord.TmpNum)

            If (CDbl(TempNum) <= 0 Or CDbl(TempNum) > gNum) Then
                'error in data file
                GoTo BadData
            End If
            If CDbl(TempNum) = gNum Then

                '                Dim TStr As String

                '               TStr = CStr(MyRecord.TmpStr)
                '                MsgBox(TmpNum & " " & TStr)


                TempStr = Encrypt(MyRecord.TmpStr, EKey)
                '                TempStr = Encrypt(TStr, EKey)

                '                MsgBox(TempNum & " " & TempStr)

                newch = CStr(Nothing)
                For I = 1 To 15
                    ch = Mid(TempStr, I, 1)
                    If Asc(ch) < 32 Then
                        Exit For
                    Else
                        newch = newch + ch
                    End If
                Next I
                gWord = newch
                'MsgBox(TempNum & " " & gWord)
                Exit Do
            End If
        Loop
        FileClose(9)
        Exit Sub

BadData:
        'file is missing or corrupted
        Msg = "File is missing or corrupted!"
        MsgBox(Msg, 16, tfile)
        FileClose(9)
        End
        Resume

    End Sub

    Public Sub FindMaxWords(ByRef MAXWORDS As Integer, ByVal tfile As String)
        'find maximum words in data file, assign the amount to MAXWORDS

        Dim tc As Integer

        FileOpen(9, My.Application.Info.DirectoryPath & tfile, OpenMode.Random, , , Len(MyRecord))
        tc = 0
        Do While Not EOF(9)
            FileGet(9, MyRecord)
            If Not EOF(9) Then
                tc = tc + 1
            End If
        Loop
        FileClose(9)
        MAXWORDS = tc

    End Sub

    Public Sub FindCategoryFile(ByRef NFile As Short, ByRef tfile As String)
        'use tfile as global value for filename
        'use NFile as Global value for file number of category
        'determine which category of words to use
        'by using the tfile value from ini file
        'only need to change category if user made a
        'change in category, there are 9 categories
        'animals, food, holidays, home, leisure, seasons
        'sports, weather and misc.

        Select Case NFile
            Case 1
                tfile = "\AppData\animals.dat"
                'tfile = "\animals.txt"
                'tfile = "\anim1.txt"
            Case 2
                tfile = "\AppData\food.dat"
            Case 3
                tfile = "\AppData\holidays.dat"
            Case 4
                tfile = "\AppData\home.dat"
            Case 5
                tfile = "\AppData\leisure.dat"
            Case 6
                tfile = "\AppData\seasons.dat"
            Case 7
                tfile = "\AppData\sports.dat"
            Case 8
                tfile = "\AppData\weather.dat"
            Case 9
                tfile = "\AppData\misc.dat"
            Case Else
                MsgBox("Value not found")
        End Select

    End Sub

    Public Sub PlayLostSound()
        'play sound when user could not find letter
        Dim sflag As Integer
        Dim rc As Integer

        ' Kill any currently playing sound
        rc = WinsndPlaySound("", SND_NODEFAULT)

        ' Set the sound flag to no default
        ' (no sound if file not found), asynchronous (play in the background)
        'sound files must be in application directory
        sflag = SND_NODEFAULT + SND_ASYNC
        rc = WinsndPlaySound(My.Application.Info.DirectoryPath & "\AppData\Nwin2.WAV", sflag)
        If rc = 0 Then
            gSound = 0
            '            SetSoundMenuItems(gSound)
        End If
    End Sub

    Public Sub PlayWinSound()
        'play sound when user wins

        Dim sflag As Integer
        Dim rc As Integer
        Dim tnum As Short

        Randomize() 'initialize random-number generator
        'number between 1 and 2
        tnum = Int((2 * Rnd()) + 1)
        ' Kill any currently playing sound
        rc = WinsndPlaySound("", SND_NODEFAULT)

        ' Set the sound flag to no default
        ' (no sound if file not found),
        ' and asynchronous (play in the background)
        sflag = SND_NODEFAULT + SND_ASYNC

        ' Determine the sound to play
        Select Case tnum
            Case 1
                rc = WinsndPlaySound(My.Application.Info.DirectoryPath & "\AppData\Ywin1.WAV", sflag)
            Case 2
                rc = WinsndPlaySound(My.Application.Info.DirectoryPath & "\AppData\Ywin2.WAV", sflag)
            Case Else
                'play no sound
                MsgBox("Number greater than 2 " & tnum)
        End Select
        If rc = 0 Then
            gSound = 0
            '            SetSoundMenuItems(gSound)
        End If
    End Sub

    Public Sub PlayEndSound()
        'play sound at end of turn
        Dim sflag As Integer
        Dim rc As Integer

        ' Kill any currently playing sound
        rc = WinsndPlaySound("", SND_NODEFAULT)

        ' Set the sound flag to no default
        ' (no sound if file not found),
        ' and asynchronous (play in the background)
        sflag = SND_NODEFAULT + SND_ASYNC
        rc = WinsndPlaySound(My.Application.Info.DirectoryPath & "\AppData\End.WAV", sflag)
        If rc = 0 Then
            gSound = 0
            '            SetSoundMenuItems(gSound)
        End If
    End Sub

    Public Sub GetWordFromFile(ByRef gNum As Short, ByRef gWord As String, ByVal tfile As String)
        '
        'this sub is not used
        '
        'open file and get new word
        Dim tmp As Short

        FileOpen(9, My.Application.Info.DirectoryPath & tfile, OpenMode.Input)
        Do While Not EOF(9)
            Input(9, tmp)
            Input(9, gWord)
            If tmp = gNum Then
                'MsgBox "Found " & gNum & " is " & gWord
                Exit Do
            End If
        Loop
        FileClose(9)

    End Sub

    Public Sub FindMaxWordsInFile(ByRef MAXWORDS As Integer, ByVal tfile As String)
        '
        'this sub not used
        '
        'find maximum words in file, assign the amount to MAXWORDS

        Dim tc As Integer
        Dim I As Short
        Dim z As String

        z = ""
        FileOpen(9, My.Application.Info.DirectoryPath & tfile, OpenMode.Input)
        tc = 0
        Do While Not EOF(9)
            Input(9, I)
            Input(9, z)
            tc = tc + 1
        Loop
        FileClose(9)
        MAXWORDS = tc

    End Sub

    Public Sub FindLenOfWord(ByRef MaxNum As Short, ByRef maxflag As Short, ByVal tfile As String)
        '
        'this sub is used for testing
        '
        'open file and find length of longest word
        'open file and get new word
        Dim tmp As Short
        Dim I As Short
        Dim X As Short

        FileOpen(9, My.Application.Info.DirectoryPath & tfile, OpenMode.Input)
        X = 0
        Do While Not EOF(9)
            Input(9, tmp)
            Input(9, gWord)
            I = Len(gWord)
            If I > X Then
                X = I
            End If
        Loop
        FileClose(9)
        If X > 0 And X <= 15 Then
            maxflag = True
        Else
            'MsgBox "Length of longest word is " & X
            maxflag = False
            MaxNum = X
        End If
    End Sub

    Function GetRandom(ByRef range As Short) As Short
        '
        'this function not used
        '
        'this function returns a random number between 0 and range%-1, inclusive.
        'the generic formula is: Int((upperbound-lowerbound+1)*Rnd+lowerbound)
        GetRandom = Int(range * Rnd())

    End Function

End Module