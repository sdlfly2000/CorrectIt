using Domain.Exercises.Aspects;

namespace Domain.Service.Exercises.Gateways.Loaders
{
    public interface IQuestionAspectLoader
    {
        QuestionAspect Load(string code);
    }
}