Public Class SelectGameMode
    Private Sub return_to_menu_Click(sender As Object, e As EventArgs) Handles return_to_menu.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub GM1_Click(sender As Object, e As EventArgs) Handles GM1.Click
        Me.Close()
        PlayingScreen.Show()
    End Sub

End Class