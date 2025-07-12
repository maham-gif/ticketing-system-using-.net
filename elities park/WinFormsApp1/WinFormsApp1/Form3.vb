Imports MySql.Data.MySqlClient

Public Class Form3
    ' Define the connection string
    Dim connectionString As String = "server=localhost;database=csv_db;user id=root;password=;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)

    ' Event to handle Form3 load
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Attempt to open the connection
            connection.Open()
            MessageBox.Show("Connection to the database was successful!")
            ' Close the connection after successful message
            connection.Close()
        Catch ex As MySqlException
            ' Handle any errors that may occur
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "server=localhost;database=csv_db;user id=root;password=;"
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox3.Text

        Dim query As String = "SELECT * FROM tbl_name WHERE username = @username AND password = @password"

        Using connection As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        MessageBox.Show("Login successful!")

                        ' Add code to navigate to the next form or perform other actions upon successful login
                    Else
                        MessageBox.Show("Invalid username or password")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class


