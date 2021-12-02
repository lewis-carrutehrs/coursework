Public Class SelectGameMode
    Private Sub return_to_menu_Click(sender As Object, e As EventArgs) Handles return_to_menu.Click
        Me.Close()
    End Sub
    Private Sub return_to_menu_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub
End Class