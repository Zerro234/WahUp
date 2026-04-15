Imports System.Data.SqlClient
Public Class SQL
    Private ConnectionString As String = ""
    Public Function Execute(text As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Dim conn As SqlConnection = New SqlConnection(ConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter(text, conn)
            dt = New DataTable()
            da.Fill(dt)
        Catch ex As Exception
            dt = Nothing
            MessageBox.Show($"Query.Error => {ex.Message}")
        End Try

        Execute = dt
    End Function
End Class
