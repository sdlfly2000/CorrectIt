using Domain.Exercises.Aspects;
using Infrastructure.Data.SqlServer.Answers;

namespace Domain.Service.Exercises.Mappers
{
    public interface IAnswerAspectMapper
    {
        AnswerAspect Map(AnswerEntity entity);
    }
}