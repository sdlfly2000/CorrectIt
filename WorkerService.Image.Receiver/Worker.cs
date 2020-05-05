using System.Threading;
using System.Threading.Tasks;
using Application.WorkerService.Image.Receiver;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService.Image.Receiver
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IImageReceiverServer _imageReceiverServer;

        public Worker(
            ILogger<Worker> logger,
            IImageReceiverServer imageReceiverServer)
        {
            _logger = logger;
            _imageReceiverServer = imageReceiverServer;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _imageReceiverServer.Start();
        }
    }
}
