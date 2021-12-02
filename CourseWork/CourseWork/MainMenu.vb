Public Class MainMenu
    Private Sub CLOSE_Click(sender As Object, e As EventArgs) Handles ExitGame.Click
        Me.Close()
    End Sub
    Private Sub PLAY_Click(sender As Object, e As EventArgs) Handles PLAY.Click
        SelectGameMode.Show()
        Me.Hide()
    End Sub
    Private Sub HTP_Click(sender As Object, e As EventArgs) Handles HTP.Click
        HowToPlay.Show()
        Me.Hide()

    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Settingsscreen.Show()
        Me.Hide()
    End Sub
End Class
