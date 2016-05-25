Imports TrigLib
'Program to draw four points with a curved connecting line
'and display the area if the shape is closed.
'Created by: Matthew Casiro
'Created on: 12 May 2016
Public Class Form1
    Private nudOldX4, nudOldY4 As Decimal
    Private decNewX, decNewY As Decimal
    'Map points, draw black lines between then, and a curved red line
    'connecting them - draw area if shape is closed
    Public Sub DrawCurvePoint(ByVal e As PaintEventArgs)
        ' The bluePen draws the straight lines.
        Dim bluePen As New Pen(Color.Navy, 2)
        ' The redPen draws the curves around the lines.
        Dim redPen As New Pen(Color.Red, 2)

        Dim point1 As New PointF(nudX1.Value, nudY1.Value)
        Dim point2 As New PointF(nudX2.Value, nudY2.Value)
        Dim point3 As New PointF(nudX3.Value, nudY3.Value)
        ' Calculate the area if the loop is closed
        If chkLoop.Checked Then
            ' Create the TrigLib object.
            Dim g As TrigLib.TrigLib = New TrigLib.TrigLib
            Dim area As Double
            area = g.AreaTriangle(New Point(nudX1.Value, nudY1.Value),
                           New Point(nudX2.Value, nudY2.Value),
                           New Point(nudX3.Value, nudY3.Value))
            lblArea.Text = "Area: " & CInt(area).ToString
        Else
            lblArea.Text = "Area: N/A"
        End If

        Dim point4 As New PointF(nudX4.Value, nudY4.Value)

        'curvePoints is an array of PointF objects
        Dim curvePoints() As PointF = {point1, point2, point3, point4}

        e.Graphics.DrawLines(bluePen, curvePoints)
        e.Graphics.DrawCurve(redPen, curvePoints)
    End Sub
    'Call DrawCurvePoint when pbxDrawing.Paint is called
    Private Sub pbxDrawing_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbxDrawing.Paint
        DrawCurvePoint(e)
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudX1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX1.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudX2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX2.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudX3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX3.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudX4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX4.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudY1_ValueChanged(sender As Object, e As EventArgs) Handles nudY1.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudY2_ValueChanged(sender As Object, e As EventArgs) Handles nudY2.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudY3_ValueChanged(sender As Object, e As EventArgs) Handles nudY3.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted.
    Private Sub nudY4_ValueChanged(sender As Object, e As EventArgs) Handles nudY4.ValueChanged
        pbxDrawing.Refresh()
    End Sub
    'Redraw screen when nud is adjusted and ensure max value is checked
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX5.Click
        nudX1.Value = If((nudX1.Value + 5) > 300, 300, nudX1.Value + 5)
        nudX2.Value = If((nudX2.Value + 5) > 300, 300, nudX2.Value + 5)
        nudX3.Value = If((nudX3.Value + 5) > 300, 300, nudX3.Value + 5)
        nudX4.Value = If((nudX4.Value + 5) > 300, 300, nudX4.Value + 5)
    End Sub
    'Redraw screen when nud is adjusted and ensure max value is checked
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY5.Click
        nudY1.Value = If(nudY1.Value + 5 > 300, 300, nudY1.Value + 5)
        nudY2.Value = If(nudY2.Value + 5 > 300, 300, nudY2.Value + 5)
        nudY3.Value = If(nudY3.Value + 5 > 300, 300, nudY3.Value + 5)
        nudY4.Value = If(nudY4.Value + 5 > 300, 300, nudY4.Value + 5)
    End Sub
    'Maintain original values of nud4 and revert if loop is unchecked
    Private Sub chkLoop_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoop.CheckedChanged
        If chkLoop.Checked Then
            nudOldX4 = nudX4.Value
            nudOldY4 = nudY4.Value
            nudX4.Value = nudX1.Value
            nudY4.Value = nudY1.Value
        Else
            nudX4.Value = nudOldX4
            nudY4.Value = nudOldY4
        End If
        pbxDrawing.Refresh()
    End Sub
End Class