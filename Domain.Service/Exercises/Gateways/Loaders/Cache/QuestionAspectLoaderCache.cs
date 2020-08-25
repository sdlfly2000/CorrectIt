using Domain.Service.Exercises.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.Sql.Questions;
using Common.Core.DependencyInjection;
using Domain.Service.Exercises.Gateways.Loaders;
using System;
using System.Collections.Generic;
using Common.Core.Cache;

namespace Domain.Exercises.Aspects.Cache
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoaderCache : QuestionAspectLoader, ICacheProxy<IQuestionAspect>
    {
        private readonly ICacheServiceFactory _cacheServiceFactory;

        public QuestionAspectLoaderCache(
            IQuestionAspectMapper mappper, 
            IQuestionRepository repository,
            ICacheServiceFactory cacheServiceFactory)
            : base(mappper, repository)
        {
            _cacheServiceFactory = cacheServiceFactory;
        }

        public override IList<IQuestionAspect> LoadAll()
        {
            var questionAspects = new List<IQuestionAspect>();
            questionAspects = (List<IQuestionAspect>)base.LoadAll();

            return questionAspects;
        }

        public override IQuestionAspect Load(string code)
        {
            var questionAspect = GetCache(code);
            if (questionAspect != null)
            {
                return questionAspect;
            }

            questionAspect = base.Load(code);
            SetCache(code, questionAspect);

            return questionAspect;
        }

        public void SetCache(string key, IQuestionAspect value)
        {
            _cacheServiceFactory.Set(key, value);
        }

        public IQuestionAspect GetCache(string key)
        {
            return (QuestionAspect)_cacheServiceFactory.Get(key);
        }
    }
}
