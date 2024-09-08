Option Strict Off
Option Explicit On
Imports System.IO

Friend Class frmMain
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
        'This call is required by the Windows Form Designer.
		InitializeComponent()
        Form_Initialize_Game()
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
    Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents cmdNewGame As System.Windows.Forms.Button
    Public WithEvents Rfoot As System.Windows.Forms.Label
    Public WithEvents Lfoot As System.Windows.Forms.Label
    Public WithEvents Rhand As System.Windows.Forms.Label
    Public WithEvents Lhand As System.Windows.Forms.Label
    Public WithEvents lblmaxwords As System.Windows.Forms.Label
    Public WithEvents lblfilename As System.Windows.Forms.Label
    Public WithEvents lblWordIs As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents mnuNewGame As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileBar1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuAnimals As System.Windows.Forms.MenuItem
    Public WithEvents mnuFood As System.Windows.Forms.MenuItem
    Public WithEvents mnuHolidays As System.Windows.Forms.MenuItem
    Public WithEvents mnuHome As System.Windows.Forms.MenuItem
    Public WithEvents mnuLeisure As System.Windows.Forms.MenuItem
    Public WithEvents mnuSeasons As System.Windows.Forms.MenuItem
    Public WithEvents mnuSports As System.Windows.Forms.MenuItem
    Public WithEvents mnuWeather As System.Windows.Forms.MenuItem
    Public WithEvents mnuMisc As System.Windows.Forms.MenuItem
    Public WithEvents mnuSelectGame As System.Windows.Forms.MenuItem
    Public WithEvents mnuEditBar1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuBeginner As System.Windows.Forms.MenuItem
    Public WithEvents mnuAdvanced As System.Windows.Forms.MenuItem
    Public WithEvents mnuLevel As System.Windows.Forms.MenuItem
    Public WithEvents mnuEditBar2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuSoundOn As System.Windows.Forms.MenuItem
    Public WithEvents mnuSoundOff As System.Windows.Forms.MenuItem
    Public WithEvents mnuSound As System.Windows.Forms.MenuItem
    Public WithEvents mnuOptions As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpRules As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpBar1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpPrint As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpBar2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents lblLetter0 As System.Windows.Forms.Label
    Friend WithEvents lblLetter1 As System.Windows.Forms.Label
    Friend WithEvents lblLetter2 As System.Windows.Forms.Label
    Friend WithEvents lblLetter3 As System.Windows.Forms.Label
    Friend WithEvents lblLetter4 As System.Windows.Forms.Label
    Friend WithEvents lblLetter5 As System.Windows.Forms.Label
    Friend WithEvents lblLetter6 As System.Windows.Forms.Label
    Friend WithEvents lblLetter7 As System.Windows.Forms.Label
    Friend WithEvents lblLetter8 As System.Windows.Forms.Label
    Friend WithEvents lblLetter9 As System.Windows.Forms.Label
    Friend WithEvents lblLetter10 As System.Windows.Forms.Label
    Friend WithEvents lblLetter11 As System.Windows.Forms.Label
    Friend WithEvents lblLetter12 As System.Windows.Forms.Label
    Friend WithEvents lblLetter13 As System.Windows.Forms.Label
    Friend WithEvents lblLetter14 As System.Windows.Forms.Label
    Friend WithEvents lblWLine0 As System.Windows.Forms.Label
    Friend WithEvents lblWLine1 As System.Windows.Forms.Label
    Friend WithEvents lblWLine2 As System.Windows.Forms.Label
    Friend WithEvents lblWLine3 As System.Windows.Forms.Label
    Friend WithEvents lblWLine4 As System.Windows.Forms.Label
    Friend WithEvents lblWLine5 As System.Windows.Forms.Label
    Friend WithEvents lblWLine6 As System.Windows.Forms.Label
    Friend WithEvents lblWLine7 As System.Windows.Forms.Label
    Friend WithEvents lblWLine8 As System.Windows.Forms.Label
    Friend WithEvents lblWLine9 As System.Windows.Forms.Label
    Friend WithEvents lblWLine10 As System.Windows.Forms.Label
    Friend WithEvents lblWLine11 As System.Windows.Forms.Label
    Friend WithEvents lblWLine12 As System.Windows.Forms.Label
    Friend WithEvents lblWLine13 As System.Windows.Forms.Label
    Friend WithEvents lblWLine14 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha0 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha1 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha2 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha3 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha4 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha5 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha6 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha7 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha8 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha9 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha10 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha11 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha12 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha13 As System.Windows.Forms.Label
    Friend WithEvents lblAlpha14 As System.Windows.Forms.Label
    Public WithEvents cmdLetter0 As System.Windows.Forms.Button
    Public WithEvents cmdLetter1 As System.Windows.Forms.Button
    Public WithEvents cmdLetter2 As System.Windows.Forms.Button
    Public WithEvents cmdLetter3 As System.Windows.Forms.Button
    Public WithEvents cmdLetter4 As System.Windows.Forms.Button
    Public WithEvents cmdLetter5 As System.Windows.Forms.Button
    Public WithEvents cmdLetter6 As System.Windows.Forms.Button
    Public WithEvents cmdLetter12 As System.Windows.Forms.Button
    Public WithEvents cmdLetter11 As System.Windows.Forms.Button
    Public WithEvents cmdLetter10 As System.Windows.Forms.Button
    Public WithEvents cmdLetter9 As System.Windows.Forms.Button
    Public WithEvents cmdLetter8 As System.Windows.Forms.Button
    Public WithEvents cmdLetter7 As System.Windows.Forms.Button
    Public WithEvents cmdLetter25 As System.Windows.Forms.Button
    Public WithEvents cmdLetter24 As System.Windows.Forms.Button
    Public WithEvents cmdLetter23 As System.Windows.Forms.Button
    Public WithEvents cmdLetter22 As System.Windows.Forms.Button
    Public WithEvents cmdLetter21 As System.Windows.Forms.Button
    Public WithEvents cmdLetter20 As System.Windows.Forms.Button
    Public WithEvents cmdLetter19 As System.Windows.Forms.Button
    Public WithEvents cmdLetter18 As System.Windows.Forms.Button
    Public WithEvents cmdLetter17 As System.Windows.Forms.Button
    Public WithEvents cmdLetter16 As System.Windows.Forms.Button
    Public WithEvents cmdLetter15 As System.Windows.Forms.Button
    Public WithEvents cmdLetter14 As System.Windows.Forms.Button
    Public WithEvents cmdLetter13 As System.Windows.Forms.Button
    Public WithEvents lblShowWord As System.Windows.Forms.Label
    Public WithEvents lblMaxChars As System.Windows.Forms.Label

    Friend WithEvents sbStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel

    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel

    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdNewGame = New System.Windows.Forms.Button()
        Me.Rfoot = New System.Windows.Forms.Label()
        Me.Lfoot = New System.Windows.Forms.Label()
        Me.Rhand = New System.Windows.Forms.Label()
        Me.Lhand = New System.Windows.Forms.Label()
        Me.lblmaxwords = New System.Windows.Forms.Label()
        Me.lblfilename = New System.Windows.Forms.Label()
        Me.lblWordIs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line4 = New System.Windows.Forms.Label()
        Me.Line3 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuNewGame = New System.Windows.Forms.MenuItem()
        Me.mnuFileBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuOptions = New System.Windows.Forms.MenuItem()
        Me.mnuSelectGame = New System.Windows.Forms.MenuItem()
        Me.mnuAnimals = New System.Windows.Forms.MenuItem()
        Me.mnuFood = New System.Windows.Forms.MenuItem()
        Me.mnuHolidays = New System.Windows.Forms.MenuItem()
        Me.mnuHome = New System.Windows.Forms.MenuItem()
        Me.mnuLeisure = New System.Windows.Forms.MenuItem()
        Me.mnuSeasons = New System.Windows.Forms.MenuItem()
        Me.mnuSports = New System.Windows.Forms.MenuItem()
        Me.mnuWeather = New System.Windows.Forms.MenuItem()
        Me.mnuMisc = New System.Windows.Forms.MenuItem()
        Me.mnuEditBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuLevel = New System.Windows.Forms.MenuItem()
        Me.mnuBeginner = New System.Windows.Forms.MenuItem()
        Me.mnuAdvanced = New System.Windows.Forms.MenuItem()
        Me.mnuEditBar2 = New System.Windows.Forms.MenuItem()
        Me.mnuSound = New System.Windows.Forms.MenuItem()
        Me.mnuSoundOn = New System.Windows.Forms.MenuItem()
        Me.mnuSoundOff = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHelpRules = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBar1 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpPrint = New System.Windows.Forms.MenuItem()
        Me.mnuHelpBar2 = New System.Windows.Forms.MenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem()
        Me.lblLetter0 = New System.Windows.Forms.Label()
        Me.lblLetter1 = New System.Windows.Forms.Label()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.lblLetter3 = New System.Windows.Forms.Label()
        Me.lblLetter4 = New System.Windows.Forms.Label()
        Me.lblLetter5 = New System.Windows.Forms.Label()
        Me.lblLetter6 = New System.Windows.Forms.Label()
        Me.lblLetter7 = New System.Windows.Forms.Label()
        Me.lblLetter8 = New System.Windows.Forms.Label()
        Me.lblLetter9 = New System.Windows.Forms.Label()
        Me.lblLetter10 = New System.Windows.Forms.Label()
        Me.lblLetter11 = New System.Windows.Forms.Label()
        Me.lblLetter12 = New System.Windows.Forms.Label()
        Me.lblLetter13 = New System.Windows.Forms.Label()
        Me.lblLetter14 = New System.Windows.Forms.Label()
        Me.lblWLine0 = New System.Windows.Forms.Label()
        Me.lblWLine1 = New System.Windows.Forms.Label()
        Me.lblWLine2 = New System.Windows.Forms.Label()
        Me.lblWLine3 = New System.Windows.Forms.Label()
        Me.lblWLine4 = New System.Windows.Forms.Label()
        Me.lblWLine5 = New System.Windows.Forms.Label()
        Me.lblWLine6 = New System.Windows.Forms.Label()
        Me.lblWLine7 = New System.Windows.Forms.Label()
        Me.lblWLine8 = New System.Windows.Forms.Label()
        Me.lblWLine9 = New System.Windows.Forms.Label()
        Me.lblWLine10 = New System.Windows.Forms.Label()
        Me.lblWLine11 = New System.Windows.Forms.Label()
        Me.lblWLine12 = New System.Windows.Forms.Label()
        Me.lblWLine13 = New System.Windows.Forms.Label()
        Me.lblWLine14 = New System.Windows.Forms.Label()
        Me.lblAlpha0 = New System.Windows.Forms.Label()
        Me.lblAlpha1 = New System.Windows.Forms.Label()
        Me.lblAlpha2 = New System.Windows.Forms.Label()
        Me.lblAlpha3 = New System.Windows.Forms.Label()
        Me.lblAlpha4 = New System.Windows.Forms.Label()
        Me.lblAlpha5 = New System.Windows.Forms.Label()
        Me.lblAlpha6 = New System.Windows.Forms.Label()
        Me.lblAlpha7 = New System.Windows.Forms.Label()
        Me.lblAlpha8 = New System.Windows.Forms.Label()
        Me.lblAlpha9 = New System.Windows.Forms.Label()
        Me.lblAlpha10 = New System.Windows.Forms.Label()
        Me.lblAlpha11 = New System.Windows.Forms.Label()
        Me.lblAlpha12 = New System.Windows.Forms.Label()
        Me.lblAlpha13 = New System.Windows.Forms.Label()
        Me.lblAlpha14 = New System.Windows.Forms.Label()
        Me.cmdLetter0 = New System.Windows.Forms.Button()
        Me.cmdLetter1 = New System.Windows.Forms.Button()
        Me.cmdLetter2 = New System.Windows.Forms.Button()
        Me.cmdLetter3 = New System.Windows.Forms.Button()
        Me.cmdLetter4 = New System.Windows.Forms.Button()
        Me.cmdLetter5 = New System.Windows.Forms.Button()
        Me.cmdLetter6 = New System.Windows.Forms.Button()
        Me.cmdLetter12 = New System.Windows.Forms.Button()
        Me.cmdLetter11 = New System.Windows.Forms.Button()
        Me.cmdLetter10 = New System.Windows.Forms.Button()
        Me.cmdLetter9 = New System.Windows.Forms.Button()
        Me.cmdLetter8 = New System.Windows.Forms.Button()
        Me.cmdLetter7 = New System.Windows.Forms.Button()
        Me.cmdLetter25 = New System.Windows.Forms.Button()
        Me.cmdLetter24 = New System.Windows.Forms.Button()
        Me.cmdLetter23 = New System.Windows.Forms.Button()
        Me.cmdLetter22 = New System.Windows.Forms.Button()
        Me.cmdLetter21 = New System.Windows.Forms.Button()
        Me.cmdLetter20 = New System.Windows.Forms.Button()
        Me.cmdLetter19 = New System.Windows.Forms.Button()
        Me.cmdLetter18 = New System.Windows.Forms.Button()
        Me.cmdLetter17 = New System.Windows.Forms.Button()
        Me.cmdLetter16 = New System.Windows.Forms.Button()
        Me.cmdLetter15 = New System.Windows.Forms.Button()
        Me.cmdLetter14 = New System.Windows.Forms.Button()
        Me.cmdLetter13 = New System.Windows.Forms.Button()
        Me.lblShowWord = New System.Windows.Forms.Label()
        Me.lblMaxChars = New System.Windows.Forms.Label()
        Me.sbStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.sbStatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(575, 263)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(65, 33)
        Me.cmdExit.TabIndex = 63
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdExit, "Exit Game")
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdNewGame
        '
        Me.cmdNewGame.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNewGame.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNewGame.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewGame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNewGame.Image = CType(resources.GetObject("cmdNewGame.Image"), System.Drawing.Image)
        Me.cmdNewGame.Location = New System.Drawing.Point(503, 263)
        Me.cmdNewGame.Name = "cmdNewGame"
        Me.cmdNewGame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNewGame.Size = New System.Drawing.Size(65, 33)
        Me.cmdNewGame.TabIndex = 62
        Me.cmdNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdNewGame, "Start New game")
        Me.cmdNewGame.UseVisualStyleBackColor = False
        '
        'Rfoot
        '
        Me.Rfoot.BackColor = System.Drawing.SystemColors.WindowText
        Me.Rfoot.Location = New System.Drawing.Point(196, 308)
        Me.Rfoot.Name = "Rfoot"
        Me.Rfoot.Size = New System.Drawing.Size(10, 1)
        Me.Rfoot.TabIndex = 64
        '
        'Lfoot
        '
        Me.Lfoot.BackColor = System.Drawing.SystemColors.WindowText
        Me.Lfoot.Location = New System.Drawing.Point(116, 308)
        Me.Lfoot.Name = "Lfoot"
        Me.Lfoot.Size = New System.Drawing.Size(10, 1)
        Me.Lfoot.TabIndex = 65
        '
        'Rhand
        '
        Me.Rhand.BackColor = System.Drawing.SystemColors.WindowText
        Me.Rhand.Location = New System.Drawing.Point(196, 213)
        Me.Rhand.Name = "Rhand"
        Me.Rhand.Size = New System.Drawing.Size(10, 1)
        Me.Rhand.TabIndex = 66
        '
        'Lhand
        '
        Me.Lhand.BackColor = System.Drawing.SystemColors.WindowText
        Me.Lhand.Location = New System.Drawing.Point(116, 213)
        Me.Lhand.Name = "Lhand"
        Me.Lhand.Size = New System.Drawing.Size(10, 1)
        Me.Lhand.TabIndex = 67
        '
        'lblmaxwords
        '
        Me.lblmaxwords.BackColor = System.Drawing.Color.Transparent
        Me.lblmaxwords.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmaxwords.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaxwords.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmaxwords.Location = New System.Drawing.Point(585, 473)
        Me.lblmaxwords.Name = "lblmaxwords"
        Me.lblmaxwords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmaxwords.Size = New System.Drawing.Size(99, 17)
        Me.lblmaxwords.TabIndex = 65
        Me.lblmaxwords.Text = "Maxwords"
        Me.lblmaxwords.Visible = False
        '
        'lblfilename
        '
        Me.lblfilename.BackColor = System.Drawing.Color.Transparent
        Me.lblfilename.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblfilename.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfilename.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblfilename.Location = New System.Drawing.Point(585, 497)
        Me.lblfilename.Name = "lblfilename"
        Me.lblfilename.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblfilename.Size = New System.Drawing.Size(99, 17)
        Me.lblfilename.TabIndex = 64
        Me.lblfilename.Text = "filename"
        Me.lblfilename.Visible = False
        '
        'lblWordIs
        '
        Me.lblWordIs.BackColor = System.Drawing.Color.Transparent
        Me.lblWordIs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWordIs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordIs.ForeColor = System.Drawing.Color.Black
        Me.lblWordIs.Location = New System.Drawing.Point(155, 491)
        Me.lblWordIs.Name = "lblWordIs"
        Me.lblWordIs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWordIs.Size = New System.Drawing.Size(107, 17)
        Me.lblWordIs.TabIndex = 61
        Me.lblWordIs.Text = "The word is:"
        Me.lblWordIs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(328, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Select a letter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(375, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(258, 55)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Hang Man!"
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line4.Location = New System.Drawing.Point(161, 137)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(1, 12)
        Me.Line4.TabIndex = 79
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line3.Location = New System.Drawing.Point(56, 318)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(50, 10)
        Me.Line3.TabIndex = 80
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line2.Location = New System.Drawing.Point(77, 127)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(125, 10)
        Me.Line2.TabIndex = 81
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Line1.Location = New System.Drawing.Point(77, 128)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(10, 195)
        Me.Line1.TabIndex = 82
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 16.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(180, 358)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(121, 25)
        Me.lblStatus.TabIndex = 28
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuOptions, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewGame, Me.mnuFileBar1, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Index = 0
        Me.mnuNewGame.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mnuNewGame.Text = "&New Game"
        '
        'mnuFileBar1
        '
        Me.mnuFileBar1.Index = 1
        Me.mnuFileBar1.Text = "-"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 2
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuOptions
        '
        Me.mnuOptions.Index = 1
        Me.mnuOptions.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSelectGame, Me.mnuEditBar1, Me.mnuLevel, Me.mnuEditBar2, Me.mnuSound})
        Me.mnuOptions.Text = "&Options"
        '
        'mnuSelectGame
        '
        Me.mnuSelectGame.Index = 0
        Me.mnuSelectGame.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAnimals, Me.mnuFood, Me.mnuHolidays, Me.mnuHome, Me.mnuLeisure, Me.mnuSeasons, Me.mnuSports, Me.mnuWeather, Me.mnuMisc})
        Me.mnuSelectGame.Text = "&Select Game"
        '
        'mnuAnimals
        '
        Me.mnuAnimals.Index = 0
        Me.mnuAnimals.Text = "&Animals"
        '
        'mnuFood
        '
        Me.mnuFood.Index = 1
        Me.mnuFood.Text = "&Food"
        '
        'mnuHolidays
        '
        Me.mnuHolidays.Index = 2
        Me.mnuHolidays.Text = "&Holidays"
        '
        'mnuHome
        '
        Me.mnuHome.Index = 3
        Me.mnuHome.Text = "H&ome"
        '
        'mnuLeisure
        '
        Me.mnuLeisure.Index = 4
        Me.mnuLeisure.Text = "&Liesure"
        '
        'mnuSeasons
        '
        Me.mnuSeasons.Index = 5
        Me.mnuSeasons.Text = "S&easons"
        '
        'mnuSports
        '
        Me.mnuSports.Index = 6
        Me.mnuSports.Text = "&Sports"
        '
        'mnuWeather
        '
        Me.mnuWeather.Index = 7
        Me.mnuWeather.Text = "&Weather"
        '
        'mnuMisc
        '
        Me.mnuMisc.Index = 8
        Me.mnuMisc.Text = "&Misc"
        '
        'mnuEditBar1
        '
        Me.mnuEditBar1.Index = 1
        Me.mnuEditBar1.Text = "-"
        '
        'mnuLevel
        '
        Me.mnuLevel.Index = 2
        Me.mnuLevel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBeginner, Me.mnuAdvanced})
        Me.mnuLevel.Text = "&Level"
        '
        'mnuBeginner
        '
        Me.mnuBeginner.Index = 0
        Me.mnuBeginner.Text = "&Beginner"
        '
        'mnuAdvanced
        '
        Me.mnuAdvanced.Checked = True
        Me.mnuAdvanced.Index = 1
        Me.mnuAdvanced.Text = "&Advanced"
        '
        'mnuEditBar2
        '
        Me.mnuEditBar2.Index = 3
        Me.mnuEditBar2.Text = "-"
        '
        'mnuSound
        '
        Me.mnuSound.Index = 4
        Me.mnuSound.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSoundOn, Me.mnuSoundOff})
        Me.mnuSound.Text = "Sound"
        '
        'mnuSoundOn
        '
        Me.mnuSoundOn.Checked = True
        Me.mnuSoundOn.Index = 0
        Me.mnuSoundOn.Text = "On"
        '
        'mnuSoundOff
        '
        Me.mnuSoundOff.Index = 1
        Me.mnuSoundOff.Text = "Off"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpRules, Me.mnuHelpBar1, Me.mnuHelpPrint, Me.mnuHelpBar2, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpRules
        '
        Me.mnuHelpRules.Index = 0
        Me.mnuHelpRules.Text = "&How To Play"
        '
        'mnuHelpBar1
        '
        Me.mnuHelpBar1.Index = 1
        Me.mnuHelpBar1.Text = "-"
        '
        'mnuHelpPrint
        '
        Me.mnuHelpPrint.Index = 2
        Me.mnuHelpPrint.Text = "&Print Order Form"
        '
        'mnuHelpBar2
        '
        Me.mnuHelpBar2.Index = 3
        Me.mnuHelpBar2.Text = "-"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 4
        Me.mnuHelpAbout.Text = "&About Hangman..."
        '
        'lblLetter0
        '
        Me.lblLetter0.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter0.Location = New System.Drawing.Point(142, 410)
        Me.lblLetter0.Name = "lblLetter0"
        Me.lblLetter0.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter0.TabIndex = 95
        Me.lblLetter0.Text = "x"
        Me.lblLetter0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter1
        '
        Me.lblLetter1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(167, 410)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter1.TabIndex = 96
        Me.lblLetter1.Text = "x"
        Me.lblLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter2
        '
        Me.lblLetter2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(192, 410)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter2.TabIndex = 97
        Me.lblLetter2.Text = "x"
        Me.lblLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter3
        '
        Me.lblLetter3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(217, 410)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter3.TabIndex = 98
        Me.lblLetter3.Text = "x"
        Me.lblLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter4
        '
        Me.lblLetter4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter4.Location = New System.Drawing.Point(242, 410)
        Me.lblLetter4.Name = "lblLetter4"
        Me.lblLetter4.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter4.TabIndex = 99
        Me.lblLetter4.Text = "x"
        Me.lblLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter5
        '
        Me.lblLetter5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter5.Location = New System.Drawing.Point(267, 410)
        Me.lblLetter5.Name = "lblLetter5"
        Me.lblLetter5.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter5.TabIndex = 100
        Me.lblLetter5.Text = "x"
        Me.lblLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter6
        '
        Me.lblLetter6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter6.Location = New System.Drawing.Point(292, 410)
        Me.lblLetter6.Name = "lblLetter6"
        Me.lblLetter6.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter6.TabIndex = 101
        Me.lblLetter6.Text = "x"
        Me.lblLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter7
        '
        Me.lblLetter7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter7.Location = New System.Drawing.Point(317, 410)
        Me.lblLetter7.Name = "lblLetter7"
        Me.lblLetter7.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter7.TabIndex = 102
        Me.lblLetter7.Text = "x"
        Me.lblLetter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter8
        '
        Me.lblLetter8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter8.Location = New System.Drawing.Point(342, 410)
        Me.lblLetter8.Name = "lblLetter8"
        Me.lblLetter8.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter8.TabIndex = 103
        Me.lblLetter8.Text = "x"
        Me.lblLetter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter9
        '
        Me.lblLetter9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter9.Location = New System.Drawing.Point(367, 410)
        Me.lblLetter9.Name = "lblLetter9"
        Me.lblLetter9.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter9.TabIndex = 104
        Me.lblLetter9.Text = "x"
        Me.lblLetter9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter10
        '
        Me.lblLetter10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter10.Location = New System.Drawing.Point(392, 410)
        Me.lblLetter10.Name = "lblLetter10"
        Me.lblLetter10.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter10.TabIndex = 105
        Me.lblLetter10.Text = "x"
        Me.lblLetter10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter11
        '
        Me.lblLetter11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter11.Location = New System.Drawing.Point(417, 410)
        Me.lblLetter11.Name = "lblLetter11"
        Me.lblLetter11.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter11.TabIndex = 106
        Me.lblLetter11.Text = "x"
        Me.lblLetter11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter12
        '
        Me.lblLetter12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter12.Location = New System.Drawing.Point(442, 410)
        Me.lblLetter12.Name = "lblLetter12"
        Me.lblLetter12.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter12.TabIndex = 107
        Me.lblLetter12.Text = "x"
        Me.lblLetter12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter13
        '
        Me.lblLetter13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter13.Location = New System.Drawing.Point(467, 410)
        Me.lblLetter13.Name = "lblLetter13"
        Me.lblLetter13.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter13.TabIndex = 108
        Me.lblLetter13.Text = "x"
        Me.lblLetter13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLetter14
        '
        Me.lblLetter14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter14.Location = New System.Drawing.Point(492, 410)
        Me.lblLetter14.Name = "lblLetter14"
        Me.lblLetter14.Size = New System.Drawing.Size(20, 25)
        Me.lblLetter14.TabIndex = 109
        Me.lblLetter14.Text = "x"
        Me.lblLetter14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWLine0
        '
        Me.lblWLine0.BackColor = System.Drawing.Color.Black
        Me.lblWLine0.Location = New System.Drawing.Point(142, 440)
        Me.lblWLine0.Name = "lblWLine0"
        Me.lblWLine0.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine0.TabIndex = 110
        '
        'lblWLine1
        '
        Me.lblWLine1.BackColor = System.Drawing.Color.Black
        Me.lblWLine1.Location = New System.Drawing.Point(167, 440)
        Me.lblWLine1.Name = "lblWLine1"
        Me.lblWLine1.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine1.TabIndex = 111
        '
        'lblWLine2
        '
        Me.lblWLine2.BackColor = System.Drawing.Color.Black
        Me.lblWLine2.Location = New System.Drawing.Point(192, 440)
        Me.lblWLine2.Name = "lblWLine2"
        Me.lblWLine2.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine2.TabIndex = 112
        '
        'lblWLine3
        '
        Me.lblWLine3.BackColor = System.Drawing.Color.Black
        Me.lblWLine3.Location = New System.Drawing.Point(217, 440)
        Me.lblWLine3.Name = "lblWLine3"
        Me.lblWLine3.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine3.TabIndex = 113
        '
        'lblWLine4
        '
        Me.lblWLine4.BackColor = System.Drawing.Color.Black
        Me.lblWLine4.Location = New System.Drawing.Point(242, 440)
        Me.lblWLine4.Name = "lblWLine4"
        Me.lblWLine4.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine4.TabIndex = 114
        '
        'lblWLine5
        '
        Me.lblWLine5.BackColor = System.Drawing.Color.Black
        Me.lblWLine5.Location = New System.Drawing.Point(267, 440)
        Me.lblWLine5.Name = "lblWLine5"
        Me.lblWLine5.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine5.TabIndex = 115
        '
        'lblWLine6
        '
        Me.lblWLine6.BackColor = System.Drawing.Color.Black
        Me.lblWLine6.Location = New System.Drawing.Point(292, 440)
        Me.lblWLine6.Name = "lblWLine6"
        Me.lblWLine6.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine6.TabIndex = 116
        '
        'lblWLine7
        '
        Me.lblWLine7.BackColor = System.Drawing.Color.Black
        Me.lblWLine7.Location = New System.Drawing.Point(317, 440)
        Me.lblWLine7.Name = "lblWLine7"
        Me.lblWLine7.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine7.TabIndex = 117
        '
        'lblWLine8
        '
        Me.lblWLine8.BackColor = System.Drawing.Color.Black
        Me.lblWLine8.Location = New System.Drawing.Point(342, 440)
        Me.lblWLine8.Name = "lblWLine8"
        Me.lblWLine8.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine8.TabIndex = 118
        '
        'lblWLine9
        '
        Me.lblWLine9.BackColor = System.Drawing.Color.Black
        Me.lblWLine9.Location = New System.Drawing.Point(367, 440)
        Me.lblWLine9.Name = "lblWLine9"
        Me.lblWLine9.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine9.TabIndex = 119
        '
        'lblWLine10
        '
        Me.lblWLine10.BackColor = System.Drawing.Color.Black
        Me.lblWLine10.Location = New System.Drawing.Point(392, 440)
        Me.lblWLine10.Name = "lblWLine10"
        Me.lblWLine10.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine10.TabIndex = 120
        '
        'lblWLine11
        '
        Me.lblWLine11.BackColor = System.Drawing.Color.Black
        Me.lblWLine11.Location = New System.Drawing.Point(417, 440)
        Me.lblWLine11.Name = "lblWLine11"
        Me.lblWLine11.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine11.TabIndex = 121
        '
        'lblWLine12
        '
        Me.lblWLine12.BackColor = System.Drawing.Color.Black
        Me.lblWLine12.Location = New System.Drawing.Point(442, 440)
        Me.lblWLine12.Name = "lblWLine12"
        Me.lblWLine12.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine12.TabIndex = 122
        '
        'lblWLine13
        '
        Me.lblWLine13.BackColor = System.Drawing.Color.Black
        Me.lblWLine13.Location = New System.Drawing.Point(467, 440)
        Me.lblWLine13.Name = "lblWLine13"
        Me.lblWLine13.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine13.TabIndex = 123
        '
        'lblWLine14
        '
        Me.lblWLine14.BackColor = System.Drawing.Color.Black
        Me.lblWLine14.Location = New System.Drawing.Point(492, 440)
        Me.lblWLine14.Name = "lblWLine14"
        Me.lblWLine14.Size = New System.Drawing.Size(20, 1)
        Me.lblWLine14.TabIndex = 124
        '
        'lblAlpha0
        '
        Me.lblAlpha0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha0.Location = New System.Drawing.Point(277, 491)
        Me.lblAlpha0.Name = "lblAlpha0"
        Me.lblAlpha0.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha0.TabIndex = 125
        Me.lblAlpha0.Text = "x"
        Me.lblAlpha0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha1
        '
        Me.lblAlpha1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha1.Location = New System.Drawing.Point(293, 491)
        Me.lblAlpha1.Name = "lblAlpha1"
        Me.lblAlpha1.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha1.TabIndex = 126
        Me.lblAlpha1.Text = "x"
        Me.lblAlpha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha2
        '
        Me.lblAlpha2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha2.Location = New System.Drawing.Point(309, 491)
        Me.lblAlpha2.Name = "lblAlpha2"
        Me.lblAlpha2.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha2.TabIndex = 127
        Me.lblAlpha2.Text = "x"
        Me.lblAlpha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha3
        '
        Me.lblAlpha3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha3.Location = New System.Drawing.Point(325, 491)
        Me.lblAlpha3.Name = "lblAlpha3"
        Me.lblAlpha3.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha3.TabIndex = 128
        Me.lblAlpha3.Text = "x"
        Me.lblAlpha3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha4
        '
        Me.lblAlpha4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha4.Location = New System.Drawing.Point(341, 491)
        Me.lblAlpha4.Name = "lblAlpha4"
        Me.lblAlpha4.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha4.TabIndex = 129
        Me.lblAlpha4.Text = "x"
        Me.lblAlpha4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha5
        '
        Me.lblAlpha5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha5.Location = New System.Drawing.Point(357, 491)
        Me.lblAlpha5.Name = "lblAlpha5"
        Me.lblAlpha5.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha5.TabIndex = 130
        Me.lblAlpha5.Text = "x"
        Me.lblAlpha5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha6
        '
        Me.lblAlpha6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha6.Location = New System.Drawing.Point(373, 491)
        Me.lblAlpha6.Name = "lblAlpha6"
        Me.lblAlpha6.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha6.TabIndex = 131
        Me.lblAlpha6.Text = "x"
        Me.lblAlpha6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha7
        '
        Me.lblAlpha7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha7.Location = New System.Drawing.Point(389, 491)
        Me.lblAlpha7.Name = "lblAlpha7"
        Me.lblAlpha7.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha7.TabIndex = 132
        Me.lblAlpha7.Text = "x"
        Me.lblAlpha7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha8
        '
        Me.lblAlpha8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha8.Location = New System.Drawing.Point(405, 491)
        Me.lblAlpha8.Name = "lblAlpha8"
        Me.lblAlpha8.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha8.TabIndex = 133
        Me.lblAlpha8.Text = "x"
        Me.lblAlpha8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha9
        '
        Me.lblAlpha9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha9.Location = New System.Drawing.Point(421, 491)
        Me.lblAlpha9.Name = "lblAlpha9"
        Me.lblAlpha9.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha9.TabIndex = 134
        Me.lblAlpha9.Text = "x"
        Me.lblAlpha9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha10
        '
        Me.lblAlpha10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha10.Location = New System.Drawing.Point(437, 491)
        Me.lblAlpha10.Name = "lblAlpha10"
        Me.lblAlpha10.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha10.TabIndex = 135
        Me.lblAlpha10.Text = "x"
        Me.lblAlpha10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha11
        '
        Me.lblAlpha11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha11.Location = New System.Drawing.Point(453, 491)
        Me.lblAlpha11.Name = "lblAlpha11"
        Me.lblAlpha11.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha11.TabIndex = 136
        Me.lblAlpha11.Text = "x"
        Me.lblAlpha11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha12
        '
        Me.lblAlpha12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha12.Location = New System.Drawing.Point(469, 491)
        Me.lblAlpha12.Name = "lblAlpha12"
        Me.lblAlpha12.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha12.TabIndex = 137
        Me.lblAlpha12.Text = "x"
        Me.lblAlpha12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha13
        '
        Me.lblAlpha13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha13.Location = New System.Drawing.Point(485, 491)
        Me.lblAlpha13.Name = "lblAlpha13"
        Me.lblAlpha13.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha13.TabIndex = 138
        Me.lblAlpha13.Text = "x"
        Me.lblAlpha13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlpha14
        '
        Me.lblAlpha14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlpha14.Location = New System.Drawing.Point(501, 491)
        Me.lblAlpha14.Name = "lblAlpha14"
        Me.lblAlpha14.Size = New System.Drawing.Size(17, 17)
        Me.lblAlpha14.TabIndex = 139
        Me.lblAlpha14.Text = "x"
        Me.lblAlpha14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdLetter0
        '
        Me.cmdLetter0.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter0.Location = New System.Drawing.Point(329, 197)
        Me.cmdLetter0.Name = "cmdLetter0"
        Me.cmdLetter0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter0.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter0.TabIndex = 140
        Me.cmdLetter0.TabStop = False
        Me.cmdLetter0.Tag = "0"
        Me.cmdLetter0.Text = "A"
        Me.cmdLetter0.UseVisualStyleBackColor = False
        '
        'cmdLetter1
        '
        Me.cmdLetter1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter1.Location = New System.Drawing.Point(355, 197)
        Me.cmdLetter1.Name = "cmdLetter1"
        Me.cmdLetter1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter1.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter1.TabIndex = 141
        Me.cmdLetter1.TabStop = False
        Me.cmdLetter1.Tag = "1"
        Me.cmdLetter1.Text = "B"
        Me.cmdLetter1.UseVisualStyleBackColor = False
        '
        'cmdLetter2
        '
        Me.cmdLetter2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter2.Location = New System.Drawing.Point(382, 197)
        Me.cmdLetter2.Name = "cmdLetter2"
        Me.cmdLetter2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter2.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter2.TabIndex = 142
        Me.cmdLetter2.TabStop = False
        Me.cmdLetter2.Tag = "2"
        Me.cmdLetter2.Text = "C"
        Me.cmdLetter2.UseVisualStyleBackColor = False
        '
        'cmdLetter3
        '
        Me.cmdLetter3.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter3.Location = New System.Drawing.Point(409, 197)
        Me.cmdLetter3.Name = "cmdLetter3"
        Me.cmdLetter3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter3.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter3.TabIndex = 143
        Me.cmdLetter3.TabStop = False
        Me.cmdLetter3.Tag = "3"
        Me.cmdLetter3.Text = "D"
        Me.cmdLetter3.UseVisualStyleBackColor = False
        '
        'cmdLetter4
        '
        Me.cmdLetter4.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter4.Location = New System.Drawing.Point(436, 197)
        Me.cmdLetter4.Name = "cmdLetter4"
        Me.cmdLetter4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter4.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter4.TabIndex = 144
        Me.cmdLetter4.TabStop = False
        Me.cmdLetter4.Tag = "4"
        Me.cmdLetter4.Text = "E"
        Me.cmdLetter4.UseVisualStyleBackColor = False
        '
        'cmdLetter5
        '
        Me.cmdLetter5.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter5.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter5.Location = New System.Drawing.Point(463, 197)
        Me.cmdLetter5.Name = "cmdLetter5"
        Me.cmdLetter5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter5.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter5.TabIndex = 145
        Me.cmdLetter5.TabStop = False
        Me.cmdLetter5.Tag = "5"
        Me.cmdLetter5.Text = "F"
        Me.cmdLetter5.UseVisualStyleBackColor = False
        '
        'cmdLetter6
        '
        Me.cmdLetter6.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter6.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter6.Location = New System.Drawing.Point(490, 197)
        Me.cmdLetter6.Name = "cmdLetter6"
        Me.cmdLetter6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter6.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter6.TabIndex = 146
        Me.cmdLetter6.TabStop = False
        Me.cmdLetter6.Tag = "6"
        Me.cmdLetter6.Text = "G"
        Me.cmdLetter6.UseVisualStyleBackColor = False
        '
        'cmdLetter12
        '
        Me.cmdLetter12.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter12.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter12.Location = New System.Drawing.Point(652, 197)
        Me.cmdLetter12.Name = "cmdLetter12"
        Me.cmdLetter12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter12.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter12.TabIndex = 152
        Me.cmdLetter12.TabStop = False
        Me.cmdLetter12.Tag = "12"
        Me.cmdLetter12.Text = "M"
        Me.cmdLetter12.UseVisualStyleBackColor = False
        '
        'cmdLetter11
        '
        Me.cmdLetter11.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter11.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter11.Location = New System.Drawing.Point(625, 197)
        Me.cmdLetter11.Name = "cmdLetter11"
        Me.cmdLetter11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter11.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter11.TabIndex = 151
        Me.cmdLetter11.TabStop = False
        Me.cmdLetter11.Tag = "11"
        Me.cmdLetter11.Text = "L"
        Me.cmdLetter11.UseVisualStyleBackColor = False
        '
        'cmdLetter10
        '
        Me.cmdLetter10.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter10.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter10.Location = New System.Drawing.Point(598, 197)
        Me.cmdLetter10.Name = "cmdLetter10"
        Me.cmdLetter10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter10.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter10.TabIndex = 150
        Me.cmdLetter10.TabStop = False
        Me.cmdLetter10.Tag = "10"
        Me.cmdLetter10.Text = "K"
        Me.cmdLetter10.UseVisualStyleBackColor = False
        '
        'cmdLetter9
        '
        Me.cmdLetter9.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter9.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter9.Location = New System.Drawing.Point(571, 197)
        Me.cmdLetter9.Name = "cmdLetter9"
        Me.cmdLetter9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter9.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter9.TabIndex = 149
        Me.cmdLetter9.TabStop = False
        Me.cmdLetter9.Tag = "9"
        Me.cmdLetter9.Text = "J"
        Me.cmdLetter9.UseVisualStyleBackColor = False
        '
        'cmdLetter8
        '
        Me.cmdLetter8.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter8.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter8.Location = New System.Drawing.Point(544, 197)
        Me.cmdLetter8.Name = "cmdLetter8"
        Me.cmdLetter8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter8.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter8.TabIndex = 148
        Me.cmdLetter8.TabStop = False
        Me.cmdLetter8.Tag = "8"
        Me.cmdLetter8.Text = "I"
        Me.cmdLetter8.UseVisualStyleBackColor = False
        '
        'cmdLetter7
        '
        Me.cmdLetter7.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter7.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter7.Location = New System.Drawing.Point(517, 197)
        Me.cmdLetter7.Name = "cmdLetter7"
        Me.cmdLetter7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter7.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter7.TabIndex = 147
        Me.cmdLetter7.TabStop = False
        Me.cmdLetter7.Tag = "7"
        Me.cmdLetter7.Text = "H"
        Me.cmdLetter7.UseVisualStyleBackColor = False
        '
        'cmdLetter25
        '
        Me.cmdLetter25.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter25.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter25.Location = New System.Drawing.Point(651, 227)
        Me.cmdLetter25.Name = "cmdLetter25"
        Me.cmdLetter25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter25.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter25.TabIndex = 165
        Me.cmdLetter25.TabStop = False
        Me.cmdLetter25.Tag = "25"
        Me.cmdLetter25.Text = "Z"
        Me.cmdLetter25.UseVisualStyleBackColor = False
        '
        'cmdLetter24
        '
        Me.cmdLetter24.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter24.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter24.Location = New System.Drawing.Point(624, 227)
        Me.cmdLetter24.Name = "cmdLetter24"
        Me.cmdLetter24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter24.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter24.TabIndex = 164
        Me.cmdLetter24.TabStop = False
        Me.cmdLetter24.Tag = "24"
        Me.cmdLetter24.Text = "Y"
        Me.cmdLetter24.UseVisualStyleBackColor = False
        '
        'cmdLetter23
        '
        Me.cmdLetter23.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter23.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter23.Location = New System.Drawing.Point(597, 227)
        Me.cmdLetter23.Name = "cmdLetter23"
        Me.cmdLetter23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter23.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter23.TabIndex = 163
        Me.cmdLetter23.TabStop = False
        Me.cmdLetter23.Tag = "23"
        Me.cmdLetter23.Text = "X"
        Me.cmdLetter23.UseVisualStyleBackColor = False
        '
        'cmdLetter22
        '
        Me.cmdLetter22.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter22.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter22.Location = New System.Drawing.Point(570, 227)
        Me.cmdLetter22.Name = "cmdLetter22"
        Me.cmdLetter22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter22.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter22.TabIndex = 162
        Me.cmdLetter22.TabStop = False
        Me.cmdLetter22.Tag = "22"
        Me.cmdLetter22.Text = "W"
        Me.cmdLetter22.UseVisualStyleBackColor = False
        '
        'cmdLetter21
        '
        Me.cmdLetter21.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter21.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter21.Location = New System.Drawing.Point(544, 227)
        Me.cmdLetter21.Name = "cmdLetter21"
        Me.cmdLetter21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter21.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter21.TabIndex = 161
        Me.cmdLetter21.TabStop = False
        Me.cmdLetter21.Tag = "21"
        Me.cmdLetter21.Text = "V"
        Me.cmdLetter21.UseVisualStyleBackColor = False
        '
        'cmdLetter20
        '
        Me.cmdLetter20.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter20.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter20.Location = New System.Drawing.Point(517, 227)
        Me.cmdLetter20.Name = "cmdLetter20"
        Me.cmdLetter20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter20.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter20.TabIndex = 160
        Me.cmdLetter20.TabStop = False
        Me.cmdLetter20.Tag = "20"
        Me.cmdLetter20.Text = "U"
        Me.cmdLetter20.UseVisualStyleBackColor = False
        '
        'cmdLetter19
        '
        Me.cmdLetter19.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter19.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter19.Location = New System.Drawing.Point(490, 227)
        Me.cmdLetter19.Name = "cmdLetter19"
        Me.cmdLetter19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter19.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter19.TabIndex = 159
        Me.cmdLetter19.TabStop = False
        Me.cmdLetter19.Tag = "19"
        Me.cmdLetter19.Text = "T"
        Me.cmdLetter19.UseVisualStyleBackColor = False
        '
        'cmdLetter18
        '
        Me.cmdLetter18.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter18.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter18.Location = New System.Drawing.Point(463, 227)
        Me.cmdLetter18.Name = "cmdLetter18"
        Me.cmdLetter18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter18.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter18.TabIndex = 158
        Me.cmdLetter18.TabStop = False
        Me.cmdLetter18.Tag = "18"
        Me.cmdLetter18.Text = "S"
        Me.cmdLetter18.UseVisualStyleBackColor = False
        '
        'cmdLetter17
        '
        Me.cmdLetter17.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter17.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter17.Location = New System.Drawing.Point(436, 227)
        Me.cmdLetter17.Name = "cmdLetter17"
        Me.cmdLetter17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter17.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter17.TabIndex = 157
        Me.cmdLetter17.TabStop = False
        Me.cmdLetter17.Tag = "17"
        Me.cmdLetter17.Text = "R"
        Me.cmdLetter17.UseVisualStyleBackColor = False
        '
        'cmdLetter16
        '
        Me.cmdLetter16.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter16.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter16.Location = New System.Drawing.Point(409, 227)
        Me.cmdLetter16.Name = "cmdLetter16"
        Me.cmdLetter16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter16.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter16.TabIndex = 156
        Me.cmdLetter16.TabStop = False
        Me.cmdLetter16.Tag = "16"
        Me.cmdLetter16.Text = "Q"
        Me.cmdLetter16.UseVisualStyleBackColor = False
        '
        'cmdLetter15
        '
        Me.cmdLetter15.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter15.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter15.Location = New System.Drawing.Point(382, 227)
        Me.cmdLetter15.Name = "cmdLetter15"
        Me.cmdLetter15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter15.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter15.TabIndex = 155
        Me.cmdLetter15.TabStop = False
        Me.cmdLetter15.Tag = "15"
        Me.cmdLetter15.Text = "P"
        Me.cmdLetter15.UseVisualStyleBackColor = False
        '
        'cmdLetter14
        '
        Me.cmdLetter14.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter14.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter14.Location = New System.Drawing.Point(355, 227)
        Me.cmdLetter14.Name = "cmdLetter14"
        Me.cmdLetter14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter14.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter14.TabIndex = 154
        Me.cmdLetter14.TabStop = False
        Me.cmdLetter14.Tag = "14"
        Me.cmdLetter14.Text = "O"
        Me.cmdLetter14.UseVisualStyleBackColor = False
        '
        'cmdLetter13
        '
        Me.cmdLetter13.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLetter13.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLetter13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLetter13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLetter13.Location = New System.Drawing.Point(329, 227)
        Me.cmdLetter13.Name = "cmdLetter13"
        Me.cmdLetter13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLetter13.Size = New System.Drawing.Size(25, 25)
        Me.cmdLetter13.TabIndex = 153
        Me.cmdLetter13.TabStop = False
        Me.cmdLetter13.Tag = "13"
        Me.cmdLetter13.Text = "N"
        Me.cmdLetter13.UseVisualStyleBackColor = False
        '
        'lblShowWord
        '
        Me.lblShowWord.BackColor = System.Drawing.Color.Transparent
        Me.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowWord.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblShowWord.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowWord.ForeColor = System.Drawing.Color.Yellow
        Me.lblShowWord.Location = New System.Drawing.Point(570, 418)
        Me.lblShowWord.Name = "lblShowWord"
        Me.lblShowWord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShowWord.Size = New System.Drawing.Size(108, 17)
        Me.lblShowWord.TabIndex = 166
        Me.lblShowWord.Visible = False
        '
        'lblMaxChars
        '
        Me.lblMaxChars.AutoSize = True
        Me.lblMaxChars.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxChars.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMaxChars.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxChars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMaxChars.Location = New System.Drawing.Point(139, 455)
        Me.lblMaxChars.Name = "lblMaxChars"
        Me.lblMaxChars.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaxChars.Size = New System.Drawing.Size(67, 16)
        Me.lblMaxChars.TabIndex = 168
        Me.lblMaxChars.Text = "MaxChars"
        Me.lblMaxChars.Visible = False
        '
        'sbStatusStrip
        '
        Me.sbStatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sbStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9})
        Me.sbStatusStrip.Location = New System.Drawing.Point(0, 549)
        Me.sbStatusStrip.Name = "sbStatusStrip"
        Me.sbStatusStrip.Size = New System.Drawing.Size(925, 22)
        Me.sbStatusStrip.TabIndex = 169
        Me.sbStatusStrip.Text = "sbStatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "Label0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(175, 17)
        Me.ToolStripStatusLabel2.Text = "Label1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel3.Text = "Label2"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel4.Text = "Label3"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.AutoSize = False
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel5.Text = "Label4"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.AutoSize = False
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel6.Text = "Label5"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.AutoSize = False
        Me.ToolStripStatusLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel7.Text = "Label6"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.AutoSize = False
        Me.ToolStripStatusLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(135, 17)
        Me.ToolStripStatusLabel8.Text = "Label7"
        Me.ToolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.AutoSize = False
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel9.Text = "Label8"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(925, 45)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 170
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.HangMan.My.Resources.Resources.ANIMALS
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton1.Text = "Animals"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.HangMan.My.Resources.Resources.FOOD
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton2.Text = "Food"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.HangMan.My.Resources.Resources.HOLIDAYS
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton3.Text = "Holidays"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.HangMan.My.Resources.Resources.HOME
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton4.Text = "Home"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.HangMan.My.Resources.Resources.LEISURE
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton5.Text = "Leisure"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.HangMan.My.Resources.Resources.SEASONS
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton6.Text = "Seasons"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.HangMan.My.Resources.Resources.SPORTS
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton7.Text = "Sports"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.HangMan.My.Resources.Resources.WEATHER
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton8.Text = "Weather"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = Global.HangMan.My.Resources.Resources.MISC
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(59, 42)
        Me.ToolStripButton9.Text = "Misc"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(925, 571)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.sbStatusStrip)
        Me.Controls.Add(Me.lblMaxChars)
        Me.Controls.Add(Me.lblShowWord)
        Me.Controls.Add(Me.cmdLetter25)
        Me.Controls.Add(Me.cmdLetter24)
        Me.Controls.Add(Me.cmdLetter23)
        Me.Controls.Add(Me.cmdLetter22)
        Me.Controls.Add(Me.cmdLetter21)
        Me.Controls.Add(Me.cmdLetter20)
        Me.Controls.Add(Me.cmdLetter19)
        Me.Controls.Add(Me.cmdLetter18)
        Me.Controls.Add(Me.cmdLetter17)
        Me.Controls.Add(Me.cmdLetter16)
        Me.Controls.Add(Me.cmdLetter15)
        Me.Controls.Add(Me.cmdLetter14)
        Me.Controls.Add(Me.cmdLetter13)
        Me.Controls.Add(Me.cmdLetter12)
        Me.Controls.Add(Me.cmdLetter11)
        Me.Controls.Add(Me.cmdLetter10)
        Me.Controls.Add(Me.cmdLetter9)
        Me.Controls.Add(Me.cmdLetter8)
        Me.Controls.Add(Me.cmdLetter7)
        Me.Controls.Add(Me.cmdLetter6)
        Me.Controls.Add(Me.cmdLetter5)
        Me.Controls.Add(Me.cmdLetter4)
        Me.Controls.Add(Me.cmdLetter3)
        Me.Controls.Add(Me.cmdLetter2)
        Me.Controls.Add(Me.cmdLetter1)
        Me.Controls.Add(Me.cmdLetter0)
        Me.Controls.Add(Me.lblAlpha14)
        Me.Controls.Add(Me.lblAlpha13)
        Me.Controls.Add(Me.lblAlpha12)
        Me.Controls.Add(Me.lblAlpha11)
        Me.Controls.Add(Me.lblAlpha10)
        Me.Controls.Add(Me.lblAlpha9)
        Me.Controls.Add(Me.lblAlpha8)
        Me.Controls.Add(Me.lblAlpha7)
        Me.Controls.Add(Me.lblAlpha6)
        Me.Controls.Add(Me.lblAlpha5)
        Me.Controls.Add(Me.lblAlpha4)
        Me.Controls.Add(Me.lblAlpha3)
        Me.Controls.Add(Me.lblAlpha2)
        Me.Controls.Add(Me.lblAlpha1)
        Me.Controls.Add(Me.lblAlpha0)
        Me.Controls.Add(Me.lblWLine14)
        Me.Controls.Add(Me.lblWLine13)
        Me.Controls.Add(Me.lblWLine12)
        Me.Controls.Add(Me.lblWLine11)
        Me.Controls.Add(Me.lblWLine10)
        Me.Controls.Add(Me.lblWLine9)
        Me.Controls.Add(Me.lblWLine8)
        Me.Controls.Add(Me.lblWLine7)
        Me.Controls.Add(Me.lblWLine6)
        Me.Controls.Add(Me.lblWLine5)
        Me.Controls.Add(Me.lblWLine4)
        Me.Controls.Add(Me.lblWLine3)
        Me.Controls.Add(Me.lblWLine2)
        Me.Controls.Add(Me.lblWLine1)
        Me.Controls.Add(Me.lblWLine0)
        Me.Controls.Add(Me.lblLetter14)
        Me.Controls.Add(Me.lblLetter13)
        Me.Controls.Add(Me.lblLetter12)
        Me.Controls.Add(Me.lblLetter11)
        Me.Controls.Add(Me.lblLetter10)
        Me.Controls.Add(Me.lblLetter9)
        Me.Controls.Add(Me.lblLetter8)
        Me.Controls.Add(Me.lblLetter7)
        Me.Controls.Add(Me.lblLetter6)
        Me.Controls.Add(Me.lblLetter5)
        Me.Controls.Add(Me.lblLetter4)
        Me.Controls.Add(Me.lblLetter3)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.lblLetter1)
        Me.Controls.Add(Me.lblLetter0)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdNewGame)
        Me.Controls.Add(Me.Rfoot)
        Me.Controls.Add(Me.Lfoot)
        Me.Controls.Add(Me.Rhand)
        Me.Controls.Add(Me.Lhand)
        Me.Controls.Add(Me.lblmaxwords)
        Me.Controls.Add(Me.lblfilename)
        Me.Controls.Add(Me.lblWordIs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.lblStatus)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(169, 105)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hangman"
        Me.sbStatusStrip.ResumeLayout(False)
        Me.sbStatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    'Visual Studio 2013
    Dim mflag As Short
    Dim tfile As String
    Dim maxflag As Short 'max word is 15 chars
    Dim MaxNum As Short
    Dim mtmp As Short 'hold file number to reset NFile if user does not play new game
    Dim moldtmp As Short 'hold old category
    Dim CatFlag2, CatFlag1, CatFlag3, CatFlag4 As Boolean
    Dim CatFlag7, CatFlag5, CatFlag6, CatFlag8, CatFlag9 As Boolean
    Dim gameover As Boolean

    Dim gfxobj As System.Drawing.Graphics
    Dim x1 As Integer
    Dim y1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Dim w1 As Integer       'width
    Dim h1 As Integer       'height
    Dim pen As Pen

    Private Sub cmdletter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLetter0.Click, cmdLetter1.Click, cmdLetter2.Click, cmdLetter3.Click, cmdLetter4.Click, cmdLetter5.Click, cmdLetter6.Click, cmdLetter7.Click, cmdLetter8.Click, cmdLetter9.Click, cmdLetter10.Click, cmdLetter11.Click, cmdLetter12.Click, cmdLetter13.Click, cmdLetter14.Click, cmdLetter15.Click, cmdLetter16.Click, cmdLetter17.Click, cmdLetter18.Click, cmdLetter19.Click, cmdLetter20.Click, cmdLetter21.Click, cmdLetter22.Click, cmdLetter23.Click, cmdLetter24.Click, cmdLetter25.Click

        Dim NewButton As Button = CType(eventSender, Button)

        Dim Index As Short = NewButton.Tag
        'index will start at zero for letter "A" to 25 for letter "Z"
        'MsgBox(Index)

        Dim AlphaLetter As String
        Dim flag As Short
        Dim done As Short
        Dim tmpflag As Short

        If Not gameover Then
            mflag = False
            AlphaLetter = ""
            GetAlphaLetter(Index, AlphaLetter)
            'MsgBox(Index & " " & AlphaLetter)

            CheckWordForValidLetter(AlphaLetter, flag)
            DisableCmdLetter(Index)

            'check if word is guessed
            tmpflag = True
            WasWordGuessed(tmpflag)
            'tmpflag is true if word was guessed
            If tmpflag Then
                lblStatus.Text = "You Win!"
                gameover = True
                'start new game
                mflag = True
                MaxGames = MaxGames + 1
                MaxWins = MaxWins + 1
                UpDateStatusBar(MaxGames, MaxWins)
                'play sound if gSound equals 1
                If gSound = 1 Then
                    PlayWinSound()
                    SetSoundMenuItems(gSound)
                End If
            Else
                If Not flag Then
                    'start to hang the man
                    done = False
                    HangMan(done)
                    If done Then
                        lblWordIs.Visible = True
                        lblStatus.Text = "You Lost!"
                        gameover = True
                        ShowWord()
                        'start new game
                        mflag = True
                        MaxGames = MaxGames + 1
                        UpDateStatusBar(MaxGames, MaxWins)
                        If gSound = 1 Then
                            PlayEndSound()
                            SetSoundMenuItems(gSound)
                        End If
                    Else
                        If gSound = 1 Then
                            'play sound
                            PlayLostSound()
                            SetSoundMenuItems(gSound)
                        End If
                    End If
                End If
            End If

        Else
            cmdNewGame.Focus()
        End If

    End Sub

    Private Sub Form_Initialize_Game()
        'get ini file name
        GetIntPathSettings()
        GetIniExpired(gExpired)

        gExpireFlag = False
        If gExpireFlag Then
            gExpired = 0
        Else
            'gExpired = 1
        End If
        gDaysLeft = 0
        'if program was used over 30 days then gExpired will be 1
        'and must quit game otherwise gExpired will be 0 and play game
        If (gExpired = 0) Then
            'check for new install, if so then output
            'system date of today and add value.dat to directory
            CheckForNewInstall()
            'get initial settings for the file to use
            'NFile is the category
            GetIniFileSettings(NFile, gSound)
            mtmp = NFile
            gDaysLeft = 30 - gDaysUsed
            'MsgBox("Expires in " & gDaysLeft & " days.")
        Else
            'show expired screen and exit program
            frmExpired.ShowDialog()
            End
        End If

    End Sub

    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.Width = 900
        Me.Height = 700

        ' Center the Form on the screen
        Me.SetBounds((System.Windows.Forms.Screen.GetBounds(Me).Width / 2) - (Me.Width / 2), _
            (System.Windows.Forms.Screen.GetBounds(Me).Height / 2) - (Me.Height / 2), _
            Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)

        'create the graphics object
        gfxobj = CreateGraphics()

        'variables used to update status bar
        MaxGames = 0
        MaxWins = 0
        mflag = True
        'set mode of play, true for advanced level
        gLevel = True
        'update status bar text for level
        'sbStatusBar.Panels.Item(1).Text = "Advanced"
        'sbStatusStrip.Panels.Item(1).Text = "Advanced"
        sbStatusStrip.Items(0).Text = "Advanced"
        sbStatusStrip.Items(2).Text = "Games"
        sbStatusStrip.Items(3).Text = " "
        sbStatusStrip.Items(4).Text = "Wins"
        sbStatusStrip.Items(5).Text = " "
        sbStatusStrip.Items(6).Text = " "
        sbStatusStrip.Items(7).Text = FormatDateTime(Now(), DateFormat.ShortDate)
        sbStatusStrip.Items(8).Text = " "

        SetCategoryMenuItems(NFile)
        SetSoundMenuItems(gSound)
        SetCategoryFlagsFalse()
        lblStatus.BorderStyle = BorderStyle.None

        'assume all files are in directory
        FindCategoryFile(NFile, tfile)
        gFileok = True
        DataFileExist(tfile, gFileok)
        If gFileok Then
            cmdNewGame_Click(cmdNewGame, New System.EventArgs())
        Else
            SetCategoryFlagTrue(NFile)
            ClearAllItems()
        End If

    End Sub

    Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        'close all sub forms
    End Sub

    Private Sub cmdNewGame_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNewGame.Click
        'start new game
        If gFileok Then
            If mflag Then
                NFile = mtmp
                InitNewGame()
            Else
                Msg = "Start New Game?"
                Style = CStr(MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
                Ans = CStr(MsgBox(Msg, CDbl(Style), HM_MSG))
                'ans will return as IDYES = 6 or IDNO = 7
                If CDbl(Ans) = IDYES Then
                    NFile = mtmp
                    SetCategoryMenuItems(mtmp)
                    InitNewGame()
                Else
                    mtmp = NFile
                    SetCategoryMenuItems(mtmp)
                End If
            End If
        Else
            MsgBox("Please select new category!")
        End If

    End Sub

    Private Sub DrawShape(ByVal xShape As Integer, ByVal flag As Boolean)
        'draw the line
        'start at location (x,y) as (162,134)
        Dim NumX1, NumY1 As Integer
        NumX1 = 162
        NumY1 = 134

        Select Case xShape
            Case 0
                'head
                'draws an ellipse located at (x,y) for the width and height
                x1 = 137    '162-25=137         '110
                y1 = 149    '134+12=146         '120
                w1 = 50
                h1 = 50
                If flag Then
                    gfxobj.DrawEllipse(Pens.Black, x1, y1, w1, h1)
                Else
                    gfxobj.DrawEllipse(Pens.OliveDrab, x1, y1, w1, h1)
                End If
            Case 1
                'body
                'draws a line form (x1,y1) to (x2,y2)
                x1 = 162    '137+25=162     '135
                y1 = 199    '149+50=199     '170
                x2 = 162    '137+25=162    '135
                y2 = 240       '240+50=290    '240
                If flag Then
                    gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2)
                Else
                    gfxobj.DrawLine(Pens.OliveDrab, x1, y1, x2, y2)
                End If
            Case 2
                'left arm
                'draws a line form (x1,y1) to (x2,y2)
                x1 = 125    '100
                y1 = 185
                x2 = 162    '135
                y2 = 220
                If flag Then
                    gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2)
                Else
                    gfxobj.DrawLine(Pens.OliveDrab, x1, y1, x2, y2)
                End If
            Case 3
                'right arm
                'draws a line form (x1,y1) to (x2,y2)
                x1 = 195    '170
                y1 = 185
                x2 = 162    '135
                y2 = 220
                If flag Then
                    gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2)
                Else
                    gfxobj.DrawLine(Pens.OliveDrab, x1, y1, x2, y2)
                End If
            Case 4
                'left leg
                'draws a line form (x1,y1) to (x2,y2)
                x1 = 160    '135
                y1 = 240
                x2 = 125    '100
                y2 = 280
                If flag Then
                    gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2)
                Else
                    gfxobj.DrawLine(Pens.OliveDrab, x1, y1, x2, y2)
                End If
            Case 5
                'right leg
                'draws a line form (x1,y1) to (x2,y2)
                x1 = 160    '135
                y1 = 240
                x2 = 195    '170
                y2 = 280
                If flag Then
                    gfxobj.DrawLine(Pens.Black, x1, y1, x2, y2)
                Else
                    gfxobj.DrawLine(Pens.OliveDrab, x1, y1, x2, y2)
                End If
        End Select

    End Sub

    Public Sub InitNewGame()
        'initialize new game, get new word from data file

        gameover = False
        ClearlblArray()
        ClearHangMan()

        FindCategoryFile(NFile, tfile)
        DisplayCategoryFile()
        'MsgBox "File= " & tfile & " Category= " & NFile
        mflag = False
        EnableCmdLetters()
        lblStatus.Text = ""
        lblWordIs.Visible = False
        'find maximum words in file
        FindMaxWords(MAXWORDS, tfile)
        'MsgBox("MaxWords= " & MAXWORDS & " File=" & tfile)
        Randomize() 'initialize random-number generator
        gNum = Int((MAXWORDS * Rnd()) + 1)
        'gNum = 112
        GetWordsFromFile(gNum, gWord, tfile)
        lblShowWord.Text = gWord

        'used for testing
        'uncomment the line to display word for testing
        'lblShowWord.Visible = True

        LoadWord(gWord)
        'load array of used letters
        LoadlblLetter()
        lblMaxChars.Visible = True
        lblMaxChars.Text = "Guess the " & Len(gWord) & " letter word."

        'used for testing, to display the filename
        'lblfilename.Visible = True
        'lblfilename.Text = tfile
        'lblmaxwords.Visible = True
        'lblmaxwords.Text = CStr(MAXWORDS)

    End Sub

    Public Sub LoadlblLetter()
        Dim I As Short
        Dim NewChar As String

        For I = 0 To MAXARRAY
            NewChar = WInfo(I).Letter
            LoadlblLetter(I, NewChar)
            LoadlblAlpha(I, NewChar)
            Call HidelblAlpha()
        Next I

    End Sub

    Public Sub LoadlblLetter(ByRef Index As Short, ByRef AlphaLetter As String)
        'load lblletter labels with letter
        Select Case Index
            Case 0
                lblLetter0.Text = AlphaLetter

                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter0.Visible = True
                    lblWLine0.Visible = False
                Else
                    lblLetter0.Visible = False
                    lblWLine0.Visible = True
                End If
            Case 1
                lblLetter1.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter1.Visible = True
                    lblWLine1.Visible = False
                Else
                    lblLetter1.Visible = False
                    lblWLine1.Visible = True
                End If
            Case 2
                lblLetter2.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter2.Visible = True
                    lblWLine2.Visible = False
                Else
                    lblLetter2.Visible = False
                    lblWLine2.Visible = True
                End If
            Case 3
                lblLetter3.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter3.Visible = True
                    lblWLine3.Visible = False
                Else
                    lblLetter3.Visible = False
                    lblWLine3.Visible = True
                End If
            Case 4
                lblLetter4.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter4.Visible = True
                    lblWLine4.Visible = False
                Else
                    lblLetter4.Visible = False
                    lblWLine4.Visible = True
                End If
            Case 5
                lblLetter5.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter5.Visible = True
                    lblWLine5.Visible = False
                Else
                    lblLetter5.Visible = False
                    lblWLine5.Visible = True
                End If
            Case 6
                lblLetter6.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter6.Visible = True
                    lblWLine6.Visible = False
                Else
                    lblLetter6.Visible = False
                    lblWLine6.Visible = True
                End If
            Case 7
                lblLetter7.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter7.Visible = True
                    lblWLine7.Visible = False
                Else
                    lblLetter7.Visible = False
                    lblWLine7.Visible = True
                End If
            Case 8
                lblLetter8.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter8.Visible = True
                    lblWLine8.Visible = False
                Else
                    lblLetter8.Visible = False
                    lblWLine8.Visible = True
                End If
            Case 9
                lblLetter9.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter9.Visible = True
                    lblWLine9.Visible = False
                Else
                    lblLetter9.Visible = False
                    lblWLine9.Visible = True
                End If
            Case 10
                lblLetter10.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter10.Visible = True
                    lblWLine10.Visible = False
                Else
                    lblLetter10.Visible = False
                    lblWLine10.Visible = True
                End If
            Case 11
                lblLetter11.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter11.Visible = True
                    lblWLine11.Visible = False
                Else
                    lblLetter11.Visible = False
                    lblWLine11.Visible = True
                End If
            Case 12
                lblLetter12.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter12.Visible = True
                    lblWLine12.Visible = False
                Else
                    lblLetter12.Visible = False
                    lblWLine12.Visible = True
                End If
            Case 13
                lblLetter13.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter13.Visible = True
                    lblWLine13.Visible = False
                Else
                    lblLetter13.Visible = False
                    lblWLine13.Visible = True
                End If
            Case 14
                lblLetter14.Text = AlphaLetter
                If AlphaLetter < "A" Or AlphaLetter > "Z" Then
                    lblLetter14.Visible = True
                    lblWLine14.Visible = False
                Else
                    lblLetter14.Visible = False
                    lblWLine14.Visible = True
                End If
        End Select
    End Sub


    Public Sub LoadlblAlpha(ByRef Index As Short, ByRef AlphaLetter As String)
        'load lblAlpha labels with letter
        Select Case Index
            Case 0
                lblAlpha0.Text = AlphaLetter
            Case 1
                lblAlpha1.Text = AlphaLetter
            Case 2
                lblAlpha2.Text = AlphaLetter
            Case 3
                lblAlpha3.Text = AlphaLetter
            Case 4
                lblAlpha4.Text = AlphaLetter
            Case 5
                lblAlpha5.Text = AlphaLetter
            Case 6
                lblAlpha6.Text = AlphaLetter
            Case 7
                lblAlpha7.Text = AlphaLetter
            Case 8
                lblAlpha8.Text = AlphaLetter
            Case 9
                lblAlpha9.Text = AlphaLetter
            Case 10
                lblAlpha10.Text = AlphaLetter
            Case 11
                lblAlpha11.Text = AlphaLetter
            Case 12
                lblAlpha12.Text = AlphaLetter
            Case 13
                lblAlpha13.Text = AlphaLetter
            Case 14
                lblAlpha14.Text = AlphaLetter
        End Select
    End Sub

    Public Sub LoadWord(ByRef gWord As String)

        Dim I As Short
        Dim chr_X As String
        Dim TmpNum As Short

        'need to clear array
        For I = 1 To MAXHOLD
            WInfo(I).Letter = ""
            WInfo(I).Used = False
            LInfo(I).Letter = ""
            LInfo(I).Used = False
        Next I
        TmpNum = Len(gWord)
        'MsgBox TmpNum & " " & gWord
        For I = 1 To Len(gWord)
            chr_X = Mid(gWord, I, 1)
            WInfo(I - 1).Letter = UCase(chr_X)
            WInfo(I - 1).Used = False
            LInfo(I - 1).Letter = UCase(chr_X)
            LInfo(I - 1).Used = False
        Next I

        'used for testing
        MaxNum = 0
        'clear hangman array
        For I = 0 To 9
            MInfo(I).flag = False
        Next I

        Wnum = TmpNum - 1
        ClearHangMan()
    End Sub

    Public Sub CheckWordForValidLetter(ByRef AlphaLetter As String, ByRef flag As Short)
        'check new word to see if AlphaLetter exists
        Dim I As Short

        flag = False
        For I = 0 To Wnum

            Select Case I
                Case 0
                    If lblLetter0.Text = AlphaLetter Then
                        lblLetter0.Visible = True
                        flag = True
                    End If
                Case 1
                    If lblLetter1.Text = AlphaLetter Then
                        lblLetter1.Visible = True
                        flag = True
                    End If
                Case 2
                    If lblLetter2.Text = AlphaLetter Then
                        lblLetter2.Visible = True
                        flag = True
                    End If
                Case 3
                    If lblLetter3.Text = AlphaLetter Then
                        lblLetter3.Visible = True
                        flag = True
                    End If
                Case 4
                    If lblLetter4.Text = AlphaLetter Then
                        lblLetter4.Visible = True
                        flag = True
                    End If
                Case 5
                    If lblLetter5.Text = AlphaLetter Then
                        lblLetter5.Visible = True
                        flag = True
                    End If
                Case 6
                    If lblLetter6.Text = AlphaLetter Then
                        lblLetter6.Visible = True
                        flag = True
                    End If
                Case 7
                    If lblLetter7.Text = AlphaLetter Then
                        lblLetter7.Visible = True
                        flag = True
                    End If
                Case 8
                    If lblLetter8.Text = AlphaLetter Then
                        lblLetter8.Visible = True
                        flag = True
                    End If
                Case 9
                    If lblLetter9.Text = AlphaLetter Then
                        lblLetter9.Visible = True
                        flag = True
                    End If
                Case 10
                    If lblLetter10.Text = AlphaLetter Then
                        lblLetter10.Visible = True
                        flag = True
                    End If
                Case 11
                    If lblLetter11.Text = AlphaLetter Then
                        lblLetter11.Visible = True
                        flag = True
                    End If
                Case 12
                    If lblLetter12.Text = AlphaLetter Then
                        lblLetter12.Visible = True
                        flag = True
                    End If
                Case 13
                    If lblLetter13.Text = AlphaLetter Then
                        lblLetter13.Visible = True
                        flag = True
                    End If
                Case 14
                    If lblLetter14.Text = AlphaLetter Then
                        lblLetter14.Visible = True
                        flag = True
                    End If
            End Select

        Next I

    End Sub

    Public Sub HangMan(ByRef done As Short)
        'check to see what part of man to show
        'man structure - which part to show in list
        'MInfo of MANINFO.flag
        '1=Head 2=Body 3=Larm 4=Rarm 5=Lleg 6=Rleg
        'following items added for beginner level
        '7=Lhand 8=Rhand 9=Lfoot 10=Rfoot
        Dim I As Short
        Dim found As Short

        found = False
        I = 0
        Do While (I <= 9) And Not found
            If MInfo(I).flag = False Then
                'show this part of man and set to true
                MInfo(I).flag = True
                found = True
                done = False
                MaxNum = MaxNum + 1
                Select Case I
                    Case 0
                        DrawShape(0, True)
                    Case 1
                        DrawShape(1, True)
                    Case 2
                        DrawShape(2, True)
                    Case 3
                        DrawShape(3, True)
                    Case 4
                        DrawShape(4, True)
                    Case 5
                        DrawShape(5, True)
                    Case 6
                        Me.Lhand.Visible = True
                    Case 7
                        Me.Rhand.Visible = True
                    Case 8
                        Me.Lfoot.Visible = True
                    Case 9
                        Me.Rfoot.Visible = True
                End Select
                Exit Do
            End If
            I = I + 1
        Loop
        If gLevel = False Then
            'beginner mode, 0 thru 9, array of 10
            If MaxNum >= 10 Then
                done = True
            End If
        Else
            'advanced mode, 0 thru 5, array of 6
            If MaxNum >= 6 Then
                done = True
            End If
        End If

    End Sub

    Public Sub WasWordGuessed(ByRef tmpflag As Short)
        'search word array to see if word was guessed
        Dim I As Short

        I = 0
        Do While I <= Wnum

            Select Case I
                Case 0
                    If lblLetter0.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 1
                    If lblLetter1.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 2
                    If lblLetter2.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 3
                    If lblLetter3.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 4
                    If lblLetter4.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 5
                    If lblLetter5.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 6
                    If lblLetter6.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 7
                    If lblLetter7.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 8
                    If lblLetter8.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 9
                    If lblLetter9.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 10
                    If lblLetter10.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 11
                    If lblLetter11.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 12
                    If lblLetter12.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 13
                    If lblLetter13.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
                Case 14
                    If lblLetter14.Visible = False Then
                        tmpflag = False
                        Exit Do
                    End If
            End Select

            I = I + 1
        Loop

    End Sub

    Public Sub ShowWord()
        'display word to user
        Call ShowlblAlpha()

    End Sub

    Public Sub ShowlblAlpha()
        'clear lblAlpha labels
        lblAlpha0.Visible = True
        lblAlpha1.Visible = True
        lblAlpha2.Visible = True
        lblAlpha3.Visible = True
        lblAlpha4.Visible = True
        lblAlpha5.Visible = True
        lblAlpha6.Visible = True
        lblAlpha7.Visible = True
        lblAlpha8.Visible = True
        lblAlpha9.Visible = True
        lblAlpha10.Visible = True
        lblAlpha11.Visible = True
        lblAlpha12.Visible = True
        lblAlpha13.Visible = True
        lblAlpha14.Visible = True
    End Sub

    Public Sub HidelblAlpha()
        'clear lblAlpha labels
        lblAlpha0.Visible = False
        lblAlpha1.Visible = False
        lblAlpha2.Visible = False
        lblAlpha3.Visible = False
        lblAlpha4.Visible = False
        lblAlpha5.Visible = False
        lblAlpha6.Visible = False
        lblAlpha7.Visible = False
        lblAlpha8.Visible = False
        lblAlpha9.Visible = False
        lblAlpha10.Visible = False
        lblAlpha11.Visible = False
        lblAlpha12.Visible = False
        lblAlpha13.Visible = False
        lblAlpha14.Visible = False
    End Sub

    Public Sub DisableCmdLetter(ByRef Index As Short)
        'disable button that was selected
        Select Case Index
            Case 0
                Me.cmdLetter0.Enabled = False
            Case 1
                Me.cmdLetter1.Enabled = False
            Case 2
                Me.cmdLetter2.Enabled = False
            Case 3
                Me.cmdLetter3.Enabled = False
            Case 4
                Me.cmdLetter4.Enabled = False
            Case 5
                Me.cmdLetter5.Enabled = False
            Case 6
                Me.cmdLetter6.Enabled = False
            Case 7
                Me.cmdLetter7.Enabled = False
            Case 8
                Me.cmdLetter8.Enabled = False
            Case 9
                Me.cmdLetter9.Enabled = False
            Case 10
                Me.cmdLetter10.Enabled = False
            Case 11
                Me.cmdLetter11.Enabled = False
            Case 12
                Me.cmdLetter12.Enabled = False
            Case 13
                Me.cmdLetter13.Enabled = False
            Case 14
                Me.cmdLetter14.Enabled = False
            Case 15
                Me.cmdLetter15.Enabled = False
            Case 16
                Me.cmdLetter16.Enabled = False
            Case 17
                Me.cmdLetter17.Enabled = False
            Case 18
                Me.cmdLetter18.Enabled = False
            Case 19
                Me.cmdLetter19.Enabled = False
            Case 20
                Me.cmdLetter20.Enabled = False
            Case 21
                Me.cmdLetter21.Enabled = False
            Case 22
                Me.cmdLetter22.Enabled = False
            Case 23
                Me.cmdLetter23.Enabled = False
            Case 24
                Me.cmdLetter24.Enabled = False
            Case 25
                Me.cmdLetter25.Enabled = False
        End Select
    End Sub

    Public Sub EnableCmdLetters()

        Me.cmdLetter0.Enabled = True
        Me.cmdLetter1.Enabled = True
        Me.cmdLetter2.Enabled = True
        Me.cmdLetter3.Enabled = True
        Me.cmdLetter4.Enabled = True
        Me.cmdLetter5.Enabled = True
        Me.cmdLetter6.Enabled = True
        Me.cmdLetter7.Enabled = True
        Me.cmdLetter8.Enabled = True
        Me.cmdLetter9.Enabled = True
        Me.cmdLetter10.Enabled = True
        Me.cmdLetter11.Enabled = True
        Me.cmdLetter12.Enabled = True
        Me.cmdLetter13.Enabled = True
        Me.cmdLetter14.Enabled = True
        Me.cmdLetter15.Enabled = True
        Me.cmdLetter16.Enabled = True
        Me.cmdLetter17.Enabled = True
        Me.cmdLetter18.Enabled = True
        Me.cmdLetter19.Enabled = True
        Me.cmdLetter20.Enabled = True
        Me.cmdLetter21.Enabled = True
        Me.cmdLetter22.Enabled = True
        Me.cmdLetter23.Enabled = True
        Me.cmdLetter24.Enabled = True
        Me.cmdLetter25.Enabled = True

    End Sub

    Public Sub ClearlblArray()
        Dim I As Short

        'need to turn off underlines Line(X)
        For I = 0 To MAXARRAY

            Select Case I
                Case 0
                    lblLetter0.Text = ""
                    lblLetter0.Visible = False
                    lblWLine0.Visible = False
                    lblAlpha0.Text = ""
                    lblAlpha0.Visible = False
                Case 1
                    lblLetter1.Text = ""
                    lblLetter1.Visible = False
                    lblWLine1.Visible = False
                    lblAlpha1.Text = ""
                    lblAlpha1.Visible = False
                Case 2
                    lblLetter2.Text = ""
                    lblLetter2.Visible = False
                    lblWLine2.Visible = False
                    lblAlpha2.Text = ""
                    lblAlpha2.Visible = False
                Case 3
                    lblLetter3.Text = ""
                    lblLetter3.Visible = False
                    lblWLine3.Visible = False
                    lblAlpha3.Text = ""
                    lblAlpha3.Visible = False
                Case 4
                    lblLetter4.Text = ""
                    lblLetter4.Visible = False
                    lblWLine4.Visible = False
                    lblAlpha4.Text = ""
                    lblAlpha4.Visible = False
                Case 5
                    lblLetter5.Text = ""
                    lblLetter5.Visible = False
                    lblWLine5.Visible = False
                    lblAlpha5.Text = ""
                    lblAlpha5.Visible = False
                Case 6
                    lblLetter6.Text = ""
                    lblLetter6.Visible = False
                    lblWLine6.Visible = False
                    lblAlpha6.Text = ""
                    lblAlpha6.Visible = False
                Case 7
                    lblLetter7.Text = ""
                    lblLetter7.Visible = False
                    lblWLine7.Visible = False
                    lblAlpha7.Text = ""
                    lblAlpha7.Visible = False
                Case 8
                    lblLetter8.Text = ""
                    lblLetter8.Visible = False
                    lblWLine8.Visible = False
                    lblAlpha8.Text = ""
                    lblAlpha8.Visible = False
                Case 9
                    lblLetter9.Text = ""
                    lblLetter9.Visible = False
                    lblWLine9.Visible = False
                    lblAlpha9.Text = ""
                    lblAlpha9.Visible = False
                Case 10
                    lblLetter10.Text = ""
                    lblLetter10.Visible = False
                    lblWLine10.Visible = False
                    lblAlpha10.Text = ""
                    lblAlpha10.Visible = False
                Case 11
                    lblLetter11.Text = ""
                    lblLetter11.Visible = False
                    lblWLine11.Visible = False
                    lblAlpha11.Text = ""
                    lblAlpha11.Visible = False
                Case 12
                    lblLetter12.Text = ""
                    lblLetter12.Visible = False
                    lblWLine12.Visible = False
                    lblAlpha12.Text = ""
                    lblAlpha12.Visible = False
                Case 13
                    lblLetter13.Text = ""
                    lblLetter13.Visible = False
                    lblWLine13.Visible = False
                    lblAlpha13.Text = ""
                    lblAlpha13.Visible = False
                Case 14
                    lblLetter14.Text = ""
                    lblLetter14.Visible = False
                    lblWLine14.Visible = False
                    lblAlpha14.Text = ""
                    lblAlpha14.Visible = False
            End Select

        Next I

    End Sub

    Public Sub ClearHangMan()
        'clear hangman

        DrawShape(0, False)
        DrawShape(1, False)
        DrawShape(2, False)
        DrawShape(3, False)
        DrawShape(4, False)
        DrawShape(5, False)
        Me.Lhand.Visible = False
        Me.Rhand.Visible = False
        Me.Lfoot.Visible = False
        Me.Rfoot.Visible = False

    End Sub

    Public Sub DisableCmdLetters()
        'disable cmdletters

        Me.cmdLetter0.Enabled = False
        Me.cmdLetter1.Enabled = False
        Me.cmdLetter2.Enabled = False
        Me.cmdLetter3.Enabled = False
        Me.cmdLetter4.Enabled = False
        Me.cmdLetter5.Enabled = False
        Me.cmdLetter6.Enabled = False
        Me.cmdLetter7.Enabled = False
        Me.cmdLetter8.Enabled = False
        Me.cmdLetter9.Enabled = False
        Me.cmdLetter10.Enabled = False
        Me.cmdLetter11.Enabled = False
        Me.cmdLetter12.Enabled = False
        Me.cmdLetter13.Enabled = False
        Me.cmdLetter14.Enabled = False
        Me.cmdLetter15.Enabled = False
        Me.cmdLetter16.Enabled = False
        Me.cmdLetter17.Enabled = False
        Me.cmdLetter18.Enabled = False
        Me.cmdLetter19.Enabled = False
        Me.cmdLetter20.Enabled = False
        Me.cmdLetter21.Enabled = False
        Me.cmdLetter22.Enabled = False
        Me.cmdLetter23.Enabled = False
        Me.cmdLetter24.Enabled = False
        Me.cmdLetter25.Enabled = False

    End Sub

    Public Sub DisplayCategoryFile()
        'display category name
        Select Case NFile
            Case 1
                'sbStatusBar.Panels.Item(2).Text = "Category is Animals"
                sbStatusStrip.Items(1).Text = "Category is Animals"
            Case 2
                'sbStatusBar.Panels.Item(2).Text = "Category is Food"
                sbStatusStrip.Items(1).Text = "Category is Food"
            Case 3
                'sbStatusBar.Panels.Item(2).Text = "Category is Holidays"
                sbStatusStrip.Items(1).Text = "Category is Holidays"
            Case 4
                'sbStatusBar.Panels.Item(2).Text = "Category is Home"
                sbStatusStrip.Items(1).Text = "Category is Home"
            Case 5
                'sbStatusBar.Panels.Item(2).Text = "Category is Leisure"
                sbStatusStrip.Items(1).Text = "Category is Leisure"
            Case 6
                'sbStatusBar.Panels.Item(2).Text = "Category is Seasons"
                sbStatusStrip.Items(1).Text = "Category is Seasons"
            Case 7
                'sbStatusBar.Panels.Item(2).Text = "Category is Sports"
                sbStatusStrip.Items(1).Text = "Category is Sports"
            Case 8
                'sbStatusBar.Panels.Item(2).Text = "Category is Weather"
                sbStatusStrip.Items(1).Text = "Category is Weather"
            Case 9
                'sbStatusBar.Panels.Item(2).Text = "Category is Misc"
                sbStatusStrip.Items(1).Text = "Category is Misc"
            Case Else
                MsgBox("Value not found")
        End Select
    End Sub

    Public Sub SetCategoryMenuItems(ByRef NFile As Short)
        'check menu items

        mnuAnimals.Checked = False
        mnuFood.Checked = False
        mnuHolidays.Checked = False
        mnuHome.Checked = False
        mnuLeisure.Checked = False
        mnuSeasons.Checked = False
        mnuSports.Checked = False
        mnuWeather.Checked = False
        mnuMisc.Checked = False

        Select Case NFile
            Case 1
                mnuAnimals.Checked = True
            Case 2
                mnuFood.Checked = True
            Case 3
                mnuHolidays.Checked = True
            Case 4
                mnuHome.Checked = True
            Case 5
                mnuLeisure.Checked = True
            Case 6
                mnuSeasons.Checked = True
            Case 7
                mnuSports.Checked = True
            Case 8
                mnuWeather.Checked = True
            Case 9
                mnuMisc.Checked = True
            Case Else
                MsgBox("Value not found")
        End Select
    End Sub

    Public Sub SetSoundMenuItems(ByRef gSound As Short)
        'set sound menu item to on or off

        mnuSoundOn.Checked = False
        mnuSoundOff.Checked = False
        If gSound = 1 Then
            mnuSoundOn.Checked = True
        Else
            mnuSoundOff.Checked = True
        End If

    End Sub

    Public Sub ClearAllItems()
        'error found, clear all items
        mflag = True
        lblWordIs.Visible = False
        ClearlblArray()
        ClearHangMan()
        lblStatus.Text = ""
        lblWordIs.Visible = False
        DisableCmdLetters()
        'MsgBox "Error in file!"
        'sbStatusBar.Panels.Item(2).Text = "File not found!"
        sbStatusStrip.Items(1).Text = "File not found!"
    End Sub

    Public Sub SelectNewCategory(ByRef mtmp As Short)
        'select new category for words

        FindCategoryFile(mtmp, tfile)
        gFileok = True
        DataFileExist(tfile, gFileok)
        If gFileok Then
            If NFile <> mtmp Then
                'NFile = mtmp
                cmdNewGame_Click(cmdNewGame, New System.EventArgs())
            End If
        Else
            gFileok = True
            'set category flag to true
            SetCategoryFlagTrue(mtmp)
            mtmp = moldtmp
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, tfile)
        End If
    End Sub

    Public Sub SetCategoryFlagTrue(ByRef mtmp As Short)
        'set flag to true if category file not found
        Select Case mtmp
            Case 1
                CatFlag1 = True
            Case 2
                CatFlag2 = True
            Case 3
                CatFlag3 = True
            Case 4
                CatFlag4 = True
            Case 5
                CatFlag5 = True
            Case 6
                CatFlag6 = True
            Case 7
                CatFlag7 = True
            Case 8
                CatFlag8 = True
            Case 9
                CatFlag9 = True
            Case Else
                MsgBox("Value not found")
        End Select
    End Sub

    Public Sub SetCategoryFlagsFalse()
        'initialize category flags to false
        CatFlag1 = False
        CatFlag2 = False
        CatFlag3 = False
        CatFlag4 = False
        CatFlag5 = False
        CatFlag6 = False
        CatFlag7 = False
        CatFlag8 = False
        CatFlag9 = False
    End Sub

    Public Sub mnuAdvanced_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAdvanced.Popup
        mnuAdvanced_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuAdvanced_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAdvanced.Click
        'select advanced mode
        If gLevel = False Then
            'player wants to change level, need to start new game
            If mflag Then
                'end of game reached, start new game
                'update status bar text for level
                ' sbStatusBar.Panels.Item(1).Text = "Advanced"
                sbStatusStrip.Items(0).Text = "Advanced"
                'gLevel is true for advanced player
                gLevel = True
                mnuBeginner.Checked = False
                mnuAdvanced.Checked = True
                InitNewGame()
            Else
                Msg = "Start New Game?"
                Style = CStr(MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
                Ans = CStr(MsgBox(Msg, CDbl(Style), HM_MSG))
                'ans will return as IDYES = 6 or IDNO = 7
                If CDbl(Ans) = IDYES Then
                    'update status bar text for level
                    'sbStatusBar.Panels.Item(1).Text = "Advanced"
                    sbStatusStrip.Items(0).Text = "Advanced"
                    'gLevel is true for advanced player
                    gLevel = True
                    mnuBeginner.Checked = False
                    mnuAdvanced.Checked = True
                    InitNewGame()
                End If
            End If
        End If
    End Sub

    Public Sub mnuBeginner_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBeginner.Popup
        mnuBeginner_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuBeginner_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBeginner.Click
        'select beginner mode
        If gLevel = True Then
            'player wants to change level, need to start new game
            If mflag Then
                'end of game reached, start new game
                'update status bar text for level
                ' sbStatusBar.Panels.Item(1).Text = "Beginner"
                sbStatusStrip.Items(0).Text = "Beginner"
                'gLevel is true for advanced player
                gLevel = False
                mnuBeginner.Checked = True
                mnuAdvanced.Checked = False
                InitNewGame()
            Else
                Msg = "Start New Game?"
                Style = CStr(MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
                Ans = CStr(MsgBox(Msg, CDbl(Style), HM_MSG))
                'ans will return as IDYES = 6 or IDNO = 7
                If CDbl(Ans) = IDYES Then
                    'update status bar text for level
                    ' sbStatusBar.Panels.Item(1).Text = "Beginner"
                    sbStatusStrip.Items(0).Text = "Beginner"
                    'gLevel is true for advanced player
                    gLevel = False
                    mnuBeginner.Checked = True
                    mnuAdvanced.Checked = False
                    InitNewGame()
                End If
            End If
        End If
    End Sub

    Public Sub mnuHelpAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Popup
        mnuHelpAbout_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Public Sub mnuHelpPrint_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpPrint.Popup
        mnuHelpPrint_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHelpPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpPrint.Click
        'open the windows write application to print order form
        Dim RetVal As Integer
        Dim tempstr As String
        Dim wRtn As String

        On Error GoTo BadPrint

        tempstr = New String(Chr(0), 145)
        'wRtn is the number of chars in the string
        wRtn = CStr(GetWindowsDirectory(tempstr, 145))
        'wRtn is the number of chars in the string
        'tempstr is the directory returned, C:\Windows
        tempstr = Mid(tempstr, 1, CInt(wRtn))

        If FileExists(tempstr & "\notepad.exe") And FileExists(My.Application.Info.DirectoryPath & "\order.txt") Then
            'run the notepad application under Windows to allow the user to print the order form.
            RetVal = Shell(tempstr & "\notepad.exe " & My.Application.Info.DirectoryPath & "\order.txt", 1)
            Exit Sub
        End If

BadPrint:
        'file is missing or corrupted
        Msg = "File is missing or corrupted!"
        MsgBox(Msg, 16, "Error!")
        Exit Sub
        Resume

    End Sub

    Public Sub mnuHelpRules_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpRules.Popup
        mnuHelpRules_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHelpRules_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpRules.Click
        'show rules to play
        frmRules.ShowDialog()
    End Sub

    Private Sub mnuHint_Click()
        'give the player a hint
        MsgBox("Sorry no Hint!")
    End Sub

    Public Sub mnuNewGame_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewGame.Popup
        mnuNewGame_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuNewGame_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewGame.Click
        'start new game
        cmdNewGame_Click(cmdNewGame, New System.EventArgs())
    End Sub

    Public Sub mnuSoundOff_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSoundOff.Popup
        mnuSoundOff_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuSoundOff_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSoundOff.Click
        'turn off sound
        gSound = 0
        SetSoundMenuItems(gSound)
    End Sub

    Public Sub mnuSoundOn_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSoundOn.Popup
        mnuSoundOn_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuSoundOn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSoundOn.Click
        'turn on sound
        gSound = 1
        SetSoundMenuItems(gSound)
    End Sub



    Public Sub mnuFileExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Popup
        mnuFileExit_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        cmdExit_Click(cmdExit, New System.EventArgs())
    End Sub

    Private Sub mnuFileNew_Click()
        cmdNewGame_Click(cmdNewGame, New System.EventArgs())
    End Sub

    Public Sub mnuFood_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFood.Popup
        mnuFood_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuFood_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFood.Click
        'select words from food.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag2 Then
            mtmp = 2
            SelectNewCategory(mtmp)
        Else
            Beep()
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "food.dat")
        End If
    End Sub

    Public Sub mnuHolidays_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHolidays.Popup
        mnuHolidays_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHolidays_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHolidays.Click
        'select words from holidays.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag3 Then
            mtmp = 3
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "holidays.dat")
        End If
    End Sub

    Public Sub mnuHome_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHome.Popup
        mnuHome_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuHome_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHome.Click
        'select words from home.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag4 Then
            mtmp = 4
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "home.dat")
        End If
    End Sub

    Public Sub mnuLeisure_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLeisure.Popup
        mnuLeisure_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuLeisure_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLeisure.Click
        'select words from leisure.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag5 Then
            mtmp = 5
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "leisure.dat")
        End If
    End Sub

    Public Sub mnuSeasons_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSeasons.Popup
        mnuSeasons_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuSeasons_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSeasons.Click
        'select words from seasons.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag6 Then
            mtmp = 6
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "seasons.dat")
        End If
    End Sub

    Public Sub mnuSports_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSports.Popup
        mnuSports_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuSports_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSports.Click
        'select words from sports.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag7 Then
            mtmp = 7
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "sports.dat")
        End If
    End Sub

    Public Sub mnuWeather_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWeather.Popup
        mnuWeather_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuWeather_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWeather.Click
        'select words from weather.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag8 Then
            mtmp = 8
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "weather.dat")
        End If
    End Sub

    Public Sub mnuMisc_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMisc.Popup
        mnuMisc_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuMisc_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMisc.Click
        'select words from misc.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag9 Then
            mtmp = 9
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "misc.dat")
        End If
    End Sub

    Public Sub mnuAnimals_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAnimals.Popup
        mnuAnimals_Click(eventSender, eventArgs)
    End Sub

    Public Sub mnuAnimals_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAnimals.Click
        'select words from animals.txt
        moldtmp = NFile
        'only search for file if flag is set to true
        If Not CatFlag1 Then
            mtmp = 1
            SelectNewCategory(mtmp)
        Else
            Msg = "File is missing or corrupted!"
            MsgBox(Msg, 16, "animals.dat")
        End If
    End Sub

    Public Sub UpDateStatusBar(ByRef Games As Short, ByRef Hangs As Short)
        'update status bar text for MaxGames and MaxHangs
        ' sbStatusBar.Panels.Item(4).Text = Str(Games)
        sbStatusStrip.Items(3).Text = Str(Games)
        ' sbStatusBar.Panels.Item(6).Text = Str(Hangs)
        sbStatusStrip.Items(5).Text = Str(Hangs)
    End Sub

    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click

        Msg = "Quit Game?"
        Style = CStr(MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2)
        Ans = CStr(MsgBox(Msg, CDbl(Style), HM_MSG))
        'ans will return as IDYES = 6 or IDNO = 7
        If CDbl(Ans) = IDYES Then
            'unload the form
            ShowNagScreen()
            PutIniFileSettings(NFile, gSound)
            Me.Close()
        End If

    End Sub

    'Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
    '    'added
    '    Select Case e.ClickedItem.ImageKey.ToString
    '        ' EventArgs.button.Key
    '        Case "Animals"  'NFile = 1
    '            mnuAnimals_Click(mnuAnimals, New System.EventArgs())
    '        Case "Food"     'NFile = 2
    '            mnuFood_Click(mnuFood, New System.EventArgs())
    '        Case "Holidays" 'NFile = 3
    '            mnuHolidays_Click(mnuHolidays, New System.EventArgs())
    '        Case "Home"     'NFile = 4
    '            mnuHome_Click(mnuHome, New System.EventArgs())
    '        Case "Leisure"  'NFile = 5
    '            mnuLeisure_Click(mnuLeisure, New System.EventArgs())
    '        Case "Seasons"  'NFile = 6
    '            mnuSeasons_Click(mnuSeasons, New System.EventArgs())
    '        Case "Sports"   'NFile = 7
    '            mnuSports_Click(mnuSports, New System.EventArgs())
    '        Case "Weather"  'NFile = 8
    '            mnuWeather_Click(mnuWeather, New System.EventArgs())
    '        Case "Misc"     'NFile = 9
    '            mnuMisc_Click(mnuMisc, New System.EventArgs())
    '    End Select
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'added
        mnuAnimals_Click(mnuAnimals, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        mnuFood_Click(mnuFood, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        mnuHolidays_Click(mnuHolidays, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        mnuHome_Click(mnuHome, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        mnuLeisure_Click(mnuLeisure, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        mnuSeasons_Click(mnuSeasons, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        mnuSports_Click(mnuSports, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        mnuWeather_Click(mnuWeather, New System.EventArgs())

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        mnuMisc_Click(mnuMisc, New System.EventArgs())

    End Sub
End Class