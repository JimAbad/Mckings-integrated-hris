Imports MySql.Data.MySqlClient

Public Class MY_CONNECTION

    ' First, download the MySQL connector & add it to your project
    ' https://dev.mysql.com/downloads/connector/net/8.0.html
    ' Open XAMPP
    ' Create the MySQL database using phpMyAdmin
    ' Create the database and name it "vbnet_users_db"
    ' Create a table and name it "users"
    ' Create the connection

    Private connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnet_users_db")

    ' Return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' Open the connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    ' Close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

End Class