﻿Imports System.IO
Imports System.Data.SqlClient
Public Class Login
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private comando1 As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Private ch As SqlDataReader
    Private chk As SqlDataReader
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
            conexao = New SqlConnection("Server=DESKTOP-ALN38I1\TOOLSTUDIO; Database=CONSULTANT; Uid=ToolStudioUser;Pwd=ts;")

            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            userlogin = "SELECT userpass FROM UsersInfo where username  = '" + Usertext.Text + "'"

            Dim comando As New SqlCommand(userlogin, conexao)
            ch = comando.ExecuteReader

            If Not (ch.Read()) Then
                MessageBox.Show("User doesn't exist!")
                ch.Close()
                conexao.Close()
                comando = Nothing

            Else
                ch.Close()
                conexao.Close()
                conexao = New SqlConnection("Server=DESKTOP-ALN38I1\TOOLSTUDIO; Database=CONSULTANT; Uid=ToolStudioUser;Pwd=ts;")
                conexao.Open()

                passlogin = "SELECT username FROM UsersInfo where userpass = '" + Passtext.Text + "'"

                Dim comando1 As New SqlCommand(passlogin, conexao)
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