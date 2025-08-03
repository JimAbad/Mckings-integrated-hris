Imports MySql.Data.MySqlClient

Public Class Registration

    ' Register Button Click Event
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim fname As String = TextBoxFirstname.Text
        Dim lname As String = TextBoxLastname.Text
        Dim username As String = TextBoxUsername.Text
        Dim email As String = TextBoxEmail.Text
        Dim houseNo As String = TextBoxHouseNo.Text
        Dim street As String = TextBoxStreet.Text
        Dim barangay As String = TextBoxBarangay.Text
        Dim city As String = TextBoxCity.Text
        Dim province As String = TextBoxProvince.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxConfirmPassword.Text
        Dim jobTitle As String = ComboBoxJobTitle.SelectedItem?.ToString()

        ' Concatenate the address fields
        Dim fullAddress As String = houseNo & ", " & street & ", " & barangay & ", " & city & ", " & province

        ' Validate inputs
        If String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname) Or
            String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Or
            String.IsNullOrEmpty(houseNo) Or String.IsNullOrEmpty(street) Or String.IsNullOrEmpty(barangay) Or
            String.IsNullOrEmpty(city) Or String.IsNullOrEmpty(province) Then
            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not String.Equals(password, cpassword) Then
            MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernameExist(username) Then
            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf String.IsNullOrEmpty(jobTitle) Then
            MessageBox.Show("Please select a Job Title", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            addNewEmployee(username, email, password, fname, lname, fullAddress, jobTitle)
        End If
    End Sub

    ' Function to check if username exists in the database
    Public Function usernameExist(ByVal username As String) As Boolean
        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM users WHERE username = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)

        Return table.Rows.Count > 0
    End Function

    ' Function to add new employee to the database
    Private Sub addNewEmployee(ByVal username As String, ByVal email As String, ByVal password As String, ByVal firstName As String, ByVal lastName As String, ByVal fullAddress As String, ByVal jobTitle As String)
        Dim con As New MY_CONNECTION()
        Dim command As New MySqlCommand("INSERT INTO users(username, email, password, first_name, last_name, address, job_title) " &
                                         "VALUES (@usn, @mail, @pass, @fn, @ln, @addr, @jobTitle)", con.getConnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstName
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName
        command.Parameters.Add("@addr", MySqlDbType.Text).Value = fullAddress
        command.Parameters.Add("@jobTitle", MySqlDbType.VarChar).Value = jobTitle

        con.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Something Happened", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        con.closeConnection()
    End Sub

    ' Close Button Click Event
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    ' Form Load Event (Populate ComboBox with Job Titles)
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with Job Titles
        ComboBoxJobTitle.Items.Clear()
        ComboBoxJobTitle.Items.Add("Chef")
        ComboBoxJobTitle.Items.Add("Crew")
        ComboBoxJobTitle.Items.Add("Cashier")
        ComboBoxJobTitle.SelectedIndex = -1 ' Default to no selection
    End Sub

    ' Reset Button Click Event
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear all input fields
        TextBoxFirstname.Clear()
        TextBoxLastname.Clear()
        TextBoxUsername.Clear()
        TextBoxEmail.Clear()
        TextBoxPassword.Clear()
        TextBoxConfirmPassword.Clear()
        TextBoxCity.Clear()
        TextBoxBarangay.Clear()
        TextBoxStreet.Clear()
        TextBoxHouseNo.Clear()
        TextBoxProvince.Clear()

        ' Clear ComboBox (reset to default)
        ComboBoxJobTitle.SelectedIndex = -1
    End Sub
End Class
