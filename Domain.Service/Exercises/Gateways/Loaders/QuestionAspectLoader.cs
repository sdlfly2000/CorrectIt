using Common.Core.Cache;
using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.Sql.Questions;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Service.Exercises.Loaders
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoader : IQuestionAspectLoader
    {
        private IQuestionRepository _repository;
        private IQuestionAspectMapper _mapper;

        public QuestionAspectLoader(
            IQuestionAspectMapper mappper,
            IQuestionRepository repository)
        {
            _repository = repository;
            _mapper = mappper;
        }

        [AspectCache(typeof(IQuestionAspectLoader))]
        public IQuestionAspect Load(string code)
        {
            return _mapper.Map(_repository.LoadAll().FirstOrDefault(q => q.QuestionId.ToString().Equals(code)));
        }

        public List<IQuestionAspect> LoadAll()
        {
            var entities = _repository.LoadAll();

            return entities.Select(e => _mapper.Map(e)).ToList<IQuestionAspect>();
        }
    }
}
