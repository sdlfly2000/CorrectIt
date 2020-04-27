using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.Sql;
using System.Collections.Generic;
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

        public IQuestionAspect Load(string code)
        {
            return _mapper.Map(_context.Questions.FirstOrDefault(q => q.QuestionId.ToString().Equals(code)));
        }

        public List<IQuestionAspect> LoadAll()
        {
            var entities = _context.Questions.ToList();

            return entities.Select(e => _mapper.Map(e)).ToList<IQuestionAspect>();
        }
    }
}
