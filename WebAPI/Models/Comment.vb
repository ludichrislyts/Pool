Imports System.ComponentModel.DataAnnotations

Partial Public Class Comment
    Public Property Id As Integer

    <Required>
    Public Property text As String

    Public Property [Date] As Date

    Public Property User_Id As Integer?

    Public Property Place_Id As Integer

    'Public Overridable Property Place As Place

    'Public Overridable Property User As User
End Class