using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using SimpleWebServiceWrapper.WebServer.Models;

namespace SimpleWebServiceWrapper.WebServer.Controllers
{
   [Produces(MediaTypeNames.Application.Json)]
   [ApiController]
   [Route("[controller]")]
   public class TestPostController : ControllerBase
   {
      [HttpPost("/TestPost")]
      [Consumes(MediaTypeNames.Application.Json)]
      public IActionResult TestPost(MessageModel message)
      {
         return Ok(message);
      }
   }
}