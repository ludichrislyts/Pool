'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class User
    Public Property Id As Integer
    Public Property name As String
    Public Property email As String
    Public Property password As String
    Public Property PlaceId As Integer
    Public Property AvatarId As Integer
    Public Property BadgeId As Integer

    Public Overridable Property Place As Place
    Public Overridable Property Avatar As Avatar
    Public Overridable Property Badge As Badge
    Public Overridable Property Comment As Comment
    Public Overridable Property StaticReviews As ICollection(Of StaticReview) = New HashSet(Of StaticReview)
    Public Overridable Property Visits As ICollection(Of Visit) = New HashSet(Of Visit)

End Class