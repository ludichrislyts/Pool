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

Partial Public Class Place
    Public Property Id As Integer
    Public Property name As String
    Public Property address As String
    Public Property city As String
    Public Property state As String
    Public Property zip As Integer
    Public Property phone As String

    Public Overridable Property Comments As ICollection(Of Comment) = New HashSet(Of Comment)
    Public Overridable Property StaticReviews As ICollection(Of StaticReview) = New HashSet(Of StaticReview)
    Public Overridable Property Visits As ICollection(Of Visit) = New HashSet(Of Visit)

End Class
