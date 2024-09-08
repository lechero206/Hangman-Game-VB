Option Strict Off
Option Explicit On
Friend Class frmAbout
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents _Line1_5 As System.Windows.Forms.Label
	Public WithEvents _Line1_4 As System.Windows.Forms.Label
	Public WithEvents _Line1_3 As System.Windows.Forms.Label
	Public WithEvents _Line1_2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _Line1_1 As System.Windows.Forms.Label
    Public WithEvents lblDescription As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents _Line1_0 As System.Windows.Forms.Label
    Public WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblExpires As System.Windows.Forms.Label
    Public WithEvents lblDisclaimer As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me._Line1_5 = New System.Windows.Forms.Label
        Me._Line1_4 = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblDisclaimer = New System.Windows.Forms.Label
        Me.lblExpires = New System.Windows.Forms.Label
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(38, 16)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(32, 32)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture1.TabIndex = 10
        Me.Picture1.TabStop = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(182, 363)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(94, 28)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        '_Line1_5
        '
        Me._Line1_5.BackColor = System.Drawing.Color.White
        Me._Line1_5.Location = New System.Drawing.Point(30, 68)
        Me._Line1_5.Name = "_Line1_5"
        Me._Line1_5.Size = New System.Drawing.Size(390, 1)
        Me._Line1_5.TabIndex = 11
        '
        '_Line1_4
        '
        Me._Line1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_4.Location = New System.Drawing.Point(30, 66)
        Me._Line1_4.Name = "_Line1_4"
        Me._Line1_4.Size = New System.Drawing.Size(390, 2)
        Me._Line1_4.TabIndex = 12
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.Color.White
        Me._Line1_3.Location = New System.Drawing.Point(30, 262)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(390, 1)
        Me._Line1_3.TabIndex = 13
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_2.Location = New System.Drawing.Point(30, 261)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(390, 1)
        Me._Line1_2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(391, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Vist our website at http://www.vbgames.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "VbGames"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(413, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "This registration fee is $19.95 U.S. Upon registration, a notice-free update will" & _
            " be sent to you."
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_1.Location = New System.Drawing.Point(30, 149)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(390, 1)
        Me._Line1_1.TabIndex = 15
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(29, 164)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(375, 43)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Please Note:  This software is not free.  It is considered SHAREWARE.  The evalua" & _
            "tion period for this software is 30 days."
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 22.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(77, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(199, 49)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Hang Man!"
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.White
        Me._Line1_0.Location = New System.Drawing.Point(30, 149)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(390, 1)
        Me._Line1_0.TabIndex = 16
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(278, 70)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(88, 20)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version"
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.BackColor = System.Drawing.Color.Transparent
        Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisclaimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
        Me.lblDisclaimer.Location = New System.Drawing.Point(29, 276)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDisclaimer.Size = New System.Drawing.Size(413, 78)
        Me.lblDisclaimer.TabIndex = 2
        Me.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text")
        '
        'lblExpires
        '
        Me.lblExpires.AutoSize = True
        Me.lblExpires.Location = New System.Drawing.Point(30, 404)
        Me.lblExpires.Name = "lblExpires"
        Me.lblExpires.Size = New System.Drawing.Size(51, 16)
        Me.lblExpires.TabIndex = 17
        Me.lblExpires.Text = "Label6"
        Me.lblExpires.Visible = False
        '
        'frmAbout
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = New System.Drawing.Size(492, 462)
        Me.Controls.Add(Me.lblExpires)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me._Line1_5)
        Me.Controls.Add(Me._Line1_4)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(117, 123)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "About"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' Center the Form on the screen
        Me.SetBounds((System.Windows.Forms.Screen.GetBounds(Me).Width / 2) - (Me.Width / 2), _
            (System.Windows.Forms.Screen.GetBounds(Me).Height / 2) - (Me.Height / 2), _
            Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)

        'Me.Caption = "About " & App.Title
        lblVersion.Text = "Version " & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "."
        '& App.Revision
        lblTitle.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name

        If Not gExpireFlag Then
            lblExpires.Visible = True
            lblExpires.Text = "Expires in " & gDaysLeft & " days."
            'MsgBox("Expires in " & gDaysLeft & " days.")
        End If

    End Sub
End Class