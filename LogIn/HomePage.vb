Public Class HomePage
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        LogIn.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Registration.Show()
        Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PrivacyPolicy.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TermsOfService.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Registration.Show()
        Me.Hide()
    End Sub


End Class
