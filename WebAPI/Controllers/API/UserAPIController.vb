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
    Public Class UserAPIController
        Inherits System.Web.Http.ApiController

        Private db As New DatabaseEntities

        ' GET: api/UserAPI
        Function GetUsers() As IQueryable(Of User)
            Return db.Users
        End Function

        ' GET: api/UserAPI/5
        <ResponseType(GetType(User))>
        Function GetUser(ByVal id As Integer) As IHttpActionResult
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return NotFound()
            End If

            Return Ok(user)
        End Function

        ' PUT: api/UserAPI/5
        <ResponseType(GetType(Void))>
        Function PutUser(ByVal id As Integer, ByVal user As User) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = user.Id Then
                Return BadRequest()
            End If

            db.Entry(user).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (UserExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/UserAPI
        <ResponseType(GetType(User))>
        Function PostUser(ByVal user As User) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Users.Add(user)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = user.Id}, user)
        End Function

        ' DELETE: api/UserAPI/5
        <ResponseType(GetType(User))>
        Function DeleteUser(ByVal id As Integer) As IHttpActionResult
            Dim user As User = db.Users.Find(id)
            If IsNothing(user) Then
                Return NotFound()
            End If

            db.Users.Remove(user)
            db.SaveChanges()

            Return Ok(user)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function UserExists(ByVal id As Integer) As Boolean
            'Return db.Users.Count(Function(e) e.Id = id) > 0
            Return db.Users.Any(Function(e) e.Id = id)
        End Function
    End Class
End Namespace