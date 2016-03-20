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
        modelBuilder.Entity(Of Badge)() _
            .HasMany(Function(e) e.Users) _
            .WithMany(Function(e) e.Badges) _
            .Map(Function(m) m.ToTable("UserBadge").MapLeftKey("Badges_Id"))

        'modelBuilder.Entity(Of Place)() _
        '    .HasMany(Function(e) e.Comments) _
        '    .WithRequired(Function(e) e.User) _
        '    .HasForeignKey(Function(e) e.User_Id) _
        '    .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Place)() _
            .HasMany(Function(e) e.Reviews) _
            .WithRequired(Function(e) e.Place) _
            .HasForeignKey(Function(e) e.Place_Id) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Place)() _
            .HasMany(Function(e) e.Visits) _
            .WithMany(Function(e) e.Places) _
            .Map(Function(m) m.ToTable("VisitPlace").MapLeftKey("Places_Id").MapRightKey("Visits_Id"))

        'modelBuilder.Entity(Of User)() _
        '    .HasMany(Function(e) e.Comments)
        '.WithOptional(Function(e) e.User) _
        '.HasForeignKey(Function(e) e.User_Id)

        modelBuilder.Entity(Of User)() _
            .HasMany(Function(e) e.Reviews) _
            .WithOptional(Function(e) e.User) _
            .HasForeignKey(Function(e) e.User_Id)

        modelBuilder.Entity(Of User)() _
            .HasMany(Function(e) e.Visits) _
            .WithMany(Function(e) e.Users) _
            .Map(Function(m) m.ToTable("VisitUser").MapLeftKey("Users_Id").MapRightKey("Visits_Id"))
    End Sub
End Class