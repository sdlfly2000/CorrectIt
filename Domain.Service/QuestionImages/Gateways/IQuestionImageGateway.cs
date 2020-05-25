using Domain.QuestionImages;
using GetByQuestionCodeCriterion = Domain.Services.QuestionImages.Gateways.Criteria.GetByQuestionCodeCriterion;

namespace Domain.Services.QuestionImages.Gateways
{
    using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;

    public interface IQuestionImageGateway
    {
        QuestionImage Load(GetByQuestionCodeCriterion criterion);

        QuestionImageResponse Create(CreateQuestionImageRequest request);
    }
}
