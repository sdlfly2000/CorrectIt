using Common.Core.DependencyInjection;
using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;
using Infrastructure.Data.File.ImageFiles;
using Infrastructure.Data.Sql.Images;
using System;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers
{
    [ServiceLocate(typeof(IQuestionImageSynchronizer))]
    public class QuestionImageSynchronizer : IQuestionImageSynchronizer
    {
        private readonly IImageRepository _repository;
        private readonly IImageFilePersistor _imageFilePersistor;

        public QuestionImageSynchronizer(
            IImageRepository repository,
            IImageFilePersistor imageFilePersistor)
        {
            _repository = repository;
            _imageFilePersistor = imageFilePersistor;
        }

        public QuestionImageResponse Create(CreateQuestionImageRequest request)
        {
            var imageId = _imageFilePersistor.SaveToDisk(request.ImageData, request.ImageWidth, request.ImageHeight);

            var entity = new ImageEntity
            {
                ImageCategory = request.ImageCategory,
                ImageComments = request.ImageComments,
                ImageCreatedBy = request.ImageCreatedBy,
                ImageCreatedOn = DateTime.Now,
                ImageFileName = request.ImageFileName,
                ImageStatus = "Valid",
                ImageId = imageId,
                QuestionId = request.QuestionId,
            };

            _repository.Persist(entity);
            
            return new QuestionImageResponse();
        }
    }
}
