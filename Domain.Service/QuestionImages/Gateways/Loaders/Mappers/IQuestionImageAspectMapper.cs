using Domain.QuestionImages.Aspects;
using Infrastructure.Data.Sql.Images;

namespace Domain.Services.QuestionImages.Gateways.Loaders.Mappers
{
    public interface IQuestionImageAspectMapper
    {
        QuestionImageAspect Map(ImageEntity entity);
    }
}