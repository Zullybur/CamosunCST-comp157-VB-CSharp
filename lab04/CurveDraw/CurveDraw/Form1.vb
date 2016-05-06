Public Class Form1

    Public Sub DrawCurvePoint(ByVal e As PaintEventArgs)

        ' The bluePen draws the straight lines.
        Dim bluePen As New Pen(Color.Navy, 2)

        ' The redPen draws the curves around the lines.
        Dim redPen As New Pen(Color.Red, 2)

        Dim point1 As New PointF(nudX1.Value, nudY1.Value)
        Dim point2 As New PointF(nudX2.Value, nudY2.Value)
        Dim point3 As New PointF(nudX3.Value, nudY3.Value)

        ' Make the shape closed by making the last point the same as the first point. 
        If chkLoop.Checked Then
            nudX4.Value = nudX1.Value
            nudY4.Value = nudY1.Value
        End If

        Dim point4 As New PointF(nudX4.Value, nudY4.Value)

        'curvePoints is an array of PointF objects
        Dim curvePoints() As PointF = {point1, point2, point3, point4}

        e.Graphics.DrawLines(bluePen, curvePoints)

        e.Graphics.DrawCurve(redPen, curvePoints)

    End Sub

    Private Sub pbxDrawing_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbxDrawing.Paint
        DrawCurvePoint(e)
    End Sub
    Private Sub nudX1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudY1.ValueChanged, nudX1.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudY1.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX2.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudY2.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX3.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudY3.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudX4.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub nudX8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudY4.ValueChanged
        pbxDrawing.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX5.Click
        nudX1.Value += 5
        nudX2.Value += 5
        nudX3.Value += 5
        nudX4.Value += 5
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY5.Click
        nudY1.Value += 5
        nudY2.Value += 5
        nudY3.Value += 5
        nudY4.Value += 5
    End Sub
End Class
