Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Users
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private comandochk As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private ch As MySqlDataReader
    Private strSQL As String
    Private chkSQL As String

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Managebtn_Click(sender As Object, e As EventArgs) Handles Managebtn.Click
        Me.Hide()
        ManageUser.Show()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim pass1 As String = ""
        Dim pass2 As String = ""


        pass1 = Passtext.Text
        pass2 = Confirmtxt.Text

        If pass1 <> pass2 Then
            MsgBox("Password doesn't match", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            MsgBox("Select an user level", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Dim userlevelid As Integer

            If ComboBox1.Text = "Owner" Then
                userlevelid = 1
            ElseIf ComboBox1.Text = "User" Then
                userlevelid = 2
            ElseIf ComboBox1.Text = "Guest" Then
                userlevelid = 3
            End If

            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            chkSQL = "SELECT username FROM UsersInfo WHERE username = '" + Usertext1.Text + "'"
            strSQL = "INSERT INTO UsersInfo (username, userpass, userlevel, userlevelid) VALUES (@username, @userpass, @userlevel, @userlevelid)"

            Dim check As New MySqlCommand(chkSQL, conexao)
            ch = check.ExecuteReader
            If (ch.Read()) Then
                MessageBox.Show("User already exists!")
                ch.Close()
                conexao.Close()
                comando = Nothing

            Else
                ch.Close()
                conexao.Close()
                conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
                conexao.Open()

                comando = New MySqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("@username", Usertext1.Text)
                comando.Parameters.AddWithValue("@userpass", Passtext.Text)
                comando.Parameters.AddWithValue("@userlevel", ComboBox1.Text)
                comando.Parameters.AddWithValue("@userlevelid", userlevelid)
                MessageBox.Show("User successfully created!")
                Usertext1.Text = ""
                Passtext.Text = ""
                Confirmtxt.Text = ""
                ComboBox1.Text = ""

                comando.ExecuteNonQuery()
                ch.Close()
                conexao.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ch.Close()
            conexao.Close()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class