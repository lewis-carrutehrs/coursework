Public Class targets_A
    Dim posx As Integer 'x and y coordinates 
    Dim posy As Integer

    Public Sub New() 'This will randomize the x and y coordantates of the target when created
        posx = (475) * Rnd()
        Randomize()
        posy = (250) * Rnd()
    End Sub

    Public Sub draw(e As PaintEventArgs) 'Draws the target
        Dim brush As New SolidBrush(Color.Red)
        e.Graphics.FillEllipse(brush, posx, posy, 25, 25)

    End Sub
    Public Function checkclick(mposx As Integer, mposy As Integer)
        Dim hit As Boolean = False

        Return hit
    End Function

End Class
