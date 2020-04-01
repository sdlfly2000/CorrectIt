using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Infrastructure.Data.SqlServer.Answers;

namespace Domain.Service.Exercises.Gateways.Loaders.Mappers
{
    [ServiceLocate(typeof(IAnswerAspectMapper))]
    public class AnswerAspectMapper : IAnswerAspectMapper
    {
        public AnswerAspectMapper()
        {
        }

        public IAnswerAspect Map(AnswerEntity entity)
        {
            return new AnswerAspect
            {
                AnswerCode = entity.AnswerId.ToString(),
                AnswerSolution = entity.AnswerSolution,
                AnswerImageName = entity.AnswerImageName,
                AnswerComments = entity.AnswerComments,
                AnswerCreatedOn = entity.AnswerCreatedOn
            };
        }
    }
}
