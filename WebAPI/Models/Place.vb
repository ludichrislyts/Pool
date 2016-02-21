Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization

<DataContract(IsReference:=True)>
Partial Public Class Place
    Public Sub New()
        Comments = New HashSet(Of Comment)()
        Reviews = New HashSet(Of Review)()
        Visits = New HashSet(Of Visit)()
    End Sub

    <DataMember>
    Public Property Id As Integer

    <DataMember>
    <Required>
    Public Property name As String

    <DataMember>
    <Required>
    Public Property address As String

    <DataMember>
    <Required>
    Public Property city As String

    <DataMember>
    <Required>
    Public Property state As String

    <DataMember>
    Public Property zip As Integer

    <DataMember>
    <Required>
    Public Property phone As String

    <DataMember>
    Public Overridable Property Comments As ICollection(Of Comment)

    <DataMember>
    Public Overridable Property Reviews As ICollection(Of Review)

    <DataMember>
    Public Overridable Property Visits As ICollection(Of Visit)
End Class
