<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbxDrawing = New System.Windows.Forms.PictureBox()
        Me.chkLoop = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnY5 = New System.Windows.Forms.Button()
        Me.btnX5 = New System.Windows.Forms.Button()
        Me.nudY4 = New System.Windows.Forms.NumericUpDown()
        Me.nudX4 = New System.Windows.Forms.NumericUpDown()
        Me.nudY3 = New System.Windows.Forms.NumericUpDown()
        Me.nudX3 = New System.Windows.Forms.NumericUpDown()
        Me.nudY2 = New System.Windows.Forms.NumericUpDown()
        Me.nudX2 = New System.Windows.Forms.NumericUpDown()
        Me.nudY1 = New System.Windows.Forms.NumericUpDown()
        Me.nudX1 = New System.Windows.Forms.NumericUpDown()
        Me.lblArea = New System.Windows.Forms.Label()
        CType(Me.pbxDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudY1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxDrawing
        '
        Me.pbxDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxDrawing.Location = New System.Drawing.Point(-2, 5)
        Me.pbxDrawing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbxDrawing.Name = "pbxDrawing"
        Me.pbxDrawing.Size = New System.Drawing.Size(454, 529)
        Me.pbxDrawing.TabIndex = 0
        Me.pbxDrawing.TabStop = False
        '
        'chkLoop
        '
        Me.chkLoop.Location = New System.Drawing.Point(582, 375)
        Me.chkLoop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(132, 25)
        Me.chkLoop.TabIndex = 27
        Me.chkLoop.Text = "Create loop"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(690, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "X"
        '
        'btnY5
        '
        Me.btnY5.Location = New System.Drawing.Point(666, 314)
        Me.btnY5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnY5.Name = "btnY5"
        Me.btnY5.Size = New System.Drawing.Size(84, 37)
        Me.btnY5.TabIndex = 24
        Me.btnY5.Text = "Y + 5"
        '
        'btnX5
        '
        Me.btnX5.Location = New System.Drawing.Point(534, 314)
        Me.btnX5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnX5.Name = "btnX5"
        Me.btnX5.Size = New System.Drawing.Size(84, 37)
        Me.btnX5.TabIndex = 23
        Me.btnX5.Text = "X + 5"
        '
        'nudY4
        '
        Me.nudY4.Location = New System.Drawing.Point(666, 265)
        Me.nudY4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudY4.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudY4.Name = "nudY4"
        Me.nudY4.Size = New System.Drawing.Size(84, 26)
        Me.nudY4.TabIndex = 22
        Me.nudY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudY4.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'nudX4
        '
        Me.nudX4.Location = New System.Drawing.Point(534, 265)
        Me.nudX4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudX4.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudX4.Name = "nudX4"
        Me.nudX4.Size = New System.Drawing.Size(84, 26)
        Me.nudX4.TabIndex = 21
        Me.nudX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudX4.Value = New Decimal(New Integer() {299, 0, 0, 0})
        '
        'nudY3
        '
        Me.nudY3.Location = New System.Drawing.Point(666, 215)
        Me.nudY3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudY3.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudY3.Name = "nudY3"
        Me.nudY3.Size = New System.Drawing.Size(84, 26)
        Me.nudY3.TabIndex = 20
        Me.nudY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudY3.Value = New Decimal(New Integer() {270, 0, 0, 0})
        '
        'nudX3
        '
        Me.nudX3.Location = New System.Drawing.Point(534, 215)
        Me.nudX3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudX3.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudX3.Name = "nudX3"
        Me.nudX3.Size = New System.Drawing.Size(84, 26)
        Me.nudX3.TabIndex = 19
        Me.nudX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudX3.Value = New Decimal(New Integer() {229, 0, 0, 0})
        '
        'nudY2
        '
        Me.nudY2.Location = New System.Drawing.Point(666, 166)
        Me.nudY2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudY2.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudY2.Name = "nudY2"
        Me.nudY2.Size = New System.Drawing.Size(84, 26)
        Me.nudY2.TabIndex = 18
        Me.nudY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudY2.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'nudX2
        '
        Me.nudX2.Location = New System.Drawing.Point(534, 166)
        Me.nudX2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudX2.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudX2.Name = "nudX2"
        Me.nudX2.Size = New System.Drawing.Size(84, 26)
        Me.nudX2.TabIndex = 17
        Me.nudX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudX2.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'nudY1
        '
        Me.nudY1.Location = New System.Drawing.Point(666, 117)
        Me.nudY1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudY1.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudY1.Name = "nudY1"
        Me.nudY1.Size = New System.Drawing.Size(84, 26)
        Me.nudY1.TabIndex = 16
        Me.nudY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudY1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudX1
        '
        Me.nudX1.Location = New System.Drawing.Point(534, 117)
        Me.nudX1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudX1.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.nudX1.Name = "nudX1"
        Me.nudX1.Size = New System.Drawing.Size(84, 26)
        Me.nudX1.TabIndex = 15
        Me.nudX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudX1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblArea
        '
        Me.lblArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(610, 435)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(77, 20)
        Me.lblArea.TabIndex = 28
        Me.lblArea.Text = "Area: N/A"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 540)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnY5)
        Me.Controls.Add(Me.btnX5)
        Me.Controls.Add(Me.nudY4)
        Me.Controls.Add(Me.nudX4)
        Me.Controls.Add(Me.nudY3)
        Me.Controls.Add(Me.nudX3)
        Me.Controls.Add(Me.nudY2)
        Me.Controls.Add(Me.nudX2)
        Me.Controls.Add(Me.nudY1)
        Me.Controls.Add(Me.nudX1)
        Me.Controls.Add(Me.pbxDrawing)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Curve Drawing"
        CType(Me.pbxDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudY1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxDrawing As System.Windows.Forms.PictureBox
    Friend WithEvents chkLoop As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnY5 As System.Windows.Forms.Button
    Friend WithEvents btnX5 As System.Windows.Forms.Button
    Friend WithEvents nudY4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudX4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudY3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudX3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudY2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudX2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudY1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudX1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblArea As Label
End Class
