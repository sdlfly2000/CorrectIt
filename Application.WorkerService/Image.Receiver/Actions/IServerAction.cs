namespace Application.WorkerService.Image.Receiver.Actions
{
    public interface IServerAction
    {
        void StopListen();
        void StratListen();
    }
}