Imports System.Data.Entity

Namespace MvcApplication1
    Public Class UserController
        Inherits System.Web.Mvc.Controller

        Private db As New DatabaseEntities

        '
        ' GET: /User/

        Function Index() As ActionResult
            Dim users = db.Users.Include(Function(u) u.Avatar) '.Include(Function(u) u.Badge)
            Return View(users.ToList())
        End Function

        '
        ' GET: /User/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        '
        ' GET: /User/Create

        Function Create() As ActionResult
            'ViewBag.PlaceId = New SelectList(db.Places, "Id", "name")
            ViewBag.AvatarId = New SelectList(db.Avatars, "Id", "image")
            'ViewBag.BadgeId = New SelectList(db.Badges, "Id", "image")
            Return View()
        End Function

        '
        ' POST: /User/Create

        <HttpPost()>
        Function Create(ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Users.Add(user)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.AvatarId = New SelectList(db.Avatars, "Id", "image", user.AvatarId)
            'ViewBag.BadgeId = New SelectList(db.Badges, "Id", "image", user.BadgeId)
            Return View(user)
        End Function

        '
        ' GET: /User/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If

            ViewBag.AvatarId = New SelectList(db.Avatars, "Id", "image", user.AvatarId)
            'ViewBag.BadgeId = New SelectList(db.Badges, "Id", "image", user.BadgeId)
            Return View(user)
        End Function

        '
        ' POST: /User/Edit/5

        <HttpPost()>
        Function Edit(ByVal user As User) As ActionResult
            If ModelState.IsValid Then
                db.Entry(user).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ViewBag.AvatarId = New SelectList(db.Avatars, "Id", "image", user.AvatarId)
            'ViewBag.BadgeId = New SelectList(db.Badges, "Id", "image", user.BadgeId)
            Return View(user)
        End Function

        '
        ' GET: /User/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return HttpNotFound()
            End If
            Return View(user)
        End Function

        '
        ' POST: /User/Delete/5

        <HttpPost()>
        <ActionName("Delete")>
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim user As User = db.Users.Find(id)
            db.Users.Remove(user)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace