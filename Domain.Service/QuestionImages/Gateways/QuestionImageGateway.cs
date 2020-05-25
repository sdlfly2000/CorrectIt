using Common.Core.DependencyInjection;
using Domain.QuestionImages;
using Domain.Services.QuestionImages.Gateways.Criteria;
using Domain.Services.QuestionImages.Gateways.Loaders;

namespace Domain.Services.QuestionImages.Gateways
{
    using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;
    using Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers;

    [ServiceLocate(typeof(IQuestionImageGateway))]
    public class QuestionImageGateway : IQuestionImageGateway
    {
        private readonly IQuestionImageAspectLoader _questionImageAspectLoader;
        private readonly IQuestionImageSynchronizer _questionImageSynchronizer;

        public QuestionImageGateway(
            IQuestionImageAspectLoader questionImageAspectLoader,
            IQuestionImageSynchronizer questionImageSynchronizer)
        {
            _questionImageAspectLoader = questionImageAspectLoader;
            _questionImageSynchronizer = questionImageSynchronizer;
        }

        public QuestionImage Load(GetByQuestionCodeCriterion criterion)
        {
            return new QuestionImage(_questionImageAspectLoader.Load(criterion));
        }

        public QuestionImageResponse Create(CreateQuestionImageRequest request)
        {
            return _questionImageSynchronizer.Create(request);
        }
    }
}
