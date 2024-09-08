Option Strict Off
Option Explicit On
Friend Class frmRules
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
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Public ToolTip1 As System.Windows.Forms.ToolTip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRules))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 14)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(479, 328)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'frmRules
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 389)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(116, 117)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRules"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Playing the game"
        Me.ResumeLayout(False)

    End Sub
#End Region 

	Private Sub frmRules_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
        ' Center the Form on the screen
        Me.SetBounds((System.Windows.Forms.Screen.GetBounds(Me).Width / 2) - (Me.Width / 2), _
            (System.Windows.Forms.Screen.GetBounds(Me).Height / 2) - (Me.Height / 2), _
            Me.Width, Me.Height, System.Windows.Forms.BoundsSpecified.Location)

    End Sub
	
	Private Sub frmRules_Paint(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
		
		'position rule text
        Dim CurrentX As Integer
        CurrentX = 0
        Dim CurrentY As Integer
        CurrentY = 0
		
		'display text on form
        RichTextBox1.Text = "Hang Man is easy to play, but can you become an expert? You can select either Beginner or Advanced level of play." & Environment.NewLine & Environment.NewLine & "There are nine word categories:" & Environment.NewLine & Environment.NewLine & "Animals, Food, Holidays, Home, Leisure, Seasons, Sports, Weather, and Misc." & Environment.NewLine & Environment.NewLine & "The object of the game is to guess the word before you get hung." & Environment.NewLine & Environment.NewLine & "At the beginning of play you select the letter you want to guess. If your right the letter is displayed, but if you are wrong?" & Environment.NewLine & Environment.NewLine & "See if you can guess the word before your hung!" & Environment.NewLine & Environment.NewLine & "This is a game that interests people of all ages."
		
	End Sub
End Class