Public Class PlayingScreen
    Dim targets(3) As targets_A 'creates empty array of targets 

    Private Sub target_box_Paint(sender As Object, e As PaintEventArgs) Handles target_box.Paint
        Dim tarnum As Integer = 0
        While tarnum <> targets.Length
            targets(tarnum).draw(e)
            tarnum = tarnum + 1
        End While
    End Sub



    Private Sub PlayingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For n = 0 To targets.Length - 1
            Dim temptar As New targets_A
            targets(n) = temptar          'adds targets to array  
        Next
    End Sub

    Private Sub target_box_MouseClick(sender As Object, e As MouseEventArgs) Handles target_box.MouseClick
        Dim mposx As Integer = e.X
        Dim mposy As Integer = e.Y
        Dim hit As Boolean = False
        PlayingScreen_Load(sender, e) 'will cause all targets To refresh
        Dim index As Integer = 0
        While index <> targets.Length And hit = False
            hit = targets(index).checkclick(mposx, mposy)
            index = index + 1
        End While





    End Sub

    Private Sub PlayingScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub
End Class