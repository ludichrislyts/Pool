Imports System.Data.Entity

Public Class CommentController
    Inherits System.Web.Mvc.Controller

    Private db As New DatabaseEntities

#Region "       Rest API    >>>"
    Function [Get](Optional ByVal id As Integer = 0) As ActionResult
        If id = 0 Then
            Return Json(db.Comments.ToList, JsonRequestBehavior.AllowGet)
        Else
            Return Json(db.Comments.Find(id), JsonRequestBehavior.AllowGet)
        End If
    End Function


#End Region





    '
    ' GET: /Comment/

    Function Index() As ActionResult
        Dim comments = db.Comments.Include(Function(c) c.Place)
        Return View(comments.ToList())
    End Function

    '
    ' GET: /Comment/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim comment As Comment = db.Comments.Find(id)
        If IsNothing(comment) Then
            Return HttpNotFound()
        End If
        Return View(comment)
    End Function

    '
    ' GET: /Comment/Create

    Function Create(PlaceId As Integer) As ActionResult
        ViewBag.PlaceId = New SelectList(db.Places, "Id", "name")
        Return View(New Comment)
    End Function

    '
    ' POST: /Comment/Create

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(ByVal comment As Comment, Placeid As Integer) As ActionResult
        If ModelState.IsValid Then
            Dim Place = db.Places.Find(Placeid)
            Place.Comments.Add(comment)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.PlaceId = New SelectList(db.Places, "Id", "name", comment.Place)
        Return View(comment)
    End Function

    '
    ' GET: /Comment/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim comment As Comment = db.Comments.Find(id)
        If IsNothing(comment) Then
            Return HttpNotFound()
        End If
        ViewBag.PlaceId = New SelectList(db.Places, "Id", "name", comment.Place)
        Return View(comment)
    End Function

    '
    ' POST: /Comment/Edit/5

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(ByVal comment As Comment) As ActionResult
        If ModelState.IsValid Then
            db.Entry(comment).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.PlaceId = New SelectList(db.Places, "Id", "name", comment.Place)
        Return View(comment)
    End Function

    '
    ' GET: /Comment/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim comment As Comment = db.Comments.Find(id)
        If IsNothing(comment) Then
            Return HttpNotFound()
        End If
        Return View(comment)
    End Function

    '
    ' POST: /Comment/Delete/5

    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim comment As Comment = db.Comments.Find(id)
        db.Comments.Remove(comment)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub


End Class