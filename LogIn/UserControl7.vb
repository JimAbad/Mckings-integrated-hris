Imports MySql.Data.MySqlClient

Public Class UserControl7
    Public CurrentUsername As String

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(SessionManager.CurrentUsername) Then
            MessageBox.Show("No user is logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            Return
        End If

        CurrentUsername = SessionManager.CurrentUsername
        LoadUserData()

        ' Set all textboxes to read-only
        TextBoxFirstName.ReadOnly = True
        TextBoxLastName.ReadOnly = True
        TextBoxEmail.ReadOnly = True
        TextBoxAddress.ReadOnly = True
        TextBoxJobTitle.ReadOnly = True


    End Sub

    Private Sub LoadUserData()
        Dim con As New MY_CONNECTION()
        Dim command As New MySqlCommand("SELECT * FROM users WHERE username = @username", con.getConnection())
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = CurrentUsername

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Fill basic information
                TextBoxFirstName.Text = table.Rows(0)("first_name").ToString()
                TextBoxLastName.Text = table.Rows(0)("last_name").ToString()
                TextBoxEmail.Text = table.Rows(0)("email").ToString()
                TextBoxAddress.Text = table.Rows(0)("address").ToString()
                TextBoxJobTitle.Text = table.Rows(0)("job_title").ToString()
            Else
                MessageBox.Show("User data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub


End Class