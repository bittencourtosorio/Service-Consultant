Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class TypeDB
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private strSQL As String
    Private creation As Integer
    Sub filterrecords(ByVal search As String)
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            strSQL = "SELECT type_name as Type FROM type ORDER BY type_name"

            Dim dt As New DataTable
            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            type_dgv.DataSource = dt
            conexao.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()

        End Try

    End Sub
    Private Sub TypeDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")

    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            strSQL = "SELECT type_name as Type FROM type ORDER BY type_name"

            Dim dt As New DataTable
            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            type_dgv.DataSource = dt
            conexao.Open()
            type_txt.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()

        End Try
    End Sub

    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            strSQL = "INSERT INTO type (type_name) VALUES (@typename)"
            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@typename", type_txt.Text)

            Try
                Dim queryString As String
                queryString = " SELECT * FROM type WHERE type_name = '" + type_txt.Text + "'"

                Dim command As New MySqlCommand(queryString, conexao)
                reader = command.ExecuteReader()

                If reader.Read() Then
                    MessageBox.Show("Type already exists!")
                    type_txt.Text = ""
                    reader.Close()
                    conexao.Close()
                Else
                    creation = 1
                    GoTo created
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                reader.Close()

            End Try
created:
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            If creation = 1 Then
                MessageBox.Show("Type successfully created!")
                comando.ExecuteNonQuery()
            End If
            filterrecords("")
            type_txt.Text = ""
            creation = 0
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Hide()
        MachineDB.Show()
    End Sub
End Class