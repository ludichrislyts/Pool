﻿Imports System.Data.Entity

Namespace MvcApplication1
    Public Class PlaceController
        Inherits System.Web.Mvc.Controller

        Private db As New DatabaseEntities

        '
        ' GET: /Place/

        Function Index() As ActionResult
            If IsNothing(db.Places.ToList) Then
                Return HttpNotFound()
            End If
            Return View(db.Places.ToList())
        End Function

        '
        ' GET: /Place/Details/5

        Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim place As Place = db.Places.Find(id)

            If IsNothing(place) Then
                'Return HttpNotFound()
                Return View(place)
            End If
            Return View(place)
        End Function

        Function [Get]() As ActionResult
            Return Json(db.Places.ToList(), JsonRequestBehavior.AllowGet)
        End Function

        '
        ' GET: /Place/Create

        Function Create() As ActionResult
            Return View(New Place)
        End Function

        '
        ' POST: /Place/Create

        <HttpPost()>
        Function Create(ByVal place As Place) As ActionResult
            If ModelState.IsValid Then
                db.Places.Add(place)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(place)
        End Function

        '
        ' GET: /Place/Edit/5

        Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim place As Place = db.Places.Find(id)
            If IsNothing(place) Then
                Return HttpNotFound()
            End If
            Return View(place)
        End Function

        '
        ' POST: /Place/Edit/5

        <HttpPost()>
        Function Edit(ByVal place As Place) As ActionResult
            Me.Request.Params.ToString()

            If ModelState.IsValid Then
                'Dim Got_Place = db.Places.Find(place.Id)
                'Got_Place.name = place.name
                'db.Entry(Got_Place).State = EntityState.Modified

                db.Entry(place).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            Return View(place)
        End Function

        '
        ' GET: /Place/Delete/5

        Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
            Dim place As Place = db.Places.Find(id)
            If IsNothing(place) Then
                Return HttpNotFound()
            End If
            Return View(place)
        End Function

        '
        ' POST: /Place/Delete/5

        <HttpPost()>
        <ActionName("Delete")>
        Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
            Dim place As Place = db.Places.Find(id)
            db.Places.Remove(place)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace