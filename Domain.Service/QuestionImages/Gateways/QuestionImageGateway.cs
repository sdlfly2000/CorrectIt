using Common.Core.DependencyInjection;
using Domain.QuestionImages;
using Domain.Services.QuestionImages.Gateways.Criteria;
using Domain.Services.QuestionImages.Gateways.Loaders;
using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;
using Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers;

namespace Domain.Services.QuestionImages.Gateways
{
    [ServiceLocate(typeof(IQuestionImageGateway))]
    public class QuestionImageGateway : IQuestionImageGateway
    {
        private readonly IQuestionImageAspectLoader _questionImageAspectLoader;
        private readonly IQuestionImageSynchronizer _imageSynchronizer;

        public QuestionImageGateway(
            IQuestionImageAspectLoader questionImageAspectLoader,
            IQuestionImageSynchronizer imageSynchronizer)
        {
            _questionImageAspectLoader = questionImageAspectLoader;
            _imageSynchronizer = imageSynchronizer;
        }

        public QuestionImage Load(GetByQuestionCodeCriterion criterion)
        {
            return new QuestionImage(_questionImageAspectLoader.Load(criterion));
        }

        public QuestionImageResponse Create(CreateQuestionImageRequest reqeust)
        {
            return _imageSynchronizer.Create(reqeust);
        }
    }
}
