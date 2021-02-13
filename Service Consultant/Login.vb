Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Login
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private dr As MySqlDataReader
    Private ch As MySqlDataReader
    Private chk As MySqlDataReader
    Private userlogin As String
    Private passlogin As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Dim msg As Integer
        msg = MsgBox("Do you really want to exit", MsgBoxStyle.YesNo)

        If msg = MsgBoxResult.Yes Then
            Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")

            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            userlogin = "SELECT userpass FROM usersinfo where username  = '" + Usertext.Text + "'"

            Dim comando As New MySqlCommand(userlogin, conexao)
            ch = comando.ExecuteReader

            If Not (ch.Read()) Then
                MessageBox.Show("User doesn't exist!")
                ch.Close()
                conexao.Close()
                comando = Nothing

            Else
                ch.Close()
                conexao.Close()
                conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
                conexao.Open()

                passlogin = "SELECT username FROM UsersInfo where userpass = '" + Passtext.Text + "'"

                Dim comando1 As New MySqlCommand(passlogin, conexao)
                chk = comando1.ExecuteReader

                If Not (chk.Read()) Then
                    MessageBox.Show("Password doesn't match!")
                    chk.Close()
                    conexao.Close()

                Else
                    Usertext.Text = ""
                    Passtext.Text = ""
                    Me.Hide()
                    Form1.Show()
                    conexao.Close()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try


    End Sub

End Class