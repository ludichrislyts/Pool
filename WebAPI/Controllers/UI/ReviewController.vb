Imports System.Data.Entity

Public Class ReviewController
    Inherits System.Web.Mvc.Controller

    Private db As New DatabaseEntities

    '
    ' GET: /Review/

    Function Index() As ActionResult
        Return View(db.Reviews.ToList())
    End Function

    '
    ' GET: /Review/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim review As Review = db.Reviews.Find(id)
        If IsNothing(review) Then
            Return HttpNotFound()
        End If
        Return View(review)
    End Function

    '
    ' GET: /Review/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Review/Create

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Create(ByVal review As Review) As ActionResult
        If ModelState.IsValid Then
            db.Reviews.Add(review)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(review)
    End Function

    '
    ' GET: /Review/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim review As Review = db.Reviews.Find(id)
        If IsNothing(review) Then
            Return HttpNotFound()
        End If
        Return View(review)
    End Function

    '
    ' POST: /Review/Edit/5

    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Edit(ByVal review As Review) As ActionResult
        If ModelState.IsValid Then
            db.Entry(review).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(review)
    End Function

    '
    ' GET: /Review/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim review As Review = db.Reviews.Find(id)
        If IsNothing(review) Then
            Return HttpNotFound()
        End If
        Return View(review)
    End Function

    '
    ' POST: /Review/Delete/5

    <HttpPost()>
    <ActionName("Delete")>
    <ValidateAntiForgeryToken()>
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim review As Review = db.Reviews.Find(id)
        db.Reviews.Remove(review)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class