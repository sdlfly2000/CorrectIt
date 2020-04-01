using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.SqlServer;
using System.Linq;

namespace Domain.Service.Exercises.Loaders
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoader : IQuestionAspectLoader
    {
        private ICorrectItDbContext _context;
        private IQuestionAspectMapper _mapper;

        public QuestionAspectLoader(
            IQuestionAspectMapper mappper,
            ICorrectItDbContext context)
        {
            _context = context;
            _mapper = mappper;
        }

        public QuestionAspect Load(string code)
        {
            return _mapper.Map(_context.Questions.FirstOrDefault(q => q.QuestionId.ToString().Equals(code)));
        }
    }
}
