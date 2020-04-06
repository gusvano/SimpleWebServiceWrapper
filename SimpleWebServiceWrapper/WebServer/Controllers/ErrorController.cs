using Microsoft.AspNetCore.Mvc;
using SimpleWebServiceWrapper.WebServer.Models;
using System.Net.Mime;

namespace SimpleWebServiceWrapper.WebServer.Controllers
{
   [Produces(MediaTypeNames.Application.Json)]
   public class ErrorController : ControllerBase
   {
      [HttpGet]
      [Route("{*url}", Order = 999)]
      public IActionResult InvalidResource()
      {
         string url = $"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}";
         MessageModel message = new MessageModel
         {
            Message = $"No HTTP resource was found that matches the request URI '{url}'."
         };
         return NotFound(message);
      }
   }
}
