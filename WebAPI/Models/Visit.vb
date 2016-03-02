Partial Public Class Visit
    Public Sub New()
        Places = New HashSet(Of Place)()
        Users = New HashSet(Of User)()
    End Sub

    Public Property Id As Integer

    Public Property [Date] As Date

    Public Overridable Property Places As ICollection(Of Place)

    Public Overridable Property Users As ICollection(Of User)
End Class
