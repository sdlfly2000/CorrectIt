using Domain.Exercises.Aspects;

namespace Domain.Service.Exercises.Gateways.Loaders
{
    public interface IAnswerAspectLoader
    {
        IAnswerAspect Load(string answerCode);
    }
}