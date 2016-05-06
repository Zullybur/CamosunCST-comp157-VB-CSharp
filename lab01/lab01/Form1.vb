' Program to display shapes in various colours
' Created by: Matthew Casiro
' Created on: April 14 2016
Public Class Form1

    ' Print out a square to the display window when the Square button is clicked
    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Dim strOutput As String = ""
        Dim intSize As Integer = txtSize.Text
        Dim i, j As Integer

        txtDisplay.Clear()

        For i = 1 To intSize
            For j = 1 To intSize
                If i > 1 And i < intSize Then
                    If j = 1 Then
                        strOutput += txtInputChar.Text
                    ElseIf j = intSize Then
                        strOutput += " " + txtInputChar.Text
                    Else
                        strOutput += "  "
                    End If
                Else
                    If j = 1 Then
                        strOutput += txtInputChar.Text
                    Else
                        strOutput += " " + txtInputChar.Text
                    End If
                End If
            Next j
            strOutput += vbCrLf
        Next i
        txtDisplay.Text = strOutput
    End Sub

    ' Print out a trianlge to the display window when the Triangle button is clicked
    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        Dim strOutput As String = ""
        Dim intSize As Integer = txtSize.Text
        Dim i, j As Integer

        txtDisplay.Clear()

        For i = 1 To intSize
            For j = i To 1 Step -1
                strOutput += " " + txtInputChar.Text
            Next j
            strOutput += vbCrLf
        Next i
        txtDisplay.Text = strOutput
    End Sub

    ' Print out a circle to the display window when the Circle button is clicked
    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        Dim strOutput As String = ""
        Dim intSize As Integer = txtSize.Text
        Dim intRadius As Integer = intSize / 2
        Dim i, j As Integer
        Dim x, y As Single

        txtDisplay.Clear()

        For i = 0 To intRadius * 2
            y = intRadius - i
            For j = 0 To intRadius * 2
                x = j - intRadius
                If x ^ 2 + y ^ 2 <= intRadius ^ 2 Then
                    strOutput += " " + txtInputChar.Text
                Else
                    strOutput += "  "
                End If
            Next j
            strOutput += vbCrLf
        Next i
        txtDisplay.Text = strOutput
    End Sub

    ' Adjust the character to be printed when the user changes the txtInputChar input
    Private Sub txtInputChar_TextChanged(sender As Object, e As EventArgs) Handles txtInputChar.TextChanged
        If txtInputChar.Text.Length > 1 Then
            txtInputChar.Text = txtInputChar.Text.Substring(0, 1)
        End If
    End Sub

    ' Populate the pre-set colour list on form load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstColour.Items.Add("Black")
        lstColour.Items.Add("Red")
        lstColour.Items.Add("Blue")
        lstColour.Items.Add("Green")
        lstColour.SelectedIndex = 0
    End Sub

    ' Update the foreground colour to match user selection
    Private Sub lstColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstColour.SelectedIndexChanged
        Dim intColour As Integer = lstColour.SelectedIndex
        Select Case intColour
            Case 0
                txtDisplay.ForeColor = Color.Black
            Case 1
                txtDisplay.ForeColor = Color.Red
            Case 2
                txtDisplay.ForeColor = Color.Blue
            Case 3
                txtDisplay.ForeColor = Color.Green
            Case Else
                txtDisplay.ForeColor = Color.Black
        End Select
    End Sub

    ' Open dialog for colour selection when Other Colours button is clicked
    Private Sub btnOtherColours_Click(sender As Object, e As EventArgs) Handles btnOtherColours.Click
        Dim dlgColour As New ColorDialog()
        dlgColour.AllowFullOpen = False
        dlgColour.ShowHelp = True
        dlgColour.Color = Color.Black

        If dlgColour.ShowDialog.Equals(DialogResult.OK) Then
            txtDisplay.ForeColor = dlgColour.Color
        End If
    End Sub

    ' Close progam when Exit button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class