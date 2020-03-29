using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Mappers;
using Infrastructure.Data.SqlServer;
using System.Linq;

namespace Domain.Service.Exercises.Loaders
{
    [ServiceLocate(typeof(IAnswerAspectLoader))]
    public class AnswerAspectLoader : IAnswerAspectLoader
    {
        private readonly IAnswerAspectMapper _aspectMapper;
        private readonly ICorrectItDbContext _context;
        public AnswerAspectLoader(
            IAnswerAspectMapper aspectMapper,
            ICorrectItDbContext context)
        {
            _context = context;
            _aspectMapper = aspectMapper;
        }

        public AnswerAspect Load(string answerCode)
        {
            var answerEntity = _context.Answers.FirstOrDefault(a => a.AnswerId.Equals(answerCode));
            return _aspectMapper.Map(answerEntity);
        }
    }
}
