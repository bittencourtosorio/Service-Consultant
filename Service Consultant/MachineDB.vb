Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class MachineDB
    Private objBank As New Access
    Private conexao As MySqlConnection
    Private connection As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private reader As MySqlDataReader
    Private strSQL As String
    Dim erosion As String
    Private deleteSQL As String


    Public Class GlobalVariables
        Public Shared admin As Integer
        Public Shared load As New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
    End Class

    Sub filterrecords(ByVal search As String)
        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            strSQL = "SELECT  mac_number as 'Number', mac_type as 'Type', mac_control as 'Control', mac_year as 'Year', mac_brand as 'Brand', mac_erosion as 'Erosion' FROM MachinesInfo ORDER BY mac_number"

            Dim dt As New DataTable
            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conexao.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexao.Close()

        End Try

    End Sub

    Private Sub brand_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles brand_cb.SelectedIndexChanged
        Dim connection As New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
        Dim command As New MySqlCommand("SELECT mac_type FROM machinesinfo WHERE mac_brand = @macbrand", connection)
        command.Parameters.Add("@macbrand", MySqlDbType.VarChar).Value = brand_cb.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        mactype_cb.DataSource = table
        mactype_cb.DisplayMember = "mac_type"
    End Sub

    Private Sub MachineDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")
    End Sub

    Private Sub create_btn_Click(sender As Object, e As EventArgs) Handles create_btn.Click

        Try
            conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            strSQL = "INSERT INTO MachinesInfo (mac_type, mac_control, mac_number, mac_year, mac_brand, mac_erosion) VALUES (@mactype, @maccontrol, @macnumber, @macyear, @macbrand, @macerosion)"
            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@mactype", mactype_cb.Text)
            comando.Parameters.AddWithValue("@maccontrol", control_cb.Text)
            comando.Parameters.AddWithValue("@macnumber", macnumtxt.Text)
            comando.Parameters.AddWithValue("@macyear", macyear_cb.Text)
            comando.Parameters.AddWithValue("@macbrand", brand_cb.Text)
            comando.Parameters.AddWithValue("@macerosion", erosion)

            Try
                Dim queryString As String
                queryString = " SELECT * FROM brands WHERE brand_name = '" + brand_cb.Text + "'"

                Dim command As New MySqlCommand(queryString, connection)
                reader = command.ExecuteReader()

                If Not reader.Read() Then
                    MessageBox.Show("Brand doesn't exist!")
                    reader.Close()
                    connection.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                reader.Close()
                connection.Close()
                connection = Nothing

            End Try

            MessageBox.Show("Machine successfully created!")
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try
    End Sub

    Private Sub erosion_rb1_CheckedChanged(sender As Object, e As EventArgs) Handles erosion_rb1.CheckedChanged
        erosion = "Yes"
    End Sub

    Private Sub erosion_rb2_CheckedChanged(sender As Object, e As EventArgs) Handles erosion_rb2.CheckedChanged
        erosion = "No"
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        objBank.Connect()

        Dim ds As DataSet = objBank.ExecuteQuery("SELECT  mac_number as 'Number', mac_type as 'Type', mac_control as 'Control', mac_year as 'Year', mac_brand as 'Brand', mac_erosion as 'Erosion' FROM MachinesInfo ORDER BY mac_number")
        DataGridView1.DataSource = ds.Tables(0)
        objBank.Close()
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim index As Integer
        index = DataGridView1.CurrentRow.Index
        Me.brand_cb.Text = DataGridView1.Item(4, index).Value
        Me.macnumtxt.Text = DataGridView1.Item(0, index).Value
        Me.mactype_cb.Text = DataGridView1.Item(1, index).Value
        Me.control_cb.Text = DataGridView1.Item(2, index).Value
        Me.macyear_cb.Text = DataGridView1.Item(3, index).Value
        ' If 
        'Me.erosion_rb1.Select()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim msg As Integer
        msg = MsgBox("Do you really want to delete it?", MsgBoxStyle.YesNo)

        If msg = MsgBoxResult.Yes Then

            Try
                'Dim value1 As Integer = CInt(levellbl.Text)
                conexao = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")

                If conexao.State = ConnectionState.Closed Then
                    conexao.Open()
                End If

                deleteSQL = "DELETE from machinesinfo where mac_number = @value"

                comando = New MySqlCommand(deleteSQL, conexao)
                comando.Parameters.AddWithValue("@value", macnumtxt.Text)
                comando.ExecuteNonQuery()
                MessageBox.Show("Machine deleted successfully!")
                conexao.Close()
                filterrecords("")
                brand_cb.Text = ""
                macnumtxt.Text = ""
                mactype_cb.Text = ""
                control_cb.Text = ""
                macyear_cb.Text = ""

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                conexao.Close()
                conexao = Nothing
                comando = Nothing

            End Try

        End If
    End Sub

    Private Sub brand_btn_Click(sender As Object, e As EventArgs) Handles brand_btn.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection = New MySqlConnection("Server=localhost; database= consultant; user id=root; password=")

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim queryString As String
            queryString = " SELECT * FROM brands WHERE brand_name = '" + TextBox1.Text + "'"

            Dim command As New MySqlCommand(queryString, connection)

            reader = command.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Existe")
                reader.Close()
                connection.Close()
            Else
                MessageBox.Show("Nao Existe")
                reader.Close()
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            reader.Close()
            connection.Close()
            connection = Nothing

        End Try

    End Sub
End Class