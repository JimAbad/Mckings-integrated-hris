Imports MySql.Data.MySqlClient

Public Class UserControl3
    Private myConnection As New MY_CONNECTION()

    ' Load payroll data when the control is loaded
    Private Sub PayrollControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollData()
    End Sub

    ' Load payroll data from the database (only for the logged-in user)
    Private Sub LoadPayrollData()
        Dim employeeId As Integer = SessionManager.CurrentEmployeeId ' Retrieve the logged-in user ID

        If employeeId <= 0 Then
            MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Automatically set the start date (first day of current month)
        Dim startDate As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        ' Automatically set the end date (current date)
        Dim endDate As DateTime = DateTime.Now

        Try
            ' Open database connection
            myConnection.openConnection()

            ' SQL query to retrieve payroll data for the logged-in user within the current month
            Dim query As String = "SELECT table_attendance.employee_id, users.first_name, users.last_name, " &
                                  "table_attendance.LOGDATE, " &
                                  "TIME_FORMAT(TIMEDIFF(table_attendance.TIMEOUT, table_attendance.TIMEIN), '%H:%i:%s') AS TotalWorkHours " &
                                  "FROM table_attendance " &
                                  "INNER JOIN users ON table_attendance.employee_id = users.employee_id " &
                                  "WHERE table_attendance.TIMEOUT IS NOT NULL " &
                                  "AND table_attendance.employee_id = @EMPLOYEEID " &
                                  "AND table_attendance.LOGDATE BETWEEN @StartDate AND @EndDate"

            ' Execute SQL command
            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            cmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDate)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind data to DataGridView
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error loading payroll data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close database connection
            myConnection.closeConnection()
        End Try
    End Sub

    ' Generate Payroll Report
    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click
        Dim totalPayroll As Decimal = 0
        Dim totalWorkHours As Decimal = 0
        Dim totalOvertimeHours As Decimal = 0
        Dim totalWorkDays As Integer = 0 ' Variable to store total workdays
        Dim employeeId = SessionManager.CurrentEmployeeId ' Get the logged-in user ID

        ' Define hourly rates in a dictionary
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

        Dim jobTitle As String = String.Empty

        Try
            ' Open database connection
            myConnection.openConnection()

            ' Get job title from the database
            Dim jobTitleQuery As String = "SELECT job_title FROM users WHERE employee_id = @EMPLOYEEID"
            Dim jobTitleCmd As New MySqlCommand(jobTitleQuery, myConnection.getConnection())
            jobTitleCmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            ' Log the query and employee ID for debugging
            Console.WriteLine("Executing Query: " & jobTitleQuery)
            Console.WriteLine("With Parameter: @EMPLOYEEID = " & employeeId)

            ' Execute the command to get job title
            Dim jobTitleReader = jobTitleCmd.ExecuteReader()
            If jobTitleReader.Read() Then
                jobTitle = jobTitleReader("job_title").ToString() ' Correct column name, no space
                ' Log the retrieved job title for debugging
                Console.WriteLine("Retrieved Job Title: " & jobTitle)
            End If
            jobTitleReader.Close()

            ' Check if job title is valid
            If String.IsNullOrEmpty(jobTitle) OrElse Not hourlyRates.ContainsKey(jobTitle) OrElse Not overtimeRates.ContainsKey(jobTitle) Then
                MessageBox.Show("No hourly rate defined for this job title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim hourlyRate As Decimal = hourlyRates(jobTitle)
            Dim overtimeRate As Decimal = overtimeRates(jobTitle)

            ' SQL query to retrieve attendance data for payroll calculation
            Dim query = "SELECT employee_id, TIMEIN, TIMEOUT, LOGDATE " &
                        "FROM table_attendance WHERE TIMEOUT IS NOT NULL AND employee_id = @EMPLOYEEID " &
                        "AND LOGDATE BETWEEN @StartDate AND @EndDate"

            ' Execute SQL command
            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            cmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)
            cmd.Parameters.AddWithValue("@StartDate", New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)) ' First day of the month
            cmd.Parameters.AddWithValue("@EndDate", DateTime.Now) ' Current date
            Dim reader = cmd.ExecuteReader()

            ' Create a HashSet to track distinct work days
            Dim workDaysSet As New HashSet(Of DateTime)

            ' Loop through each record and calculate payroll
            While reader.Read()
                Dim timeIn As Date
                Dim timeOut As Date

                ' Safely parse TIMEIN and TIMEOUT fields
                If Not IsDBNull(reader("TIMEIN")) AndAlso Date.TryParse(reader("TIMEIN").ToString(), timeIn) AndAlso
                   Not IsDBNull(reader("TIMEOUT")) AndAlso Date.TryParse(reader("TIMEOUT").ToString(), timeOut) Then

                    ' Calculate hours worked for each entry
                    Dim workDuration = timeOut - timeIn
                    Dim workHours As Decimal = Math.Floor(workDuration.TotalHours) ' Round down to the nearest whole hour

                    ' Initialize regular and overtime hours for the day
                    Dim regularHours As Decimal = 0
                    Dim overtimeHours As Decimal = 0

                    ' If work hours are greater than 8, split into regular and overtime hours
                    If workHours > 8 Then
                        regularHours = 8
                        overtimeHours = workHours - 8 ' Overtime hours will be the remainder
                    Else
                        regularHours = workHours ' If less than or equal to 8, all hours are regular
                    End If

                    ' Accumulate the total regular hours and overtime hours
                    totalWorkHours += regularHours
                    totalOvertimeHours += overtimeHours

                    ' Calculate total payroll based on regular and overtime hours
                    totalPayroll += (regularHours * hourlyRate) + (overtimeHours * overtimeRate) ' Overtime is paid based on job-specific rate

                    ' Add the work date to the HashSet to track distinct work days
                    workDaysSet.Add(reader("LOGDATE"))
                Else
                    MessageBox.Show("Invalid TIMEIN or TIMEOUT value found. Skipping this record.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Continue While ' Skip the current record if there's an issue
                End If
            End While
            reader.Close()

            ' Set the total work days
            totalWorkDays = workDaysSet.Count

            ' Display the total payroll in TextBox
            txtTotalPayroll.Text = $"₱{totalPayroll:F2}" ' Total payroll

            ' Display the total work hours and overtime in Labels
            lblTotalWorkHours.Text = $" {totalWorkHours} hours" ' Total work hours
            lblTotalOvertimeHours.Text = $"{totalOvertimeHours} hours" ' Total overtime hours
            lblTotalWorkDays.Text = $"{totalWorkDays} days" ' Display the total work days

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error generating payroll report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close database connection
            myConnection.closeConnection()
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
