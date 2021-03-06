Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports Newtonsoft.Json

<DataContract(IsReference:=True)>
Partial Public Class User
    Public Sub New()
        Comments = New HashSet(Of Comment)()
        Reviews = New HashSet(Of Review)()
        Badges = New HashSet(Of Badge)()
        Visits = New HashSet(Of Visit)()
    End Sub

    <DataMember>
    Public Property Id As Integer

    <DataMember>
    <Required>
    Public Property name As String

    <DataMember>
    <Required>
    Public Property email As String

    <DataMember>
    <Required>
    Public Property password As String

    <DataMember>
    Public Property Avatar As String

    <IgnoreDataMember>
    Public Overridable Property Comments As ICollection(Of Comment)

    <IgnoreDataMember>
    Public Overridable Property Reviews As ICollection(Of Review)

    <IgnoreDataMember>
    Public Overridable Property Badges As ICollection(Of Badge)

    <IgnoreDataMember>
    Public Overridable Property Visits As ICollection(Of Visit)
End Class
