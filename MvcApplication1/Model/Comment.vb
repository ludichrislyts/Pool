Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Comment
    Public Property Id As Integer

    <Required>
    Public Property text As String

    Public Property [Date] As Date

    Public Property User_Id As Integer?

    Public Property Place_Id As Integer

    Public Overridable Property Place As Place

    Public Overridable Property User As User
End Class
