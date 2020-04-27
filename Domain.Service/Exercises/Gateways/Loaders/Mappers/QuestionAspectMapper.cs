using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Infrastructure.Data.Sql.Questions;
using System.Linq;

namespace Domain.Service.Exercises.Gateways.Loaders.Mappers
{
    [ServiceLocate(typeof(IQuestionAspectMapper))]
    public class QuestionAspectMapper : IQuestionAspectMapper
    {
        private readonly IAnswerAspectMapper _answerMapper;

        public QuestionAspectMapper(
            IAnswerAspectMapper answerMapper)
        {
            _answerMapper = answerMapper;
        }

        public QuestionAspect Map(QuestionEntity entity)
        {
            return new QuestionAspect
            {
                QuestionTitle = entity.QuestionTitle,
                QuestionCategory = entity.QuestionCategory,
                QuestionCode = entity.QuestionId.ToString(),
                QuestionComments = entity.QuestionComments,
                QuestionCreatedBy = entity.QuestionCreatedBy,
                QuestionCreatedOn = entity.QuestionCreatedOn,
                Answers = entity.Answers != null
                           ? entity.Answers.Select(a => new Answer(_answerMapper.Map(a))).ToList<IAnswer>()
                           : null
            };
        }
    }
}
