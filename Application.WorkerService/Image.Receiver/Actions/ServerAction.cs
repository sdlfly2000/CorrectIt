using Application.WorkerService.Image.Receiver.Contracts;
using Common.Core.DependencyInjection;
using Common.Core.TcpServer;

namespace Application.WorkerService.Image.Receiver.Actions
{
    [ServiceLocate(typeof(IServerAction))]
    public class ServerAction : IServerAction
    {
        private int ListenPort = 1215;
        private AsyncTCPServer _tcpListener;

        public ServerAction(IImageReceivedHandler imageReceivedHandler)
        {
            _tcpListener = new AsyncTCPServer(ListenPort);
            _tcpListener.SetHandleReceivedData(imageReceivedHandler);
        }

        public void StratListen()
        {
            _tcpListener.Start();
        }

        public void StopListen()
        {
            _tcpListener.Stop();
        }
    }
}
