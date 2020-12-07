Imports System.Linq.Expressions

Public Class Access
    Private objConnection As SqlClient.SqlConnection

    Public Sub Connect()
        Try
            objConnection = New SqlClient.SqlConnection("Data Source = DESKTOP-ALN38I1\TOOLSTUDIO; INITIAL CATALOG = CONSULTANT; USER ID = ToolStudioUser; PASSWORD = ts")
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
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand

        Try
            objCommand = objConnection.CreateCommand
            objCommand.CommandText = Command

            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(ds)

        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function

End Class
