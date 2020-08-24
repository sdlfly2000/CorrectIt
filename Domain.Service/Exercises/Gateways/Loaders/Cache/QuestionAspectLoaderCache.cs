using Domain.Service.Exercises.Loaders;
using Domain.Service.Exercises.Gateways.Loaders.Mappers;
using Infrastructure.Data.Sql.Questions;
using Common.Core.DependencyInjection;
using Domain.Service.Exercises.Gateways.Loaders;
using System;
using System.Collections.Generic;

namespace Domain.Exercises.Aspects.Cache
{
    [ServiceLocate(typeof(IQuestionAspectLoader))]
    public class QuestionAspectLoaderCache : QuestionAspectLoader, ICacheProxy<IQuestionAspect>
    {
        public QuestionAspectLoaderCache(IQuestionAspectMapper mappper, IQuestionRepository repository)
            : base(mappper, repository)
        {
        }

        public override IList<IQuestionAspect> LoadAll()
        {
            var questionAspects = new List<IQuestionAspect>();
            questionAspects = (List<IQuestionAspect>)base.LoadAll();

            return questionAspects;
        }

        public override IQuestionAspect Load(string code)
        {
            return base.Load(code);
        }

        public IQuestionAspect Before(string Code)
        {
            throw new NotImplementedException();
        }

        public IQuestionAspect SetCache(string key, IQuestionAspect value)
        {
            throw new NotImplementedException();
        }

        public IQuestionAspect GetCache(string key)
        {
            throw new NotImplementedException();
        }
    }
}
