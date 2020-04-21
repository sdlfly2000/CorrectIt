using Common.Core.DependencyInjection;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Application.WorkerService.Image.Receiver.Actions
{
    [ServiceLocate(typeof(IServerAction))]
    public class ServerAction : IServerAction
    {
        private const int BufferSize = 512;
        private byte[] DataReceived;
        private TcpListener _tcpListener;

        public ServerAction()
        {
            DataReceived = new byte[BufferSize];
        }

        public void StratListening(int port)
        {
            _tcpListener = TcpListener.Create(port);

            Console.WriteLine(string.Format("Start to Listening at Port: {0}", port));

            _tcpListener.Start();

            while (true) 
            {
                if (_tcpListener.Pending())
                {
                    Task.Run(async () =>
                    {
                        var socketAsync = await _tcpListener.AcceptSocketAsync();
                        var numReceived = socketAsync.Receive(DataReceived);
                        Console.WriteLine(Encoding.UTF8.GetString(DataReceived));
                        socketAsync.Close();
                    });
                }

                Task.Delay(1000);
            }
        }

        public void Stop()
        {
            _tcpListener.Stop();
        }
    }
}
