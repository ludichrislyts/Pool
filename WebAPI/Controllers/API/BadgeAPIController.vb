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
    Public Class BadgeAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/BadgeAPI
        Function GetBadges() As IQueryable(Of Badge)
            Return db.Badges
        End Function

        ' GET: api/BadgeAPI/5
        <ResponseType(GetType(Badge))>
        Function GetBadge(ByVal id As Integer) As IHttpActionResult
            Dim badge As Badge = db.Badges.Find(id)
            If IsNothing(badge) Then
                Return NotFound()
            End If

            Return Ok(badge)
        End Function

        ' PUT: api/BadgeAPI/5
        <ResponseType(GetType(Void))>
        Function PutBadge(ByVal id As Integer, ByVal badge As Badge) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = badge.Id Then
                Return BadRequest()
            End If

            db.Entry(badge).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (BadgeExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/BadgeAPI
        <ResponseType(GetType(Badge))>
        Function PostBadge(ByVal badge As Badge) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Badges.Add(badge)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = badge.Id}, badge)
        End Function

        ' DELETE: api/BadgeAPI/5
        <ResponseType(GetType(Badge))>
        Function DeleteBadge(ByVal id As Integer) As IHttpActionResult
            Dim badge As Badge = db.Badges.Find(id)
            If IsNothing(badge) Then
                Return NotFound()
            End If

            db.Badges.Remove(badge)
            db.SaveChanges()

            Return Ok(badge)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function BadgeExists(ByVal id As Integer) As Boolean
            Return db.Badges.Count(Function(e) e.Id = id) > 0
        End Function
    End Class
End Namespace