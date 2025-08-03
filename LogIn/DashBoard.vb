Imports MySql.Data.MySqlClient

Public Class DashBoard

    Private myConnection As New MY_CONNECTION

    Private Sub ButtonTimeIn_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim currentDate = Date.Now.ToString("yyyy-MM-dd")
        Dim currentTime = Date.Now.ToString("HH:mm:ss")

        Dim employeeId = SessionManager.CurrentEmployeeId
        Dim firstName = ""
        Dim lastName = ""

        If employeeId <= 0 Then
            MessageBox.Show("Session error: Employee ID not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            myConnection.openConnection()

            ' Retrieve employee details
            Dim cmdGetEmployeeDetails As New MySqlCommand("SELECT first_name, last_name FROM users WHERE employee_id = @EMPLOYEEID", myConnection.getConnection)
            cmdGetEmployeeDetails.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            Dim readerDetails = cmdGetEmployeeDetails.ExecuteReader()
            If readerDetails.Read() Then
                firstName = readerDetails("first_name").ToString()
                lastName = readerDetails("last_name").ToString()
            End If
            readerDetails.Close()

            ' Check if there's an attendance record for today
            Dim cmdCheckAttendance As New MySqlCommand("SELECT * FROM table_attendance WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE", myConnection.getConnection)
            cmdCheckAttendance.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdCheckAttendance.Parameters.AddWithValue("@LOGDATE", currentDate)

            Dim reader = cmdCheckAttendance.ExecuteReader()

            If reader.HasRows Then
                reader.Close()
                MessageBox.Show("Attendance record found for today. You have already logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                reader.Close()
                ' It's a time in since there's no record for today
                MessageBox.Show("No attendance record found for today. Logging time in.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim cmdTimeIn As New MySqlCommand("INSERT INTO table_attendance (employee_id, firstname, lastname, LOGDATE, TIMEIN, AM_STATUS) VALUES (@EMPLOYEEID, @FIRSTNAME, @LASTNAME, @LOGDATE, @TIMEIN, 'In')", myConnection.getConnection)
                cmdTimeIn.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
                cmdTimeIn.Parameters.AddWithValue("@FIRSTNAME", firstName)
                cmdTimeIn.Parameters.AddWithValue("@LASTNAME", lastName)
                cmdTimeIn.Parameters.AddWithValue("@LOGDATE", currentDate)
                cmdTimeIn.Parameters.AddWithValue("@TIMEIN", currentTime)

                If cmdTimeIn.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Time In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadAttendanceData() ' Refresh attendance data
                Else
                    MessageBox.Show("Failed to Time In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub

    Private Sub ButtonTimeOut_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim currentDate = Date.Now.ToString("yyyy-MM-dd")
        Dim currentTime = Date.Now.ToString("HH:mm:ss")
        Dim employeeId = SessionManager.CurrentEmployeeId

        If employeeId <= 0 Then
            MessageBox.Show("Session error: Employee ID not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            myConnection.openConnection()

            ' Check if the user has clocked in today
            Dim cmdCheckTimeIn As New MySqlCommand("SELECT * FROM table_attendance WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE AND TIMEIN IS NOT NULL", myConnection.getConnection)
            cmdCheckTimeIn.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdCheckTimeIn.Parameters.AddWithValue("@LOGDATE", currentDate)

            Dim reader = cmdCheckTimeIn.ExecuteReader()

            If Not reader.HasRows Then
                reader.Close()
                MessageBox.Show("You need to Time In first before you can Time Out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            reader.Close()

            ' Check if there's already a time out record for today
            Dim cmdCheckTimeOut As New MySqlCommand("SELECT * FROM table_attendance WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE AND TIMEOUT IS NULL", myConnection.getConnection)
            cmdCheckTimeOut.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdCheckTimeOut.Parameters.AddWithValue("@LOGDATE", currentDate)

            reader = cmdCheckTimeOut.ExecuteReader()

            If reader.HasRows Then
                reader.Close()
                MessageBox.Show("You have already logged out today.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            reader.Close()

            ' Proceed to log out since there is a time in and no time out yet
            Dim cmdTimeOut As New MySqlCommand("UPDATE table_attendance SET TIMEOUT = @TIMEOUT, PM_STATUS = 'Out' WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE", myConnection.getConnection)
            cmdTimeOut.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdTimeOut.Parameters.AddWithValue("@TIMEOUT", currentTime)
            cmdTimeOut.Parameters.AddWithValue("@LOGDATE", currentDate)

            Dim rowsAffected As Integer = cmdTimeOut.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Successfully Time Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadAttendanceData() ' Refresh attendance data
            Else
                MessageBox.Show("Failed to Time Out. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub

    ' Function to load attendance data
    Private Sub LoadAttendanceData()
        Dim employeeId As Integer = SessionManager.CurrentEmployeeId

        Try
            myConnection.openConnection()

            Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS FullName, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, " &
                                  "TIME_FORMAT(TIMEDIFF(TIMEOUT, TIMEIN), '%H:%i:%s') AS TotalWorkHours " &
                                  "FROM table_attendance WHERE employee_id = @EMPLOYEEID"
            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            cmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                DataGridView1.DataSource = Nothing
            End If
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub

    Private Sub Employee_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SessionManager.CurrentEmployeeId > 0 Then
            LoadAttendanceData() ' Load attendance data for the logged-in user
        Else
            MessageBox.Show("Please log in to view your attendance records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Hide() ' Hide the form or redirect to login
        End If
    End Sub

    ' Logout method


    ' Calculate total work hours and display in a message box
    Private Sub CalculateTotalWorkHours()
        Dim employeeId As Integer = SessionManager.CurrentEmployeeId
        Dim totalDuration As TimeSpan = TimeSpan.Zero

        Try
            myConnection.openConnection()

            Dim cmd As New MySqlCommand("SELECT TIMEIN, TIMEOUT FROM table_attendance WHERE employee_id = @EMPLOYEEID", myConnection.getConnection())
            cmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                Dim timeInString As String = reader("TIMEIN").ToString()
                Dim timeOutString As String = reader("TIMEOUT").ToString()

                If Not String.IsNullOrEmpty(timeInString) AndAlso Not String.IsNullOrEmpty(timeOutString) Then
                    Dim timeIn As TimeSpan = TimeSpan.Parse(timeInString)
                    Dim timeOut As TimeSpan = TimeSpan.Parse(timeOutString)
                    Dim duration As TimeSpan = timeOut - timeIn

                    totalDuration += duration
                End If
            End While
            reader.Close()

            MessageBox.Show("Total Work Hours: " & totalDuration.ToString(), "Total Work Hours", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred while calculating total work hours: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub
    ' Button to calculate total work hours
    Private Sub btnCalculateHours_Click(sender As Object, e As EventArgs)

        LogIn.Show()

        Hide()

    End Sub

    ' On form load, load attendance data and start timer



    Private Sub LoadUserControl(ByVal userControl As UserControl)
        contentPanel.Controls.Clear()            ' Clear existing controls in the panel
        userControl.Dock = DockStyle.Fill         ' Set the control to fill the panel
        contentPanel.Controls.Add(userControl)    ' Add the control to the panel
    End Sub

    ' Update the label with the current time every second


    ' Button to switch to Form1 (Logout)

    ' Logout method
    Private Sub Logout()
        SessionManager.CurrentEmployeeId = 0 ' Clear the session
        ClearData() ' Clear data before switching
        Dim loginForm As New LogIn() ' Assuming you have a LoginForm for login
        loginForm.Show()
        Me.Hide() ' Hide the attendance form

    End Sub

    ' Clear DataGridView and other fields only when logging out
    Private Sub ClearData()
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SessionManager.CurrentEmployeeId = 0 ' Clear the session
        ClearData() ' Clear data before switching
        Dim loginForm As New LogIn() ' Assuming you have a LoginForm for login
        loginForm.Show()
        Me.Close() ' C
        contentPanel.Hide()
        PictureBox1.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        LoadUserControl(New UserControl1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadUserControl(New UserControl4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        LoadUserControl(New UserControl3)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        LoadUserControl(New UserControl2)
    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        LoadUserControl(New UserControl7)
    End Sub




End Class
