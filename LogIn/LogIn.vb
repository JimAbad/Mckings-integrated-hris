Imports MySql.Data.MySqlClient

Public Class LogIn
    Private myConnection As New MY_CONNECTION()

    ' Handle TextBox1 Enter Event (Username)
    Private Sub TextBox1_TextChanged_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text.Trim().ToLower() = "username" Or TextBox1.Text.Trim() = "" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    ' Handle TextBox1 Leave Event (Username)
    Private Sub TextBox1_TextChanged_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text.Trim().ToLower() = "username" Or TextBox1.Text.Trim() = "" Then
            TextBox1.Text = "username"
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub

    ' Handle TextBox2 Enter Event (Password)
    Private Sub TextBox2_TextChanged_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text.Trim().ToLower() = "password" Or TextBox2.Text.Trim() = "" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    ' Handle TextBox2 Leave Event (Password)
    Private Sub TextBox2_TextChanged_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text.Trim().ToLower() = "password" Or TextBox2.Text.Trim() = "" Then
            TextBox2.Text = "password"
            TextBox2.ForeColor = Color.DarkGray
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    ' Handle Login Button Click Event
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Verify login credentials
        Dim employeeId As Integer = VerifyLogin(username, password)
        If employeeId > 0 Then
            ' The VerifyLogin method already sets the SessionManager values
            If SessionManager.CurrentEmployeeRole = "admin" Then
                Dim adminDashboard As New AdminDashboard()
                adminDashboard.Show()
            Else
                Dim userDashboard As New DashBoard()
                userDashboard.Show()
            End If

            ' Hide the login form
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ' Verify login credentials and retrieve employee ID, full name, and role
    Private Function VerifyLogin(username As String, password As String) As Integer
        Dim employeeId As Integer = 0
        Dim fullName As String = ""
        Dim role As String = ""

        Try
            myConnection.openConnection()

            ' Use parameterized query to prevent SQL injection
            Dim cmd As New MySqlCommand("SELECT employee_id, first_name, last_name, role FROM users WHERE username = @username AND password = @password", myConnection.getConnection())
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader = cmd.ExecuteReader()
            If reader.Read() Then
                employeeId = Convert.ToInt32(reader("employee_id"))
                role = reader("role").ToString()
                fullName = $"{reader("first_name")} {reader("last_name")}"
            End If
            reader.Close()

            ' Store the employee's details and role in the session
            SessionManager.CurrentEmployeeId = employeeId
            SessionManager.CurrentEmployeeName = fullName
            SessionManager.CurrentEmployeeRole = role
            SessionManager.CurrentUsername = username  ' Add this line

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try

        Return employeeId
    End Function

    ' Open Registration Form when the user clicks on the "Register" link


    ' Optional: Handle form load event (if necessary)


    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim registerForm As New Registration
        registerForm.Show()
        Hide()
    End Sub

    Friend Shared Function My() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles S.Click
        Dim homePageForm As New HomePage()

        ' Show the HomePage form and hide the current form
        homePageForm.Show()
        Me.Hide()
    End Sub


    Private Function ValidateLogin(username As String, password As String) As Boolean
        ' Assuming you have a database table `users` with columns `username` and `password`
        Dim con As New MY_CONNECTION()
        Dim command As New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", con.getConnection())
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        ' Return true if a record was found (valid login)
        Return table.Rows.Count > 0
    End Function

End Class
