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
    Public Class ReviewAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/ReviewAPI
        Function GetReviews() As IQueryable(Of Review)
            Return db.Reviews
        End Function

        ' GET: api/ReviewAPI/5
        <ResponseType(GetType(Review))>
        Function GetReview(ByVal id As Integer) As IHttpActionResult
            Dim review As Review = db.Reviews.Find(id)
            If IsNothing(review) Then
                Return NotFound()
            End If

            Return Ok(review)
        End Function

        ' PUT: api/ReviewAPI/5
        <ResponseType(GetType(Void))>
        Function PutReview(ByVal id As Integer, ByVal review As Review) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = review.Id Then
                Return BadRequest()
            End If

            db.Entry(review).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (ReviewExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/ReviewAPI
        <ResponseType(GetType(Review))>
        Function PostReview(ByVal review As Review) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Reviews.Add(review)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = review.Id}, review)
        End Function

        ' DELETE: api/ReviewAPI/5
        <ResponseType(GetType(Review))>
        Function DeleteReview(ByVal id As Integer) As IHttpActionResult
            Dim review As Review = db.Reviews.Find(id)
            If IsNothing(review) Then
                Return NotFound()
            End If

            db.Reviews.Remove(review)
            db.SaveChanges()

            Return Ok(review)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function ReviewExists(ByVal id As Integer) As Boolean
            Return db.Reviews.Count(Function(e) e.Id = id) > 0
        End Function
    End Class
End Namespace