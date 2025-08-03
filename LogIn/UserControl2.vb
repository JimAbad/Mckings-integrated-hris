Imports MySql.Data.MySqlClient

Public Class UserControl2

    Private myConnection As New MY_CONNECTION

    ' Method to load attendance data for the current employee
    Private Sub LoadAttendanceData()
        ' Assuming SessionManager.CurrentEmployeeId is already set
        Dim employeeId As Integer = SessionManager.CurrentEmployeeId

        ' Make sure that the employee ID is valid
        If employeeId <= 0 Then
            MessageBox.Show("Invalid Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            ' Open the database connection
            myConnection.openConnection()

            ' SQL query to fetch the attendance data for the specific employee
            Dim query As String = "SELECT CONCAT(firstname, ' ', lastname) AS FullName, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, " &
                                  "TIME_FORMAT(TIMEDIFF(TIMEOUT, TIMEIN), '%H:%i:%s') AS TotalWorkHours " &
                                  "FROM table_attendance WHERE employee_id = @EMPLOYEEID"

            ' Create the MySQL command
            Dim cmd As New MySqlCommand(query, myConnection.getConnection())
            cmd.Parameters.AddWithValue("@EMPLOYEEID", employeeId)

            ' Create an adapter to fill the DataTable
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Fill the DataTable with data from the database
            adapter.Fill(table)

            ' Bind the DataTable to the DataGridView if there are records
            If table.Rows.Count > 0 Then
                DataGridView1.DataSource = table
            Else
                DataGridView1.DataSource = Nothing ' No data found
            End If

            ' Automatically adjust the column width based on the data
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            ' Catch any errors and display a message
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Always close the database connection after use
            myConnection.closeConnection()
        End Try
    End Sub

    ' This event is triggered when the UserControl is loaded (or shown) in your form
    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the attendance data when the UserControl is loaded
        LoadAttendanceData()
    End Sub

End Class
