Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class User
    Public Sub New()
        Comments = New HashSet(Of Comment)()
        Reviews = New HashSet(Of Review)()
        Badges = New HashSet(Of Badge)()
        Visits = New HashSet(Of Visit)()
    End Sub

    Public Property Id As Integer

    <Required>
    Public Property name As String

    <Required>
    Public Property email As String

    <Required>
    Public Property password As String

    Public Property Avatar As String

    Public Overridable Property Comments As ICollection(Of Comment)

    Public Overridable Property Reviews As ICollection(Of Review)

    Public Overridable Property Badges As ICollection(Of Badge)

    Public Overridable Property Visits As ICollection(Of Visit)
End Class
