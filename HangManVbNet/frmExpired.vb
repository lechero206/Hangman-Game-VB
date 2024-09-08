Option Strict Off
Option Explicit On
Friend Class frmExpired
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
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents _Line1_3 As System.Windows.Forms.Label
	Public WithEvents _Line1_2 As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _Line1_1 As System.Windows.Forms.Label
    Public WithEvents lblDescription As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents _Line1_0 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpired))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me._Line1_3 = New System.Windows.Forms.Label
        Me._Line1_2 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.Picture1.Location = New System.Drawing.Point(38, 20)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(32, 32)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture1.TabIndex = 9
        Me.Picture1.TabStop = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(144, 298)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(94, 27)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(269, 39)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(87, 20)
        Me.lblVersion.TabIndex = 10
        Me.lblVersion.Text = "Version"
        '
        '_Line1_3
        '
        Me._Line1_3.BackColor = System.Drawing.Color.White
        Me._Line1_3.Location = New System.Drawing.Point(19, 73)
        Me._Line1_3.Name = "_Line1_3"
        Me._Line1_3.Size = New System.Drawing.Size(337, 1)
        Me._Line1_3.TabIndex = 11
        '
        '_Line1_2
        '
        Me._Line1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_2.Location = New System.Drawing.Point(19, 71)
        Me._Line1_2.Name = "_Line1_2"
        Me._Line1_2.Size = New System.Drawing.Size(337, 2)
        Me._Line1_2.TabIndex = 12
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 22.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(79, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(193, 49)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Hang Man!"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(351, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "This registration fee is $19.95 U.S.  Upon registration, a notice-free update wil" & _
            "l be sent to you.  Thank you for your interest."
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_1.Location = New System.Drawing.Point(19, 284)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(337, 2)
        Me._Line1_1.TabIndex = 13
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(16, 79)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(378, 16)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "The 30 day evaluation period for this software has expired."
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.White
        Me._Line1_0.Location = New System.Drawing.Point(19, 284)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(337, 2)
        Me._Line1_0.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(203, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "To register, visit our website:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(322, 41)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "http://www.vbgames.com"
        '
        'frmExpired
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = New System.Drawing.Size(413, 451)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me._Line1_3)
        Me.Controls.Add(Me._Line1_2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me._Line1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(128, 126)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExpired"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Expired"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmExpired_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Center the Form on the screen
        Me.SetBounds((System.Windows.Forms.Screen.GetBounds(Me).Width / 2) - (Me.Width / 2), _
            (System.Windows.Forms.Screen.GetBounds(Me).Height / 2) - (Me.Height / 2), _
            Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)

        lblVersion.Text = "Version " & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "."
        ' & App.Revision
        lblTitle.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
    End Sub
End Class