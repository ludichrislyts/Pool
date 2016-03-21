Imports System.ComponentModel.DataAnnotations

Partial Public Class Place
    'Public Sub New()
    '    Comments = New HashSet(Of Comment)()
    '    Reviews = New HashSet(Of Review)()
    '    Visits = New HashSet(Of Visit)()
    'End Sub

    Public Property Id As Integer

    <Required>
    Public Property name As String

    <Required>
    Public Property address As String

    <Required>
    Public Property city As String

    <Required>
    Public Property state As String

    Public Property zip As Integer

    Public Property rules As Integer

    Public Property pricing As String

    <Required>
    Public Property phone As String

    'Public Overridable Property Comments As ICollection(Of Comment)

    'Public Overridable Property Reviews As ICollection(Of Review)

    'Public Overridable Property Visits As ICollection(Of Visit)
End Class