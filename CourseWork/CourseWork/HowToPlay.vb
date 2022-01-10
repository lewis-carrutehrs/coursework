Public Class HowToPlay
    Private Sub return_to_menu_Click(sender As Object, e As EventArgs) Handles return_to_menu.Click
        Me.Close()


    End Sub

    Private Sub HowToPlay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
    End Sub


End Class