using Domain.Services.QuestionImages.Gateways.Persistors.Requests;
using Domain.Services.QuestionImages.Gateways.Persistors.Responses;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Synchronizers
{
    public interface IQuestionImageSynchronizer
    {
        SaveQuestionImageResponse Save(SaveQuestionImageRequest request);
    }
}