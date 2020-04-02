using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleWebServiceWrapper.WebServer;

namespace SimpleWebServiceWrapper
{
   public class Program
   {
      public static void Main(string[] args)
      {
         CreateHostBuilder(args).Build().Run();
      }

      public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder => {
                 webBuilder.UseStartup<Startup>();
              })
              .ConfigureServices((hostContext, services) =>
              {
                 services.AddHostedService<Worker>();
              });
   }
}
