using Common.Core.DependencyInjection;
using Domain.QuestionImages.Aspects;
using Domain.Services.QuestionImages.Gateways.Criteria;
using System;

namespace Domain.Services.QuestionImages.Gateways.Loaders
{
    [ServiceLocate(typeof(IQuestionImageAspectLoader))]
    public class QuestionImageAspectLoader : IQuestionImageAspectLoader
    {
        public QuestionImageAspectLoader()
        {

        }

        public QuestionImageAspect Load(GetByQuestionCodeCriterion criterion)
        {
            throw new NotImplementedException();
        }
    }
}
