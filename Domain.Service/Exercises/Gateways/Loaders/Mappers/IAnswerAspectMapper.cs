using Domain.Exercises.Aspects;
using Infrastructure.Data.SqlServer.Answers;

namespace Domain.Service.Exercises.Gateways.Loaders.Mappers
{
    public interface IAnswerAspectMapper
    {
        IAnswerAspect Map(AnswerEntity entity);
    }
}