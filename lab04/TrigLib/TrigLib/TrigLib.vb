'TODO COMMENT
Imports System.Drawing
Public Class TrigLib
    Dim p1 As Point
    'TODO COMMENT
    Private Function Distance(ByVal P1 As Point, ByVal P2 As Point) As Single
        Return CSng(Math.Sqrt((P1.X - P2.X) ^ 2 + (P1.Y - P2.Y) ^ 2))
    End Function
    'TODO COMMENT
    Public Function AreaTriangle(ByVal P1 As Point, ByVal P2 As Point, ByVal P3 As Point) As Double
        Dim sideA As Single
        Dim sideB As Single
        Dim sideC As Single

        sideA = Distance(P1, P2)
        sideB = Distance(P1, P3)
        sideC = Distance(P2, P3)

        Dim s As Single

        s = (sideA + sideB + sideC) / CSng(2.0)

        Return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC))
    End Function
End Class
