namespace Application.WorkerService.Image.Receiver.Actions
{
    public interface IServerAction
    {
        void Stop();
        void StratListening(int port);
    }
}