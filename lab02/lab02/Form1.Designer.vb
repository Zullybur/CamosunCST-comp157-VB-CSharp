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
        Me.components = New System.ComponentModel.Container()
        Me.Pane1 = New System.Windows.Forms.Panel()
        Me.picBoxDie2 = New System.Windows.Forms.PictureBox()
        Me.picBoxDie1 = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.tbResults = New System.Windows.Forms.TextBox()
        Me.lblTimerCount = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.lblRollNumber = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblBet = New System.Windows.Forms.Label()
        Me.tbBetAmount = New System.Windows.Forms.MaskedTextBox()
        Me.cbNoRolls = New System.Windows.Forms.CheckBox()
        Me.Pane1.SuspendLayout()
        CType(Me.picBoxDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pane1
        '
        Me.Pane1.BackColor = System.Drawing.SystemColors.Window
        Me.Pane1.Controls.Add(Me.picBoxDie2)
        Me.Pane1.Controls.Add(Me.picBoxDie1)
        Me.Pane1.Location = New System.Drawing.Point(289, 12)
        Me.Pane1.Name = "Pane1"
        Me.Pane1.Size = New System.Drawing.Size(312, 156)
        Me.Pane1.TabIndex = 0
        '
        'picBoxDie2
        '
        Me.picBoxDie2.Location = New System.Drawing.Point(159, 3)
        Me.picBoxDie2.Name = "picBoxDie2"
        Me.picBoxDie2.Size = New System.Drawing.Size(150, 150)
        Me.picBoxDie2.TabIndex = 1
        Me.picBoxDie2.TabStop = False
        '
        'picBoxDie1
        '
        Me.picBoxDie1.Location = New System.Drawing.Point(3, 3)
        Me.picBoxDie1.Name = "picBoxDie1"
        Me.picBoxDie1.Size = New System.Drawing.Size(150, 150)
        Me.picBoxDie1.TabIndex = 0
        Me.picBoxDie1.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(289, 208)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(312, 72)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'btnQuit
        '
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(289, 320)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(312, 72)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Cash Out"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'tbResults
        '
        Me.tbResults.BackColor = System.Drawing.SystemColors.Window
        Me.tbResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResults.Location = New System.Drawing.Point(12, 435)
        Me.tbResults.Multiline = True
        Me.tbResults.Name = "tbResults"
        Me.tbResults.ReadOnly = True
        Me.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbResults.Size = New System.Drawing.Size(589, 295)
        Me.tbResults.TabIndex = 3
        '
        'lblTimerCount
        '
        Me.lblTimerCount.AutoSize = True
        Me.lblTimerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerCount.Location = New System.Drawing.Point(21, 9)
        Me.lblTimerCount.Name = "lblTimerCount"
        Me.lblTimerCount.Size = New System.Drawing.Size(111, 32)
        Me.lblTimerCount.TabIndex = 4
        Me.lblTimerCount.Text = "0:00:00"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(21, 87)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(81, 32)
        Me.lblCash.TabIndex = 5
        Me.lblCash.Text = "Cash"
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.Location = New System.Drawing.Point(21, 243)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(182, 32)
        Me.lblPoint.TabIndex = 6
        Me.lblPoint.Text = "Current Point"
        '
        'lblRollNumber
        '
        Me.lblRollNumber.AutoSize = True
        Me.lblRollNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollNumber.Location = New System.Drawing.Point(21, 321)
        Me.lblRollNumber.Name = "lblRollNumber"
        Me.lblRollNumber.Size = New System.Drawing.Size(148, 32)
        Me.lblRollNumber.TabIndex = 7
        Me.lblRollNumber.Text = "Roll Count"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'lblBet
        '
        Me.lblBet.AutoSize = True
        Me.lblBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBet.Location = New System.Drawing.Point(21, 146)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(171, 32)
        Me.lblBet.TabIndex = 0
        Me.lblBet.Text = "Bet Amount:"
        '
        'tbBetAmount
        '
        Me.tbBetAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBetAmount.Location = New System.Drawing.Point(27, 181)
        Me.tbBetAmount.Mask = "0000"
        Me.tbBetAmount.Name = "tbBetAmount"
        Me.tbBetAmount.Size = New System.Drawing.Size(75, 39)
        Me.tbBetAmount.TabIndex = 10
        '
        'cbNoRolls
        '
        Me.cbNoRolls.AutoSize = True
        Me.cbNoRolls.Location = New System.Drawing.Point(369, 741)
        Me.cbNoRolls.Name = "cbNoRolls"
        Me.cbNoRolls.Size = New System.Drawing.Size(232, 24)
        Me.cbNoRolls.TabIndex = 11
        Me.cbNoRolls.Text = "De-Activate Roll Animations"
        Me.cbNoRolls.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 773)
        Me.Controls.Add(Me.cbNoRolls)
        Me.Controls.Add(Me.tbBetAmount)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.lblRollNumber)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.lblTimerCount)
        Me.Controls.Add(Me.tbResults)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Pane1)
        Me.Name = "Form1"
        Me.Text = "Dice Game"
        Me.Pane1.ResumeLayout(False)
        CType(Me.picBoxDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pane1 As Panel
    Friend WithEvents picBoxDie2 As PictureBox
    Friend WithEvents picBoxDie1 As PictureBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btnQuit As Button
    Friend WithEvents tbResults As TextBox
    Friend WithEvents lblTimerCount As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents lblRollNumber As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblBet As Label
    Friend WithEvents tbBetAmount As MaskedTextBox
    Friend WithEvents cbNoRolls As CheckBox
End Class
