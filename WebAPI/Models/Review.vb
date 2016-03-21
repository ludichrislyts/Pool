Imports System.ComponentModel.DataAnnotations

Partial Public Class Review
    Public Property Id As Integer

    <Required>
    Public Property review As String

    Public Property rating As Short

    Public Property pid As Integer

    Public Property uid As Integer

    'Public Overridable Property Place As Place

    'Public Overridable Property User As User
End Class