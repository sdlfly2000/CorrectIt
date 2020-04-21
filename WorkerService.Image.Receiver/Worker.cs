using System;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkerService.Image.Receiver;
using Common.Core.TcpServer;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService.Image.Receiver
{
    public class Worker : BackgroundService
    {
        private const int ListenPort = 1215;

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
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(2000, stoppingToken);
            //}
            var tcpServer = new AsyncTCPServer(1215);
            tcpServer.Start();
        }
    }
}
