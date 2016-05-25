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
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.txtInputChar = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.MaskedTextBox()
        Me.lstColour = New System.Windows.Forms.ListBox()
        Me.btnOtherColours = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSquare
        '
        Me.btnSquare.Location = New System.Drawing.Point(12, 12)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(116, 49)
        Me.btnSquare.TabIndex = 0
        Me.btnSquare.Text = "&Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnTriangle
        '
        Me.btnTriangle.Location = New System.Drawing.Point(181, 12)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(116, 49)
        Me.btnTriangle.TabIndex = 1
        Me.btnTriangle.Text = "&Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(350, 12)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(116, 49)
        Me.btnCircle.TabIndex = 2
        Me.btnCircle.Text = "&Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(12, 243)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(454, 351)
        Me.txtDisplay.TabIndex = 3
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Location = New System.Drawing.Point(13, 89)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(79, 20)
        Me.lblCharacter.TabIndex = 4
        Me.lblCharacter.Text = "Character"
        '
        'txtInputChar
        '
        Me.txtInputChar.Location = New System.Drawing.Point(98, 86)
        Me.txtInputChar.Name = "txtInputChar"
        Me.txtInputChar.Size = New System.Drawing.Size(30, 26)
        Me.txtInputChar.TabIndex = 5
        Me.txtInputChar.Text = "*"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(165, 89)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(40, 20)
        Me.lblSize.TabIndex = 6
        Me.lblSize.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(211, 86)
        Me.txtSize.Mask = "00"
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(33, 26)
        Me.txtSize.TabIndex = 7
        Me.txtSize.Text = "10"
        '
        'lstColour
        '
        Me.lstColour.FormattingEnabled = True
        Me.lstColour.ItemHeight = 20
        Me.lstColour.Location = New System.Drawing.Point(70, 140)
        Me.lstColour.Name = "lstColour"
        Me.lstColour.Size = New System.Drawing.Size(120, 84)
        Me.lstColour.TabIndex = 8
        '
        'btnOtherColours
        '
        Me.btnOtherColours.Location = New System.Drawing.Point(235, 140)
        Me.btnOtherColours.Name = "btnOtherColours"
        Me.btnOtherColours.Size = New System.Drawing.Size(169, 84)
        Me.btnOtherColours.TabIndex = 9
        Me.btnOtherColours.Text = "&Other Colours"
        Me.btnOtherColours.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 611)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(454, 49)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 672)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOtherColours)
        Me.Controls.Add(Me.lstColour)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txtInputChar)
        Me.Controls.Add(Me.lblCharacter)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnCircle)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.btnSquare)
        Me.Name = "Form1"
        Me.Text = "TextDraw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSquare As Button
    Friend WithEvents btnTriangle As Button
    Friend WithEvents btnCircle As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents lblCharacter As Label
    Friend WithEvents txtInputChar As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As MaskedTextBox
    Friend WithEvents lstColour As ListBox
    Friend WithEvents btnOtherColours As Button
    Friend WithEvents btnExit As Button
End Class
