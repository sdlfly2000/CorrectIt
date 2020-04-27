using Domain.Exercises.Aspects;
using Infrastructure.Data.Sql.Questions;

namespace Domain.Service.Exercises.Gateways.Loaders.Mappers
{
    public interface IQuestionAspectMapper
    {
        QuestionAspect Map(QuestionEntity entity);
    }
}