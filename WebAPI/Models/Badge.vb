Imports System.ComponentModel.DataAnnotations

Partial Public Class Badge
    Public Sub New()
        Users = New HashSet(Of User)()
    End Sub

    Public Property Id As Integer

    <Required>
    Public Property image As String

    <Runtime.Serialization.IgnoreDataMember>
    Public Overridable Property Users As ICollection(Of User)
End Class
