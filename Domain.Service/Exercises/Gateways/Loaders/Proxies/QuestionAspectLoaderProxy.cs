using System.Collections.Generic;
using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Domain.Service.Exercises.Loaders;
using Infrastructure.Data.Sql.Questions;
using System.Reflection;
using Common.Core.AOP;
using Microsoft.Extensions.Caching.Memory;

namespace Domain.Services.Exercises.Gateways.Loaders.Proxies
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoaderProxy : IQuestionAspectLoader
    {
        private QuestionAspectLoader _questionAspectLoader;

        private IQuestionAspectLoader _quotationQuestionAspectLoaderDecorator;

        public QuestionAspectLoaderProxy(
            IQuestionAspectMapper mappper,
            IQuestionRepository repository,
            IMemoryCache memoryCache)
        {
            _questionAspectLoader = new QuestionAspectLoader(mappper, repository);

            _quotationQuestionAspectLoaderDecorator = DispatchProxy.Create<IQuestionAspectLoader, CacheProxy>();
            ((CacheProxy)_quotationQuestionAspectLoaderDecorator).Wrapped = _questionAspectLoader;
            ((CacheProxy)_quotationQuestionAspectLoaderDecorator).CacheAction = new CacheAction<IQuestionAspect>(memoryCache);
        }

        public IQuestionAspect Load(string code)
        {
            return _quotationQuestionAspectLoaderDecorator.Load(code);
        }

        public IList<IQuestionAspect> LoadAll()
        {
            return _quotationQuestionAspectLoaderDecorator.LoadAll();
        }
    }
}
