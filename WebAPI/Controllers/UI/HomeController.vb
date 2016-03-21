Namespace WebAPI
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Home

        Function Index() As ActionResult
            Return View()
        End Function

        Function Seed() As ActionResult
            Dim db As New DatabaseEntities
            If db.Database.Exists Then
                db.Database.Delete()
            End If

            db.Database.Create()

            Dim Image = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAU1QTFRFNjtAQEVK////bG9zSk9T/v7+/f39/f3+9vf3O0BETlJWNzxB/Pz8d3t+TFFVzM3O1NXX7u/vUldbRElNs7W3v8HCmZyeRkpPW19j8vLy7u7vvsDC9PT1cHR3Oj9Eo6WnxsjJR0tQOD1Bj5KVgYSHTVFWtri50dLUtLa4YmZqOT5D8vPzRUpOkZOWc3Z64uPjr7Gzuru95+jpX2NnaGxwPkNHp6mrioyPlZeadXh8Q0hNPEBFyszNh4qNc3d6eHx/OD1Cw8XGXGBkfoGEra+xxcbIgoaJu72/m52ggoWIZ2tu8/P0wcLE+vr7kZSXgIOGP0NIvr/BvL6/QUZKP0RJkpWYpKaoqKqtVVldmJqdl5qcZWhstbe5bHB0bnJ1UVVZwsTF5ubnT1RYcHN3oaSm3N3e3NzdQkdLnJ+h9fX1TlNX+Pj47/DwwsPFVFhcEpC44wAAAShJREFUeNq8k0VvxDAQhZOXDS52mRnKzLRlZmZm+v/HxmnUOlFaSz3su4xm/BkGzLn4P+XimOJZyw0FKufelfbfAe89dMmBBdUZ8G1eCJMba69Al+AABOOm/7j0DDGXtQP9bXjYN2tWGQfyA1Yg1kSu95x9GKHiIOBXLcAwUD1JJSBVfUbwGGi2AIvoneK4bCblSS8b0RwwRAPbCHx52kH60K1b9zQUjQKiULbMDbulEjGha/RQQFDE0/ezW8kR3C3kOJXmFcSyrcQR7FDAi55nuGABZkT5hqpk3xughDN7FOHHHd0LLU9qtV7r7uhsuRwt6pEJJFVLN4V5CT+SErpXt81DbHautkpBeHeaqNDRqUA0Uo5GkgXGyI3xDZ/q/wJMsb7/pwADAGqZHDyWkHd1AAAAAElFTkSuQmCC"

            'db.Avatars.Add(New Avatar With {.Image = })
            'db.SaveChanges()

#Region "Places"
            db.Places.Add(New Place With {.name = "Sam's Billiards", .address = "1845 NE 41st Ave", .city = "Portland", .state = "OR", .zip = 97212, .phone = "(503) 282-8266"})
            db.Places.Add(New Place With {.name = "Uptown Billiards Club", .address = "120 NW 23rd Ave", .city = "Portland", .state = "OR", .zip = 97210, .phone = "(503) 226-6909"})
            db.SaveChanges()
#End Region

#Region "Users"
            db.Users.Add(New User With {.name = "Aaron", .password = "Aaron", .email = "aaron@example.com", .Avatar = Image})
            db.Users.Add(New User With {.name = "Bob", .password = "Bob", .email = "Bob@example.com", .Avatar = Image})
            db.SaveChanges()
#End Region

#Region "Comments"
            'db.Users.First.Comments.Add(New Comment With {.Place_Id = db.Places.Find.Id, .text = "Hello World", .Date = Now})
            'db.Places.First.Comments.Add(New Comment With {.text = "Hello World 2", .Date = Now})
            db.Comments.Add(New Comment With {.uid = db.Users.Find.Id, .pid = db.Places.Find.Id, .text = "Hello Test", .Date = Now})
            db.SaveChanges()
#End Region

#Region "Reviews"
            db.Reviews.Add(New Review With {.pid = db.Places.Find.Id, .uid = db.Users.Find.Id, .review = "Hello World"})
            db.SaveChanges()
#End Region

#Region "Visits"
            'Dim Visits1 As New Visit
            'Visits1.Places.Add(db.Places.First)
            'Visits1.Users.Add(db.Users.First)
            db.Visits.Add(New Visit With {.pid = db.Places.Find.Id, .uid = db.Users.Find.Id})
            db.SaveChanges()
#End Region
            Return Redirect(NameOf(Index))
        End Function

    End Class
End Namespace