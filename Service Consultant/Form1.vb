Imports System.Data.SqlClient
Public Class Form1
    Private objBank As New Access

    Public Class GlobalVariables
        Public Shared admin As Integer
        Public Shared load As New SqlConnection("Server= DESKTOP-ALN38I1\TOOLSTUDIO; Database = CONSULTANT; Integrated Security = True")
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        PictureBoxconnect.Visible = False
        PictureBoxdisconnect.Visible = True
        carregabtn.Visible = True
        disconnectbtn.Visible = False
    End Sub

    Private Sub Sairbtn_Click(sender As Object, e As EventArgs) Handles Sairbtn.Click
        Dim msg1 As Integer
        msg1 = MsgBox("Do you really want to exit", MsgBoxStyle.OkCancel)
        If msg1 = 1 Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub userbtn_Click(sender As Object, e As EventArgs) Handles userbtn.Click
        Me.Hide()
        Users.Show()
    End Sub

    Private Sub deletabtn_Click(sender As Object, e As EventArgs) Handles deletabtn.Click
        If GlobalVariables.admin <> 1 Then
            MsgBox("You don't have administrator rights!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub carregabtn_Click(sender As Object, e As EventArgs) Handles carregabtn.Click
        objBank.Connect()

        Dim ds As DataSet = objBank.ExecuteQuery("SELECT * FROM MachinesInfo")

        DataGridView1.DataSource = ds.Tables(0)
        objBank.Close()

        disconnectbtn.Visible = True
        carregabtn.Visible = False

        PictureBoxconnect.Visible = True
        PictureBoxdisconnect.Visible = False

    End Sub

    Private Sub disconnectbtn_Click(sender As Object, e As EventArgs) Handles disconnectbtn.Click

        disconnectbtn.Visible = False
        carregabtn.Visible = True


        PictureBoxconnect.Visible = False
            PictureBoxdisconnect.Visible = True


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Salvabtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class