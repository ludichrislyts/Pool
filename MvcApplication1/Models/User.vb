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

    Private _Id As Integer
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Private Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Public Property name As String
    Public Property email As String
    Public Property password As String
    Public Property Avatar As String

    Public Overridable Property Visits As ICollection(Of Visit) = New HashSet(Of Visit)
    Public Overridable Property Badges As ICollection(Of Badge) = New HashSet(Of Badge)
    Public Overridable Property Comments As ICollection(Of Comment) = New HashSet(Of Comment)
    Public Overridable Property StaticReviews As ICollection(Of Review) = New HashSet(Of Review)

End Class
