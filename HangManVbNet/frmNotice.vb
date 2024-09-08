Option Strict Off
Option Explicit On
Friend Class frmNotice
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
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents _Line1_1 As System.Windows.Forms.Label
    Public WithEvents lblDescription As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents _Line1_0 As System.Windows.Forms.Label
    Public WithEvents lblDisclaimer As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotice))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdOK = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me._Line1_1 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me._Line1_0 = New System.Windows.Forms.Label
        Me.lblDisclaimer = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(182, 368)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(94, 28)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(86, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(280, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "** ALL RIGHTS RESERVED **"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(48, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(203, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "To register, visit our website:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(322, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "http://www.vbgames.com"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(376, 65)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This registration fee is $19.95 U.S.  Upon registration, a notice-free update wil" & _
            "l be sent to you.  Thank you for your interest."
        '
        '_Line1_1
        '
        Me._Line1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._Line1_1.Location = New System.Drawing.Point(16, 233)
        Me._Line1_1.Name = "_Line1_1"
        Me._Line1_1.Size = New System.Drawing.Size(420, 1)
        Me._Line1_1.TabIndex = 11
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescription.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(48, 39)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(376, 41)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "This software is not free.  It is considered SHAREWARE.  The evaluation period fo" & _
            "r this software is 30 days."
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(134, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(165, 20)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "** NOTICE **"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Line1_0
        '
        Me._Line1_0.BackColor = System.Drawing.Color.White
        Me._Line1_0.Location = New System.Drawing.Point(16, 233)
        Me._Line1_0.Name = "_Line1_0"
        Me._Line1_0.Size = New System.Drawing.Size(420, 1)
        Me._Line1_0.TabIndex = 12
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.BackColor = System.Drawing.Color.Transparent
        Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisclaimer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
        Me.lblDisclaimer.Location = New System.Drawing.Point(19, 246)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDisclaimer.Size = New System.Drawing.Size(423, 76)
        Me.lblDisclaimer.TabIndex = 2
        Me.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text")
        '
        'frmNotice
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = New System.Drawing.Size(469, 436)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._Line1_1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me._Line1_0)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(149, 112)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Please Support Shareware!"
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmNotice_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' Center the Form on the screen
        Me.SetBounds((System.Windows.Forms.Screen.GetBounds(Me).Width / 2) - (Me.Width / 2), _
            (System.Windows.Forms.Screen.GetBounds(Me).Height / 2) - (Me.Height / 2), _
            Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)

    End Sub
End Class