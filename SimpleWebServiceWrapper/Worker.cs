using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SimpleWebServiceWrapper
{
   public class Worker : BackgroundService
   {
      private readonly ILogger<Worker> _logger;

      public Worker(ILogger<Worker> logger)
      {
         _logger = logger;
      }

      // This is just an example showing how to have a Worker on the Windows Service
      protected override async Task ExecuteAsync(CancellationToken stoppingToken)
      {
         while (!stoppingToken.IsCancellationRequested)
         {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
         }
      }
   }
}
