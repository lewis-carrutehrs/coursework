Public Class MainMenu
    'Play button 
    Private Sub PLAY_MouseEnter(sender As Object, e As EventArgs) Handles PLAY.MouseEnter
        PLAY.ForeColor = Color.Black
    End Sub
    Private Sub PLAY_MouseLeave(sender As Object, e As EventArgs) Handles PLAY.MouseLeave
        PLAY.ForeColor = Color.DarkRed
    End Sub
    Private Sub PLAY_Click(sender As Object, e As EventArgs) Handles PLAY.Click
        SelectGameMode.Show()
        Me.Hide()
    End Sub
    'Exit button
    Private Sub ExitGame_MouseEnter(sender As Object, e As EventArgs) Handles ExitGame.MouseEnter
        ExitGame.ForeColor = Color.Black
    End Sub
    Private Sub ExitGame_MouseLeave(sender As Object, e As EventArgs) Handles ExitGame.MouseLeave
        ExitGame.ForeColor = Color.DarkRed
    End Sub
    Private Sub ExitGame_Click(sender As Object, e As EventArgs) Handles ExitGame.Click
        Me.Close()
    End Sub
    'How to play button
    Private Sub HTP_MouseEnter(sender As Object, e As EventArgs) Handles HTP.MouseEnter
        HTP.ForeColor = Color.Black
    End Sub
    Private Sub HTP_MouseLeave(sender As Object, e As EventArgs) Handles HTP.MouseLeave
        HTP.ForeColor = Color.DarkRed
    End Sub
    Private Sub HTP_Click(sender As Object, e As EventArgs) Handles HTP.Click
        HowToPlay.Show()
        Me.Hide()
    End Sub
    'Settings button
    Private Sub Settings_MouseEnter(sender As Object, e As EventArgs) Handles Settings.MouseEnter
        Settings.ForeColor = Color.Black
    End Sub
    Private Sub Settings_MouseLeave(sender As Object, e As EventArgs) Handles Settings.MouseLeave
        Settings.ForeColor = Color.DarkRed
    End Sub
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Settingsscreen.Show()
        Me.Hide()
    End Sub




End Class
