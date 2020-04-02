using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebServiceWrapper.WebServer.Models
{
   public class ApplicationInfoModel
   {
      public string ProductName { get; set; }
      public string CurrentVersion { get; set; }
      public DateTime BuildTimestamp { get; set; }
   }
}
