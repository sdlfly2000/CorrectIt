using Common.Core.DependencyInjection;
using Domain.QuestionImages;
using Domain.Services.QuestionImages.Gateways.Criteria;
using Domain.Services.QuestionImages.Gateways.Loaders;

namespace Domain.Services.QuestionImages.Gateways
{
    [ServiceLocate(typeof(IQuestionImageGateway))]
    public class QuestionImageGateway : IQuestionImageGateway
    {
        private readonly IQuestionImageAspectLoader _questionImageAspectLoader;
        public QuestionImageGateway(IQuestionImageAspectLoader questionImageAspectLoader)
        {
            _questionImageAspectLoader = questionImageAspectLoader;
        }

        public QuestionImage Load(GetByQuestionCodeCriterion criterion)
        {
            return new QuestionImage(_questionImageAspectLoader.Load(criterion));
        }
    }
}
