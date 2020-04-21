namespace Application.WorkerService.Image.Receiver
{
    public interface IImageReceiverServer
    {
        void Start(int port);
        void Stop();
    }
}