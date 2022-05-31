Public Class weightManagement
    Private Property datacontrol As New DatabaseControl

    Public Class weightObject
        Public Property weightId As Integer
        Public Property userId As Integer
        Public Property weightDate As Date
        Public Property weight As Double
    End Class

    Private Function fillWeight(data As DataTable) As weightObject
        Dim weightInfo As New weightObject

        With weightInfo
            .weightId = If(Not IsDBNull(data.Rows.Item(0).Item("weight_entry_ID")), data.Rows.Item(0).Item("weight_entry_ID"), Nothing)
            .userId = If(Not IsDBNull(data.Rows.Item(0).Item("user_ID")), data.Rows.Item(0).Item("user_ID"), Nothing)
            .weightDate = If(Not IsDBNull(data.Rows.Item(0).Item("weight_entry_datetime")), data.Rows.Item(0).Item("weight_entry_datetime"), Nothing)
            .weight = If(Not IsDBNull(data.Rows.Item(0).Item("weight")), data.Rows.Item(0).Item("weight"), Nothing)
        End With

        Return weightInfo

    End Function

    Public Sub createWeight(weight As weightObject)

        Dim query As String = String.Format("INSERT INTO weight (user_ID, weight_entry_datetime, weight) VALUES ({0}, '{1}', {2})", weight.userId, weight.weightDate, weight.weight)

        datacontrol.runStatement(query)

    End Sub

    Public Function getWeight(id As Integer) As weightObject

        Dim weightItem As New DataTable

        weightItem = datacontrol.getData(String.Format("SELECT * FROM weight WHERE weight_entry_id = {0}", id))

        Return fillWeight(weightItem)

    End Function


    Public Sub updateWeight(weight As weightObject)

        Dim query As String = String.Format("UPDATE weight SET user_ID = {0}, weight_entry_datetime = {1}, weight = {2} WHERE weight_entry_id = {3}", weight.userId, weight.weightDate, weight.weight, weight.weightId)

        datacontrol.runStatement(query)

    End Sub

    Public Sub deleteWeight(id As Integer)

        Dim query As String = String.Format("DELETE FROM weight WHERE weight_entry_ID = {0}", id)

        datacontrol.runStatement(query)

    End Sub
End Class
