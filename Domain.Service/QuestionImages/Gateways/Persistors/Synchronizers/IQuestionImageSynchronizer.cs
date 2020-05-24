using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers
{
    public interface IQuestionImageSynchronizer
    {
        QuestionImageResponse Create(CreateQuestionImageRequest request);
    }
}