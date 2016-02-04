using Microsoft.Owin;
using CSOD_OWIN_ASP.NET_Web_API_VS20151;
using Owin;

//using CSOD_OWIN_ASP.NET_Web_API_VS20151;

[assembly: OwinStartup(typeof(Startup))]
namespace CSOD_OWIN_ASP.NET_Web_API_VS20151
{
     using System.Web.Http;
     using Microsoft.Owin;
     using Microsoft.Owin.Extensions;
     using Microsoft.Owin.FileSystems;
     using System.Diagnostics;

     public class Startup : Cornerstone.Platform.Owin.IOwinAppBuilder
     {
          public Startup()
          {
               Trace.WriteLine("Owin Startup instantiated...");
          }

          public void Configuration(IAppBuilder app)
          {

               Trace.WriteLine("Owin Startup config called...");

               var httpConfiguration = new HttpConfiguration();

               // Configure Web API Routes:
               // - Enable Attribute Mapping
               // - Enable Default routes at /api.
               httpConfiguration.MapHttpAttributeRoutes();
               httpConfiguration.Routes.MapHttpRoute(
                   name: "DefaultApi",
                   routeTemplate: "api/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
               );

               app.UseWebApi(httpConfiguration);
          }
     }
}
