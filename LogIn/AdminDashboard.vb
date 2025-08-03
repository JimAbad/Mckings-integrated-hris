Imports MySql.Data.MySqlClient

Public Class AdminDashBoard

    Private myConnection As New MY_CONNECTION
    Private WithEvents TimerDateTime As New Timer()

    ' Load attendance data based on specified parameters
    Private Sub LoadAttendanceData(Optional startDate As DateTime = Nothing, Optional endDate As DateTime = Nothing, Optional employeeName As String = Nothing)
        Try
            myConnection.openConnection()

            ' Base query for attendance records
            Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS FullName, " &
                                  "LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, " &
                                  "TIME_FORMAT(TIMEDIFF(TIMEOUT, TIMEIN), '%H:%i:%s') AS TotalWorkHours " &
                                  "FROM table_attendance"

            ' Add filters based on provided parameters
            Dim filters As New List(Of String)

            If Not String.IsNullOrEmpty(employeeName) Then
                filters.Add("CONCAT(firstname, ' ', lastname) LIKE @EmployeeName")
            End If

            If startDate <> Nothing AndAlso endDate <> Nothing Then
                filters.Add("LOGDATE BETWEEN @StartDate AND @EndDate")
            End If

            If filters.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", filters)
            End If

            Dim cmd As New MySqlCommand(query, myConnection.getConnection())

            ' Add parameters for the date range and employee name if applicable
            If Not String.IsNullOrEmpty(employeeName) Then
                cmd.Parameters.AddWithValue("@EmployeeName", "%" & employeeName & "%")
            End If

            If startDate <> Nothing AndAlso endDate <> Nothing Then
                cmd.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd"))
            End If

            ' Create DataAdapter and DataTable to store the results
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Fill the table with data from the query
            adapter.Fill(table)

            ' Check if there are any records and display in DataGridView
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                DataGridView1.DataSource = Nothing
                MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub

    ' Filter records based on the selected date range and employee name
    Private Sub btnFilterByDateAndName_Click(sender As Object, e As EventArgs) Handles btnFilterByDateAndName.Click
        Dim startDate = DateTimePickerStart.Value.Date ' Ensure we get just the date part
        Dim endDate = DateTimePickerEnd.Value.Date     ' Ensure we get just the date part

        ' Ensure end date is not earlier than start date
        If endDate < startDate Then
            MessageBox.Show("End date cannot be earlier than start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim employeeName = txtEmployeeNameFilter.Text.Trim() ' TextBox for employee name filter

        LoadAttendanceData(startDate, endDate, employeeName) ' Load data with both filters applied
    End Sub

    Private Sub InitializeDateTime()
        TimerDateTime.Interval = 1000 ' Update every second
        TimerDateTime.Enabled = True

        LabelDate.AutoSize = True
        LabelTime.AutoSize = True

        UpdateDateTime()
    End Sub

    Private Sub TimerDateTime_Tick(sender As Object, e As EventArgs) Handles TimerDateTime.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        LabelDate.Text = DateTime.Now.ToString("MMMM dd, yyyy")
        LabelTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDateTime()

        DateTimePickerStart.Value = DateTime.Now.Date  ' Set to today's date by default 
        DateTimePickerEnd.Value = DateTime.Now.Date    ' Set to today's date by default

        DateTimePickerStart.Format = DateTimePickerFormat.Short
        DateTimePickerEnd.Format = DateTimePickerFormat.Short

        DataGridView1.DataSource = Nothing  ' Ensure no data is shown initially
    End Sub

    Protected Overrides Sub OnHandleDestroyed(e As EventArgs)
        TimerDateTime.Enabled = False
        TimerDateTime.Dispose()
        MyBase.OnHandleDestroyed(e)
    End Sub

    Private Sub LoadUserControl(ByVal userControl As UserControl)
        contentPanel.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(userControl)
    End Sub

    Private Sub Payroll_Click(sender As Object, e As EventArgs) Handles Payroll.Click
        LoadUserControl(New UserControl5)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadUserControl(New UserControl6)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LogIn.Show()
        Me.Hide()
    End Sub
End Class