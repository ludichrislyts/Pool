Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Runtime.Serialization

<DataContract(IsReference:=True)>
Partial Public Class Visit
    Public Sub New()
        Places = New HashSet(Of Place)()
        Users = New HashSet(Of User)()
    End Sub

    <DataMember>
    Public Property Id As Integer

    <DataMember>
    Public Property [Date] As Date

    <DataMember>
    Public Overridable Property Places As ICollection(Of Place)

    <DataMember>
    Public Overridable Property Users As ICollection(Of User)
End Class
