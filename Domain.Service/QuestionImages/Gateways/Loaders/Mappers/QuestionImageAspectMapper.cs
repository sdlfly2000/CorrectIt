using Infrastructure.Data.Sql.Images;
using Common.Core.DependencyInjection;
using Domain.QuestionImages.Aspects;

namespace Domain.Services.QuestionImages.Gateways.Loaders.Mappers
{
    [ServiceLocate(typeof(IQuestionImageAspectMapper))]
    public class QuestionImageAspectMapper : IQuestionImageAspectMapper
    {
        public QuestionImageAspect Map(ImageEntity entity)
        {
            return new QuestionImageAspect
            {
                ImageId = entity.ImageId,
                ImageFileName = entity.ImageFileName,
                ImageCreatedOn = entity.ImageCreatedOn,
                ImageCreatedBy = entity.ImageCreatedBy,
                ImageStatus = entity.ImageStatus,
                ImageComments = entity.ImageStatus,
                ImageCategory = entity.ImageCategory
            };
        }
    }
}
