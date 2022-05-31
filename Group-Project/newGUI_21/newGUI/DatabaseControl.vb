Public Class DatabaseControl
    'Connection string
    'Private databaseConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\corey\Desktop\HealthTrackDB.accdb")
    'Private databaseConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\corey\Desktop\HealthTrackDB.accdb")

    Dim databasePath As String = Environment.GetEnvironmentVariable("APPDATA") + "\HealthTrackDB.accdb"

    Private databaseConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)

    'This function will return a filled datatable 

    Public Function getData(query As String) As DataTable
        Dim dataReturn As New DataTable
        'These try catchs can be removed towards the end if needed, good for debugging though
        Try
            Dim adapter As New OleDb.OleDbDataAdapter(query, databaseConnection)
            databaseConnection.Open()
            adapter.Fill(dataReturn)
            databaseConnection.Close()
        Catch ex As Exception

        Finally
            'Make sure we do not leave the connection open by accident
            If databaseConnection.State = ConnectionState.Open Then databaseConnection.Close()
        End Try
        'return our datatable
        Return dataReturn
    End Function

    'this does not return data, just runs a command
    Public Sub runStatement(query As String)
        Try
            Dim cmd As New OleDb.OleDbCommand(query, databaseConnection)
            databaseConnection.Open()
            cmd.ExecuteNonQuery()
            databaseConnection.Close()
        Catch ex As Exception

        Finally
            If databaseConnection.State = ConnectionState.Open Then databaseConnection.Close()
        End Try
    End Sub
End Class