Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Badge
    Public Sub New()
        Users = New HashSet(Of User)()
    End Sub

    Public Property Id As Integer

    <Required>
    Public Property image As String

    Public Overridable Property Users As ICollection(Of User)
End Class
