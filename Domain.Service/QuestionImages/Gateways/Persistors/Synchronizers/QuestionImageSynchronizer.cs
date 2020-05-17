using Common.Core.DependencyInjection;
using Domain.Services.QuestionImages.Gateways.Persistors.Requests;
using Domain.Services.QuestionImages.Gateways.Persistors.Responses;
using Infrastructure.Data.Sql.Images;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers
{
    [ServiceLocate(typeof(IQuestionImageSynchronizer))]
    public class QuestionImageSynchronizer : IQuestionImageSynchronizer
    {
        private readonly IImageRepository _repository;

        public QuestionImageSynchronizer(IImageRepository repository)
        {
            _repository = repository;
        }

        public SaveQuestionImageResponse Save(SaveQuestionImageRequest request)
        {
            var entity = new ImageEntity
            {

            };

            _repository.Create(entity);
            return new SaveQuestionImageResponse();
        }
    }
}
