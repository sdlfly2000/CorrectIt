using System.Collections.Generic;
using Common.Core.DependencyInjection;
using Domain.Exercises.Aspects;
using Domain.Service.Exercises.Gateways.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Domain.Service.Exercises.Loaders;
using Infrastructure.Data.Sql.Questions;
using System.Reflection;
using Common.Core.AOP;

namespace Domain.Services.Exercises.Gateways.Loaders.Proxies
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoaderProxy : IQuestionAspectLoader
    {
        private QuestionAspectLoader _questionAspectLoader;

        private IQuestionAspectLoader _quotationQuestionAspectLoaderDecorator;

        public QuestionAspectLoaderProxy(
            IQuestionAspectMapper mappper,
            IQuestionRepository repository)
        {
            _questionAspectLoader = new QuestionAspectLoader(mappper, repository);

            _quotationQuestionAspectLoaderDecorator = DispatchProxy.Create<IQuestionAspectLoader, CacheProxy>();
            ((CacheProxy)_quotationQuestionAspectLoaderDecorator).Wrapped = _questionAspectLoader;
  
            ((CacheProxy)_quotationQuestionAspectLoaderDecorator).GetCache = (m, o) => new object();
            ((CacheProxy)_quotationQuestionAspectLoaderDecorator).SetCache = (t, x) => new object();
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
