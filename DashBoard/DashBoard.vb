Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private myConnection As New MY_CONNECTION

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")
        Dim currentTime As String = Date.Now.ToString("HH:mm:ss")

        Dim employeeId As Integer = SessionManager.CurrentEmployeeId
        Dim firstName As String = ""
        Dim lastName As String = ""

        Try
            myConnection.openConnection()

            ' Retrieve employee details
            Dim cmdGetEmployeeDetails As New MySqlCommand("SELECT first_name, last_name FROM users WHERE employee_id = @EMPLOYEEID", myConnection.getConnection())
            cmdGetEmployeeDetails.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            Dim readerDetails = cmdGetEmployeeDetails.ExecuteReader()
            If readerDetails.Read() Then
                firstName = readerDetails("first_name").ToString()
                lastName = readerDetails("last_name").ToString()
            End If
            readerDetails.Close()

            ' Check if there's an attendance record for today
            Dim cmdCheckAttendance As New MySqlCommand("SELECT * FROM table_attendance WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE", myConnection.getConnection())
            cmdCheckAttendance.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdCheckAttendance.Parameters.AddWithValue("@LOGDATE", currentDate)

            Dim reader = cmdCheckAttendance.ExecuteReader()

            If reader.HasRows Then
                reader.Close()
                ' It's a time out since there's already a record for today
                MessageBox.Show("Attendance record found for today. Logging time out.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim cmdTimeOut As New MySqlCommand("UPDATE table_attendance SET TIMEOUT = @TIMEOUT, PM_STATUS = 'Out' WHERE employee_id = @EMPLOYEEID AND LOGDATE = @LOGDATE", myConnection.getConnection())
                cmdTimeOut.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
                cmdTimeOut.Parameters.AddWithValue("@TIMEOUT", currentTime)
                cmdTimeOut.Parameters.AddWithValue("@LOGDATE", currentDate)

                If cmdTimeOut.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Successfully Time Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadAttendanceData() ' Refresh attendance data
                Else
                    MessageBox.Show("Failed to Time Out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                reader.Close()
                ' It's a time in since there's no record for today
                MessageBox.Show("No attendance record found for today. Logging time in.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim cmdTimeIn As New MySqlCommand("INSERT INTO table_attendance (employee_id, firstname, lastname, LOGDATE, TIMEIN, AM_STATUS) VALUES (@EMPLOYEEID, @FIRSTNAME, @LASTNAME, @LOGDATE, @TIMEIN, 'In')", myConnection.getConnection())
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

                Dim timeIn As DateTime
                Dim timeOut As DateTime

                If DateTime.TryParseExact(timeInString, "HH:mm:ss", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, timeIn) Then
                    If Not String.IsNullOrEmpty(timeOutString) AndAlso DateTime.TryParseExact(timeOutString, "HH:mm:ss", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, timeOut) Then
                        If timeOut > timeIn Then
                            totalDuration += (timeOut - timeIn)
                        End If
                    End If
                End If
            End While

            reader.Close()

            Dim totalHours As Integer = totalDuration.Hours + (totalDuration.Days * 24)
            Dim formattedDuration As String = String.Format("{0:D2}:{1:D2}:{2:D2}", totalHours, totalDuration.Minutes, totalDuration.Seconds)
            MessageBox.Show($"Total Work Duration: {formattedDuration}", "Work Hours", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub



    ' Button to calculate total work hours
    '    Private Sub btnCalculateHours_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '       CalculateTotalWorkHours()
    '    End Sub

    ' On form load, load attendance data and start timer


    ' Update the label with the current time every second


    ' Button to switch to Form1 (Logout)


    '

    ' Clear DataGridView and other fields only when logging out

End Class
