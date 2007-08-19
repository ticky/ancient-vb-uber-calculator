Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim tick As Integer
    Dim backupcolor As New Color
    Dim RaNdom As New System.Random

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents nudNumberOne As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbOperator As System.Windows.Forms.ComboBox
    Friend WithEvents nudNumberTwo As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnExtras As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nudNumberOne = New System.Windows.Forms.NumericUpDown
        Me.cmbOperator = New System.Windows.Forms.ComboBox
        Me.nudNumberTwo = New System.Windows.Forms.NumericUpDown
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.btnExtras = New System.Windows.Forms.Button
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.grpExtras = New System.Windows.Forms.GroupBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ColorDialog = New System.Windows.Forms.ColorDialog
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.nudNumberOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExtras.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNumberOne
        '
        Me.nudNumberOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudNumberOne.Location = New System.Drawing.Point(8, 8)
        Me.nudNumberOne.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nudNumberOne.Minimum = New Decimal(New Integer() {-727379969, 232, 0, -2147483648})
        Me.nudNumberOne.Name = "nudNumberOne"
        Me.nudNumberOne.Size = New System.Drawing.Size(128, 20)
        Me.nudNumberOne.TabIndex = 0
        '
        'cmbOperator
        '
        Me.cmbOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cmbOperator.Location = New System.Drawing.Point(136, 8)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(40, 21)
        Me.cmbOperator.TabIndex = 1
        '
        'nudNumberTwo
        '
        Me.nudNumberTwo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudNumberTwo.Location = New System.Drawing.Point(176, 8)
        Me.nudNumberTwo.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nudNumberTwo.Minimum = New Decimal(New Integer() {-727379969, 232, 0, -2147483648})
        Me.nudNumberTwo.Name = "nudNumberTwo"
        Me.nudNumberTwo.Size = New System.Drawing.Size(128, 20)
        Me.nudNumberTwo.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(8, 32)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(16, 16)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "="
        '
        'btnExtras
        '
        Me.btnExtras.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnExtras.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExtras.Location = New System.Drawing.Point(256, 29)
        Me.btnExtras.Name = "btnExtras"
        Me.btnExtras.Size = New System.Drawing.Size(48, 19)
        Me.btnExtras.TabIndex = 5
        Me.btnExtras.Text = "Extras"
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAnswer.Location = New System.Drawing.Point(24, 32)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(224, 13)
        Me.txtAnswer.TabIndex = 6
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.Button1)
        Me.grpExtras.Controls.Add(Me.CheckBox3)
        Me.grpExtras.Controls.Add(Me.CheckBox2)
        Me.grpExtras.Controls.Add(Me.Button2)
        Me.grpExtras.Controls.Add(Me.CheckBox1)
        Me.grpExtras.Enabled = False
        Me.grpExtras.Location = New System.Drawing.Point(8, 56)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(296, 72)
        Me.grpExtras.TabIndex = 7
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'CheckBox3
        '
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox3.Location = New System.Drawing.Point(8, 40)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(136, 24)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Show In Taskbar"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(136, 24)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Always On Top"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(144, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Change Colour"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Location = New System.Drawing.Point(8, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Transparency Effects"
        '
        'ColorDialog
        '
        Me.ColorDialog.Color = System.Drawing.SystemColors.Control
        '
        'Timer
        '
        Me.Timer.Interval = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 72)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version 1.0SE | (C)2007 by Geoff Stokes"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Über Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(240, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 54)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.btnExtras)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.nudNumberTwo)
        Me.Controls.Add(Me.cmbOperator)
        Me.Controls.Add(Me.nudNumberOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Über Calculator"
        Me.TopMost = True
        CType(Me.nudNumberOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExtras.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub nudNumberOne_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNumberOne.ValueChanged, cmbOperator.SelectedIndexChanged, nudNumberTwo.ValueChanged, txtAnswer.TextChanged
        'Calculation Sub
        Select Case cmbOperator.SelectedItem
            Case "+"
                txtAnswer.Text = (nudNumberOne.Value + nudNumberTwo.Value)
            Case "-"
                txtAnswer.Text = (nudNumberOne.Value - nudNumberTwo.Value)
            Case "*"
                txtAnswer.Text = (nudNumberOne.Value * nudNumberTwo.Value)
            Case "/"
                If nudNumberTwo.Value = 0 Then
                    txtAnswer.Text = "Divide-By-Zero Error"
                Else
                    txtAnswer.Text = (nudNumberOne.Value / nudNumberTwo.Value)
                End If
            Case Else
                txtAnswer.Text = "No operation selected"
        End Select
    End Sub

    Private Sub btnExtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtras.Click
        If Me.Height = 78 Then
            Me.Height = 232
            grpExtras.Enabled = True
        Else
            Me.Height = 78
            grpExtras.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ColorDialog.ShowDialog()
        Me.BackColor = ColorDialog.Color

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer.Start()
        backupcolor = Me.BackColor
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If CheckBox1.Checked = True Then
            tick = tick + 1
            Select Case tick
                Case 1
                    Me.Opacity = 0.85
                Case 2
                    Me.Opacity = 0.8
                Case 3
                    Me.Opacity = 0.75
                Case 4
                    Me.Opacity = 0.7
                Case 5
                    Me.Opacity = 0.75
                Case 6
                    Me.Opacity = 0.8
                Case 7
                    Me.Opacity = 0.85
                Case 8
                    Me.Opacity = 0.9
                Case 16
                    tick = 0
            End Select
        Else
            Me.Opacity = 1
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Me.ShowInTaskbar = True
        Else
            Me.ShowInTaskbar = False
        End If
    End Sub

    Private Sub txtAnswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnswer.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackColor = BackupColor
    End Sub
End Class
