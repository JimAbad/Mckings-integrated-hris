Public Class About
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Registration.Show()
        Me.Hide()
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        HomePage.Show()
    End Sub
End Class
