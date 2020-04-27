using Domain.Exercises.Aspects;
using Infrastructure.Data.Sql.Answers;

namespace Domain.Service.Exercises.Gateways.Loaders.Mappers
{
    public interface IAnswerAspectMapper
    {
        IAnswerAspect Map(AnswerEntity entity);
    }
}