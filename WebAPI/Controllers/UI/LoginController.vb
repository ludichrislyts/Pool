Imports System.Web.Mvc

Namespace WebAPI
    Public Class LoginController
        Inherits System.Web.UI.Page
        Dim login = New ViewPage()

        ' GET: Login
        Function Index() As ActionResult
            Return login
        End Function
    End Class
End Namespace