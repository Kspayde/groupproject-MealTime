Public Class CustomListBox
    Inherits ListBox

    Private listTableID As List(Of Integer)

    Public Property intTableID(index As Integer) As Integer
        Get
            Return listTableID(index)
        End Get
        Set(value As Integer)
            listTableID(index) = value
        End Set

    End Property

End Class
