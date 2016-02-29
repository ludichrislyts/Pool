Imports System.Web.Http
Imports System.Web.Optimization

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        Dim myScriptResDef As New ScriptResourceDefinition()
        myScriptResDef.Path = "~/Scripts/jquery-1.10.2.min.js"
        myScriptResDef.DebugPath = "~/Scripts/jquery-1.10.2.js"
        myScriptResDef.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.min.js"
        myScriptResDef.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.2.js"
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", Nothing, myScriptResDef)
    End Sub
End Class