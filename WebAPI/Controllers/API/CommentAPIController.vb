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
    Public Class CommentAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/CommentAPI
        Function GetComments() As IQueryable(Of Comment)
            Return db.Comments
        End Function

        ' GET: api/CommentAPI/5
        <ResponseType(GetType(Comment))>
        Function GetComment(ByVal id As Integer) As IHttpActionResult
            Dim comment As Comment = db.Comments.Find(id)
            If IsNothing(comment) Then
                Return NotFound()
            End If

            Return Ok(comment)
        End Function

        ' PUT: api/CommentAPI/5
        <ResponseType(GetType(Void))>
        Function PutComment(ByVal id As Integer, ByVal comment As Comment) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = comment.Id Then
                Return BadRequest()
            End If

            db.Entry(comment).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (CommentExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/CommentAPI
        <ResponseType(GetType(Comment))>
        Function PostComment(ByVal comment As Comment) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Comments.Add(comment)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = comment.Id}, comment)
        End Function

        ' DELETE: api/CommentAPI/5
        <ResponseType(GetType(Comment))>
        Function DeleteComment(ByVal id As Integer) As IHttpActionResult
            Dim comment As Comment = db.Comments.Find(id)
            If IsNothing(comment) Then
                Return NotFound()
            End If

            db.Comments.Remove(comment)
            db.SaveChanges()

            Return Ok(comment)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function CommentExists(ByVal id As Integer) As Boolean
            Return db.Comments.Count(Function(e) e.Id = id) > 0
        End Function
    End Class
End Namespace