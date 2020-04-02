using System;
using System.Reflection;

namespace SimpleWebServiceWrapper.WebServer.Helpers
{
   public static class AppHelper
   {
      public static string GetVersionNumber()
      {
         return typeof(AppHelper).Assembly.GetName().Version.ToString();
      }

      public static DateTime GetBuildTimeStamp(Assembly assembly = null)
      {
         if (assembly == null)
         {
            assembly = Assembly.GetExecutingAssembly();
         }

         Version version = assembly.GetName().Version;

         return new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.MinorRevision * 2);
      }

      public static string GetProductName(Assembly assembly = null)
      {
         if (assembly == null)
         {
            assembly = Assembly.GetExecutingAssembly();
         }

         return assembly.GetName().Name;
      }
   }
}
