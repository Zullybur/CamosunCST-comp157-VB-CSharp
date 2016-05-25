' Quasi Craps - A basic version of a Craps dice game.
' Created By: Matthew Casiro
' Created On: April 26 2016
Public Class Form1
    ' Class Scope Variable Declarations
    Private Const NUM_SIDES As Integer = 6
    Private rndRoll As New Random
    Private intCash, intBetAmount, intRollCounter, intPoint, intSum As Integer
    Private blnWonRound, blnLostRound, blnPointSet As Boolean
    Private blnPrintDebug, blnRollAnimations As Boolean
    Private datStartTime As Date
    Private intTimerTicker, intDieOne, intDieTwo As Integer
    ' Initialize variables on form load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        intCash = 100
        lblCash.Text = "Cash: $" & intCash
        intBetAmount = 10
        tbBetAmount.Text = intBetAmount
        lblBet.Text = "Bet Amount:"
        intPoint = 0
        intDieOne = 0
        intDieTwo = 0
        lblPoint.Text = "Point: " & intPoint
        lblRollNumber.Text = "Roll #: " & intRollCounter
        blnLostRound = False
        blnWonRound = False
        blnPointSet = False
        blnRollAnimations = True
        datStartTime = Date.Now

#If DEBUG Then
        blnPrintDebug = True
#End If
    End Sub
    ' Return a randomly generated number based on the size of the die in play
    Private Function rollDie() As Integer
        Return rndRoll.Next(1, NUM_SIDES + 1)
    End Function
    ' Track and display game timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timePlayed As TimeSpan = Date.Now.Subtract(datStartTime)
        lblTimerCount.Text = String.Format("{0}:{1:d2}:{2:d2}",
                                           timePlayed.Hours,
                                           timePlayed.Minutes,
                                           timePlayed.Seconds)
    End Sub
    ' Roll dice and handle results according to game rules
    ' Calls spinDice() for animations
    ' Calls logRoll() for printout to form
    ' Calls endRound() on reaching a win or lose condition
    Private Async Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        btnRoll.Enabled = False
        btnQuit.Enabled = False
        tbBetAmount.Enabled = False
        Pane1.Select()
        ' Roll dice and display resut to log
        intRollCounter += 1
        lblRollNumber.Text = "Roll #: " & intRollCounter
        intDieOne = rollDie()
        intDieTwo = rollDie()
        If blnRollAnimations Then
            spinDice()
            ' Wait for the dice to finish rolling animation
            Await Task.Delay(5000)
        Else
            setDiceImage(intDieOne, intDieTwo)
        End If
        intSum = intDieOne + intDieTwo
        ' Process roll result for fresh round (point not set)
        If Not blnPointSet Then
            If intSum = 7 Or intSum = 11 Then
                logRoll("Win")
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                blnWonRound = True
                endRound()
            ElseIf intSum = 2 Or intSum = 3 Or intSum = 12 Then
                logRoll("Lose")
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                blnLostRound = True
                endRound()
            ElseIf 0 < intSum And intSum <= 12 Then
                blnPointSet = True
                intPoint = intSum
                lblPoint.Text = "Point: " & intPoint
                logRoll("Point")
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                If blnPrintDebug Then Debug.WriteLine("DEBUG intPoint: " & intPoint)
            Else
                logRoll("Error")
            End If
        Else
            ' Process roll result for round in progress (point set)
            If intSum = intPoint Then
                logRoll("Win")
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                blnWonRound = True
                endRound()
            ElseIf intSum = 7 Then
                logRoll("Lose")
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                blnLostRound = True
                endRound()
            Else
                If blnPrintDebug Then Debug.WriteLine("DEBUG intSum: " & intSum)
                logRoll("")
            End If
        End If
        ' Unlock custom bet textbox if no point established
        If Not blnPointSet Then
            tbBetAmount.Enabled = True
        End If
        btnRoll.Enabled = True
        btnQuit.Enabled = True
    End Sub
    ' Verify and update bet amount when user enters custom value
    Private Sub tbBetAmount_Leave(sender As Object, e As EventArgs) Handles tbBetAmount.Leave
        ' Check for null input to prevent application crash
        If tbBetAmount.Text = "" Or tbBetAmount.Text = Nothing Then
            tbBetAmount.Text = 0
        End If
        ' Verify bet amount is at least $10, less than cash amount, and a multiple of 10, 
        If tbBetAmount.Text < 10 Then
            MessageBox.Show("The minimum bet is $10.",
                            "Invalid bet amount",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            tbBetAmount.Text = 10
        ElseIf tbBetAmount.Text > intCash Then
            MessageBox.Show("You can not bet more than your current cash amount.",
                            "Invalid bet amount",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            tbBetAmount.Text = intCash
        ElseIf tbBetAmount.Text Mod 10 <> 0 Then
            MessageBox.Show("The bet amount must be a multiple of $10.",
                            "Invalid bet amount",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            tbBetAmount.Text = tbBetAmount.Text - (tbBetAmount.Text Mod 10)
        End If
        intBetAmount = tbBetAmount.Text
    End Sub
    ' Turn on or off roll animations
    Private Sub cbNoRolls_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoRolls.CheckedChanged
        If cbNoRolls.CheckState = 1 Then
            blnRollAnimations = False
        Else
            blnRollAnimations = True
        End If
    End Sub
    ' Initiate Timer2 ticks to control dice spinning
    Private Sub spinDice()
        Timer2.Interval = 200
        intTimerTicker = 0
        Timer2.Start()
    End Sub
    ' Display two dice to screen based on the given values
    Private Sub setDiceImage(img1 As Integer, img2 As Integer)
        Select Case img1
            Case 1
                picBoxDie1.Image = My.Resources.Resource1.dice1
            Case 2
                picBoxDie1.Image = My.Resources.Resource1.dice2
            Case 3
                picBoxDie1.Image = My.Resources.Resource1.dice3
            Case 4
                picBoxDie1.Image = My.Resources.Resource1.dice4
            Case 5
                picBoxDie1.Image = My.Resources.Resource1.dice5
            Case 6
                picBoxDie1.Image = My.Resources.Resource1.dice6
            Case Else
                picBoxDie1.Image = Nothing
        End Select
        Select Case img2
            Case 1
                picBoxDie2.Image = My.Resources.Resource1.dice1
            Case 2
                picBoxDie2.Image = My.Resources.Resource1.dice2
            Case 3
                picBoxDie2.Image = My.Resources.Resource1.dice3
            Case 4
                picBoxDie2.Image = My.Resources.Resource1.dice4
            Case 5
                picBoxDie2.Image = My.Resources.Resource1.dice5
            Case 6
                picBoxDie2.Image = My.Resources.Resource1.dice6
            Case Else
                picBoxDie2.Image = Nothing
        End Select
    End Sub
    ' Update cash amount for a win or loss and prompt the user to play again or quit
    Private Sub endRound()
        ' Update cash
        If blnWonRound Then
            intCash += intBetAmount
        ElseIf blnLostRound = True Then
            intCash -= intBetAmount
        End If
        lblCash.Text = "Cash: $" & intCash
        ' Check if user wants to continue or quit
        If MessageBox.Show("Do you wish to play again?",
                           "Round over",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) _
                           = DialogResult.Yes Then
            intPoint = 0
            lblPoint.Text = "Point: " & intPoint
            blnLostRound = False
            blnWonRound = False
            blnPointSet = False
            If intCash < 10 Then
                endGame()
            End If
        Else
            endGame()
        End If
    End Sub
    ' Display the final cash amount for the user and exit the program
    Private Sub endGame()
        If intCash < 10 Then
            MessageBox.Show("You ran out of cash. Please leave our casino.",
                           "Game Over",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thanks for Playing! You cashed out with: $" & intCash,
                           "Cashed Out",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
        End If
        Application.Exit()
    End Sub
    ' Log the roll result to the tbResults textbox
    Private Sub logRoll(result As String)
        ' Print appropriate message to log text box
        If tbResults.Text <> "" Then
            tbResults.Text += vbCrLf
        End If
        ' Adjust log message based on the provided parameter
        Select Case result
            Case "Win"
                tbResults.Text += "Rolled " & intSum.ToString & vbCrLf &
                    "--------------------- Round Won! ---------------------"
            Case "Lose"
                tbResults.Text += "Rolled " & intSum.ToString & vbCrLf &
                    "--------------------- Round Lost ---------------------"
            Case "Point"
                tbResults.Text += "Rolled " & intSum.ToString & ". Point established."
            Case "Error"
                tbResults.Text += "DICE VALUE ERROR (roll ignored)"
            Case Else
                tbResults.Text += "Rolled " & intSum.ToString
        End Select
        ' Make the TextBox text scroll up
        Dim ctr As Control = Me.ActiveControl
        tbResults.Focus()
        tbResults.AppendText("")
        tbResults.ScrollToCaret()
        ctr.Focus()
    End Sub
    ' Display final cash amount and exit game, verifying with user first if a point is in play
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        If blnPointSet = True Then
            If MessageBox.Show("A point is in play, you will lose your bet if you leave!" & vbCrLf & "Do you want to quit?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) _
                            = DialogResult.Yes Then
                intCash -= intBetAmount
                endGame()
            End If
        Else
            endGame()
        End If
    End Sub
    ' Display a new random dice image on each tick to represent rolling dice
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        intTimerTicker += 1
        ' Increment tick delay after every 3 ticks
        If intTimerTicker Mod 3 = 0 Then
            Timer2.Interval += 200
        End If
        ' End rolling animation and stop timer after a given number of ticks
        If intTimerTicker > 9 Then
            Timer2.Stop()
            setDiceImage(intDieOne, intDieTwo)
        Else
            Dim tmpDie1 = rollDie()
            Dim tmpDie2 = rollDie()
            setDiceImage(tmpDie1, tmpDie2)
        End If
    End Sub
End Class