Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class DatabaseEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Database")
    End Sub

    Public Overridable Property Badges As DbSet(Of Badge)
    Public Overridable Property Comments As DbSet(Of Comment)
    Public Overridable Property Places As DbSet(Of Place)
    Public Overridable Property Reviews As DbSet(Of Review)
    Public Overridable Property Users As DbSet(Of User)
    Public Overridable Property Visits As DbSet(Of Visit)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Badge)()

        modelBuilder.Entity(Of Comment)() _
            .HasKey(Function(e) e.uid).HasKey(Function(e) e.pid)

        modelBuilder.Entity(Of Place)()

        modelBuilder.Entity(Of Review)() _
            .HasKey(Function(e) e.uid).HasKey(Function(e) e.pid)

        modelBuilder.Entity(Of Visit)() _
            .HasKey(Function(e) e.pid).HasKey(Function(e) e.uid)

        modelBuilder.Entity(Of User)()

        modelBuilder.Entity(Of User)() _
            .HasKey(Function(e) e.bid).HasKey(Function(e) e.cid).HasKey(Function(e) e.rid).HasKey(Function(e) e.vid)
    End Sub
End Class