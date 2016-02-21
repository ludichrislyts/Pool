Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization

<DataContract(IsReference:=True)>
Partial Public Class Badge
    Public Sub New()
        Users = New HashSet(Of User)()
    End Sub

    <DataMember>
    Public Property Id As Integer

    <DataMember>
    <Required>
    Public Property image As String

    <DataMember>
    Public Overridable Property Users As ICollection(Of User)
End Class
