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

Partial Public Class Visit

    Private _Id As Integer
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Private Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Public Property [Date] As Date

    Public Overridable Property Places As ICollection(Of Place) = New HashSet(Of Place)
    Public Overridable Property Users As ICollection(Of User) = New HashSet(Of User)

End Class