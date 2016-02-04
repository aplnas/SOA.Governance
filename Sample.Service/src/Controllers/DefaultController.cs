//namespace CSOD_OWIN_ASP.NET_Web_API1.Controllers
namespace CSOD_OWIN_ASP.NET_Web_API_VS20151
{
     using System.Web.Http;


     public class DefaultController : ApiController
     {
          [Route("ping")]
          [HttpGet]
          public string ping()
          {
               return "pong";
          }

          [Route("GetSampleEmployee")]
          [HttpGet]
          public SampleEmployee GetSampleEmployee()
          {
               return new SampleEmployee() { FirstName = "John", LastName = "Doe" };
          }


     }
}
