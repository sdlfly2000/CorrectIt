using Application.WorkerService.Image.Receiver.Actions;
using Common.Core.DependencyInjection;

namespace Application.WorkerService.Image.Receiver
{
    [ServiceLocate(typeof(IImageReceiverServer))]
    public class ImageReceiverServer : IImageReceiverServer
    {
        private readonly IServerAction _serverAction;

        public ImageReceiverServer(IServerAction serverAction)
        {
            _serverAction = serverAction;
        }

        public void Start(int port)
        {
            _serverAction.StratListening(port);
        }

        public void Stop()
        {
        }
    }
}
