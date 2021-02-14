﻿Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class ManageUser
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private strSQL As String
    Private deleteSQL As String

    Sub filterrecords(ByVal search As String)
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            strSQL = "SELECT username, userpass, userlevel, userid FROM UsersInfo ORDER BY username"

            Dim dt As New DataTable
            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            dgvData.DataSource = dt
            conexao.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()

        End Try

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Hide()
        Users.Show()
    End Sub

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            strSQL = "SELECT username, userpass, userlevel, userid FROM UsersInfo ORDER BY username"

            Dim dt As New DataTable
            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            dgvData.DataSource = dt
            conexao.Open()
            usernametxt.Text = ""
            userpwdtxt.Text = ""
            userlvlcbx.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()

        End Try

    End Sub

    Private Sub dgvData_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvData.MouseClick
        Dim index As Integer
        index = dgvData.CurrentRow.Index
        Me.usernametxt.Text = dgvData.Item(0, index).Value
        Me.userpwdtxt.Text = dgvData.Item(1, index).Value
        Me.userlvlcbx.Text = dgvData.Item(2, index).Value
        Me.levellbl.Text = dgvData.Item(3, index).Value
    End Sub

    Private Sub Alterbtn_Click(sender As Object, e As EventArgs) Handles Alterbtn.Click
        Try
            Dim userlevelid As Integer

            If userlvlcbx.Text = "Owner" Then
                userlevelid = 1
            ElseIf userlvlcbx.Text = "User" Then
                userlevelid = 2
            ElseIf userlvlcbx.Text = "Guest" Then
                userlevelid = 3
            End If

            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            Dim update As String
            Dim value As Integer = CInt(levellbl.Text)

            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            update = "UPDATE UsersInfo SET userlevel = @userlevel, userlevelid = @userlevelid, userpass = @userpass WHERE userid = @value"

            comando = New MySqlCommand(update, conexao)
            comando.Parameters.AddWithValue("@value", value)
            comando.Parameters.AddWithValue("@userpass", userpwdtxt.Text)
            comando.Parameters.AddWithValue("@userlevel", userlvlcbx.Text)
            comando.Parameters.AddWithValue("@userlevelid", userlevelid)
            comando.ExecuteNonQuery()
            MessageBox.Show("User updated successfully!")
            conexao.Close()
            filterrecords("")
            usernametxt.Text = ""
            userpwdtxt.Text = ""
            userlvlcbx.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim msg As Integer
        msg = MsgBox("Do you really want to delete it?", MsgBoxStyle.YesNo)

        If msg = MsgBoxResult.Yes Then

            Try
                Dim value1 As Integer = CInt(levellbl.Text)
                conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")

                If conexao.State = ConnectionState.Closed Then
                    conexao.Open()
                End If

                deleteSQL = "DELETE from UsersInfo where userid = @value"

                comando = New MySqlCommand(deleteSQL, conexao)
                comando.Parameters.AddWithValue("@value", value1)
                comando.ExecuteNonQuery()
                MessageBox.Show("User deleted successfully!")
                conexao.Close()
                filterrecords("")
                usernametxt.Text = ""
                userpwdtxt.Text = ""
                userlvlcbx.Text = ""

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                conexao.Close()
                conexao = Nothing
                comando = Nothing

            End Try

        End If


    End Sub

End Class