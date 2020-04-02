using Microsoft.AspNetCore.Mvc;
using SimpleWebServiceWrapper.WebServer.Helpers;
using SimpleWebServiceWrapper.WebServer.Models;
using System.Net.Mime;

namespace SimpleWebServiceWrapper.WebServer.Controllers
{
   [Produces(MediaTypeNames.Application.Json)]
   [ApiController]
   [Route("[controller]")]
   public class ApplicationInfoController : ControllerBase
   {
      [HttpGet]
      public IActionResult GetApplicationInfo()
      {
         return Ok(new ApplicationInfoModel
         {
            ProductName = AppHelper.GetProductName(),
            CurrentVersion = AppHelper.GetVersionNumber(),
            BuildTimestamp = AppHelper.GetBuildTimeStamp()
         });
      }
   }
}
