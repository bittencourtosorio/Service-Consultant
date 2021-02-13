Imports System.Linq.Expressions
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Access
    Private objConnection As MySqlClient.MySqlConnection

    Public Sub Connect()
        Try
            objConnection = New MySqlClient.MySqlConnection("Server=localhost; database= consultant; user id=root; password=")
            objConnection.Open()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Close()
        Try
            If Not IsNothing(objConnection) Then
                If objConnection.State = ConnectionState.Open Then
                    objConnection.Close()
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExecuteQuery(ByVal Command As String) As DataSet
        Dim ds As New DataSet
        Dim objDataAdapter As New MySqlClient.MySqlDataAdapter
        Dim objCommand As New MySqlClient.MySqlCommand

        Try
            objCommand = objConnection.CreateCommand
            objCommand.CommandText = Command

            objDataAdapter = New MySqlClient.MySqlDataAdapter(objCommand)
            objDataAdapter.Fill(ds)

        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function

End Class
