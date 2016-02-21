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
    Public Class PlaceAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/PlaceAPI
        Function GetPlaces() As IQueryable(Of Place)
            Return db.Places
        End Function

        ' GET: api/PlaceAPI/5
        <ResponseType(GetType(Place))>
        Function GetPlace(ByVal id As Integer) As IHttpActionResult
            Dim place As Place = db.Places.Find(id)
            If IsNothing(place) Then
                Return NotFound()
            End If

            Return Ok(place)
        End Function

        ' PUT: api/PlaceAPI/5
        <ResponseType(GetType(Void))>
        Function PutPlace(ByVal id As Integer, ByVal place As Place) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = place.Id Then
                Return BadRequest()
            End If

            db.Entry(place).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (PlaceExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/PlaceAPI
        <ResponseType(GetType(Place))>
        Function PostPlace(ByVal place As Place) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Places.Add(place)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = place.Id}, place)
        End Function

        ' DELETE: api/PlaceAPI/5
        <ResponseType(GetType(Place))>
        Function DeletePlace(ByVal id As Integer) As IHttpActionResult
            Dim place As Place = db.Places.Find(id)
            If IsNothing(place) Then
                Return NotFound()
            End If

            db.Places.Remove(place)
            db.SaveChanges()

            Return Ok(place)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function PlaceExists(ByVal id As Integer) As Boolean
            Return db.Places.Count(Function(e) e.Id = id) > 0
        End Function
    End Class
End Namespace