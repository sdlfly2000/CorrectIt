using Domain.Service.Exercises.Gateways.Criteria;

namespace Domain.Service.Exercises.Gateways
{
    public interface IExcerciseGateway
    {
        Exercise Load(GetByQuestionCodeCriterion criterion);
    }
}