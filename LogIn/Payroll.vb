Imports MySql.Data.MySqlClient

Public Class Form1

    Private myConnection As New MY_CONNECTION

    ' Load payroll data
    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayrollData()
    End Sub

    ' Load payroll data from the database
    Private Sub LoadPayrollData()
        Try
            ' Define the hourly rate
            Dim hourlyRate As Decimal = 100 ' Set your desired hourly rate here

            ' Corrected SQL query
            Dim query As String = "SELECT employee_id, firstname, lastname, LOGDATE, " &
                              "TIME_FORMAT(TIMEDIFF(TIMEOUT, TIMEIN), '%H:%i:%s') AS TotalWorkHours, " &
                              "@HourlyRate AS hourly_rate, " &
                              "(TIME_TO_SEC(TIMEDIFF(TIMEOUT, TIMEIN)) / 3600) * @HourlyRate AS TotalPay " &
                              "FROM table_attendance " &
                              "WHERE TIMEOUT IS NOT NULL"

            ' Set up MySQL command
            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            cmd.Parameters.AddWithValue("@HourlyRate", hourlyRate)

            ' Fetch data into a DataTable
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the data to the DataGridView
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                DataGridView1.DataSource = Nothing
                MessageBox.Show("No payroll records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Adjust DataGridView columns
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error loading payroll data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Generate Payroll Report
    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim totalPayroll As Decimal = 0

        Try
            myConnection.openConnection()

            Dim query As String = "SELECT SUM((TIME_TO_SEC(TIMEDIFF(TIMEOUT, TIMEIN)) / 3600) * hourly_rate) AS TotalPayroll " &
                                  "FROM table_attendance INNER JOIN users ON table_attendance.employee_id = users.employee_id " &
                                  "WHERE TIMEOUT IS NOT NULL"

            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                totalPayroll = Convert.ToDecimal(result)
            End If

            MessageBox.Show($"Total Payroll for all employees: {totalPayroll:C2}", "Payroll Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating payroll report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            myConnection.closeConnection()
        End Try
    End Sub

End Class
