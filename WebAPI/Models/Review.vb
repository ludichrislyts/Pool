Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization

<DataContract(IsReference:=True)>
Partial Public Class Review
    Public Property Id As Integer

    <DataMember>
    <Required>
    Public Property review As String

    <DataMember>
    Public Property rating As Short

    <DataMember>
    Public Property Place_Id As Integer

    <DataMember>
    Public Property User_Id As Integer?

    <DataMember>
    Public Overridable Property Place As Place

    <DataMember>
    Public Overridable Property User As User
End Class
