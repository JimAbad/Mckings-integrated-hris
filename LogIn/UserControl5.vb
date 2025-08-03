Imports MySql.Data.MySqlClient

Public Class UserControl5
    Private myConnection As New MY_CONNECTION()

    Private Sub btnGeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        Dim employeeId As Integer = 0
        Dim startDate As DateTime = dtpStartDate.Value ' Get start date from DateTimePicker
        Dim endDate As DateTime = dtpEndDate.Value ' Get end date from DateTimePicker

        ' Validate date range
        If startDate > endDate Then
            MessageBox.Show("Start date must be before or equal to end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim employeeName As String = txtEmployeeSearch.Text.Trim()
        Dim addressFilter As String = txtAddressFilter.Text.Trim() ' Get address filter from a TextBox

        If String.IsNullOrEmpty(employeeName) Then
            MessageBox.Show("Please enter an employee name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            myConnection.openConnection()

            ' Get Employee ID, Name, and Job Title with Address Filter
            Dim cmdSearchEmployee As New MySqlCommand("SELECT employee_id, first_name, last_name, job_title FROM users WHERE CONCAT(first_name, ' ', last_name) LIKE @Name AND address LIKE @Address", myConnection.getConnection())
            cmdSearchEmployee.Parameters.AddWithValue("@Name", "%" & employeeName & "%")
            cmdSearchEmployee.Parameters.AddWithValue("@Address", "%" & addressFilter & "%") ' Add address filter

            Dim readerEmployee = cmdSearchEmployee.ExecuteReader()
            If readerEmployee.Read() Then
                employeeId = readerEmployee("employee_id")
                Dim jobTitle As String = readerEmployee("job_title")
                txtEmployeeName.Text = $"{readerEmployee("first_name")} {readerEmployee("last_name")}"
                txtEmployeeId.Text = employeeId.ToString()

                ' Display the job title in the TextBox
                txtJobTitle.Text = jobTitle

                readerEmployee.Close() ' Close the reader after use

                ' Load Attendance Data for the selected date range
                LoadAttendanceData(employeeId, startDate, endDate, jobTitle)

            Else
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub
    Private Sub LoadAttendanceData(employeeId As Integer, startDate As DateTime, endDate As DateTime, jobTitle As String)
        Try
            ' SQL command to fetch attendance records for the specified employee and date range
            Dim cmdGetAttendance As New MySqlCommand("SELECT LOGDATE, TIMEIN, TIMEOUT FROM table_attendance WHERE employee_id = @EMPLOYEEID AND LOGDATE BETWEEN @StartDate AND @EndDate", myConnection.getConnection())
            cmdGetAttendance.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmdGetAttendance.Parameters.AddWithValue("@StartDate", startDate)
            cmdGetAttendance.Parameters.AddWithValue("@EndDate", endDate)

            Dim adapter As New MySqlDataAdapter(cmdGetAttendance)
            Dim attendanceTable As New DataTable()
            adapter.Fill(attendanceTable)

            ' Add new columns for Regular Work Hours and Overtime Hours
            attendanceTable.Columns.Add("RegularWorkHours", GetType(Integer))
            attendanceTable.Columns.Add("OvertimeHours", GetType(Integer))

            ' Create a HashSet to track distinct work days
            Dim workDaysSet As New HashSet(Of DateTime)

            If attendanceTable.Rows.Count > 0 Then
                ' Loop through each row to calculate the regular and overtime work hours for each entry
                For Each row As DataRow In attendanceTable.Rows
                    If Not IsDBNull(row("TIMEIN")) AndAlso Not IsDBNull(row("TIMEOUT")) Then
                        Dim timeIn As DateTime = Convert.ToDateTime(row("TIMEIN"))
                        Dim timeOut As DateTime = Convert.ToDateTime(row("TIMEOUT"))

                        If timeOut > timeIn Then
                            Dim workDuration As TimeSpan = timeOut - timeIn
                            Dim workHours As Integer = Math.Floor(workDuration.TotalHours)

                            ' Calculate Regular and Overtime Hours
                            Dim regularWorkHours As Integer = Math.Min(workHours, 8)
                            Dim overtimeHours As Integer = Math.Max(workHours - 8, 0)

                            ' Update the columns in the DataTable
                            row("RegularWorkHours") = regularWorkHours
                            row("OvertimeHours") = overtimeHours

                            ' Add the work date to the HashSet to track distinct work days
                            workDaysSet.Add(Convert.ToDateTime(row("LOGDATE")))
                        End If
                    End If
                Next

                ' Bind the attendance data with the new columns to the DataGridView
                dataGridViewDailyHours.DataSource = attendanceTable

                ' Calculate Total Work Hours, Overtime, and Work Days
                CalculatePayroll(attendanceTable, jobTitle, workDaysSet.Count)

            Else
                MessageBox.Show("No attendance records found for the selected dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dataGridViewDailyHours.DataSource = Nothing ' Clear DataGridView if no records found.
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading attendance data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CalculatePayroll(attendanceTable As DataTable, jobTitle As String, totalWorkDays As Integer)
        Dim totalRegularHours As Integer = 0
        Dim totalOvertimeHours As Integer = 0

        For Each row As DataRow In attendanceTable.Rows
            If Not IsDBNull(row("RegularWorkHours")) Then
                totalRegularHours += Convert.ToInt32(row("RegularWorkHours"))
            End If
            If Not IsDBNull(row("OvertimeHours")) Then
                totalOvertimeHours += Convert.ToInt32(row("OvertimeHours"))
            End If
        Next

        ' Display Results in Textboxes
        txtTotalWorkHours.Text = $"{totalRegularHours} hours"
        txtOvertimeHours.Text = $"{totalOvertimeHours} hours"

        ' Hourly Rates and Calculations
        Dim hourlyRates As New Dictionary(Of String, Decimal) From {
            {"Crew", 37.5D},
            {"Cashier", 43.75D},
            {"Chef", 50D}
        }

        ' Define overtime rates for each job title
        Dim overtimeRates As New Dictionary(Of String, Decimal) From {
            {"Crew", 50D},
            {"Cashier", 60D},
            {"Chef", 70D}
        }

        If Not hourlyRates.ContainsKey(jobTitle) Then
            MessageBox.Show("No hourly rate defined for this job title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim hourlyRate As Decimal = hourlyRates(jobTitle)
        Dim overtimeRate As Decimal = overtimeRates(jobTitle)

        ' Calculate Base Pay and Overtime Pay
        Dim basePay As Decimal = totalRegularHours * hourlyRate
        Dim overtimePay As Decimal = totalOvertimeHours * overtimeRate

        ' Calculate Total Pay
        Dim totalPay As Decimal = basePay + overtimePay

        ' Display total work days and payroll amount
        lblTotalWorkDays.Text = $"{totalWorkDays} days"
        txtPayrollAmount.Text = $"PHP {totalPay:F2}"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the input fields
        txtEmployeeSearch.Clear()
        txtAddressFilter.Clear() ' Clear address filter text box.
        txtEmployeeName.Clear()
        txtEmployeeId.Clear()
        txtJobTitle.Clear() ' Clear the job title TextBox
        txtTotalWorkHours.Clear()
        txtOvertimeHours.Clear()
        txtPayrollAmount.Clear()

        ' Clear the DataGridView contents
        dataGridViewDailyHours.DataSource = Nothing
    End Sub

    Private Sub PayrollDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployeeSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtEmployeeSearch.AutoCompleteCustomSource = GetEmployeeNames()
    End Sub

    Private Function GetEmployeeNames() As AutoCompleteStringCollection
        Dim employeeNames As New AutoCompleteStringCollection()

        Try
            myConnection.openConnection()

            ' Adjusted SQL to filter by address if necessary.
            Dim cmd As New MySqlCommand("SELECT CONCAT(first_name, ' ', last_name) FROM users WHERE address LIKE @Address", myConnection.getConnection())
            cmd.Parameters.AddWithValue("@Address", "%" & txtAddressFilter.Text.Trim() & "%") ' Filter by address from a TextBox.

            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    employeeNames.Add(reader.GetString(0))
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try

        Return employeeNames
    End Function


    Private Sub ConfigureDataGridViewColumns()



    End Sub

    Private Sub M_Paint(sender As Object, e As PaintEventArgs) Handles M.Paint

    End Sub
End Class
