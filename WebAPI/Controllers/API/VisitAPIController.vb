Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Description
Imports WebAPI

Namespace Controllers.API
    Public Class VisitAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/VisitAPI
        Function GetVisits() As IQueryable(Of Visit)
            Return db.Visits
        End Function

        ' GET: api/VisitAPI/5
        <ResponseType(GetType(Visit))>
        Function GetVisit(ByVal id As Integer) As IHttpActionResult
            Dim visit As Visit = db.Visits.Find(id)
            If IsNothing(visit) Then
                Return NotFound()
            End If

            Return Ok(visit)
        End Function

        ' PUT: api/VisitAPI/5
        <ResponseType(GetType(Void))>
        Function PutVisit(ByVal id As Integer, ByVal visit As Visit) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = visit.Id Then
                Return BadRequest()
            End If

            db.Entry(visit).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (VisitExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/VisitAPI
        <ResponseType(GetType(Visit))>
        Function PostVisit(ByVal visit As Visit) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Visits.Add(visit)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = visit.Id}, visit)
        End Function

        ' DELETE: api/VisitAPI/5
        <ResponseType(GetType(Visit))>
        Function DeleteVisit(ByVal id As Integer) As IHttpActionResult
            Dim visit As Visit = db.Visits.Find(id)
            If IsNothing(visit) Then
                Return NotFound()
            End If

            db.Visits.Remove(visit)
            db.SaveChanges()

            Return Ok(visit)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function VisitExists(ByVal id As Integer) As Boolean
            Return db.Visits.Count(Function(e) e.Id = id) > 0
        End Function
    End Class
End Namespace