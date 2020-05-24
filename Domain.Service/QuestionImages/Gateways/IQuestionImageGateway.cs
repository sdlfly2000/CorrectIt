using Domain.QuestionImages;
using Domain.Services.QuestionImages.Gateways.Persistors.Contracts;
using GetByQuestionCodeCriterion = Domain.Services.QuestionImages.Gateways.Criteria.GetByQuestionCodeCriterion;

namespace Domain.Services.QuestionImages.Gateways
{
    public interface IQuestionImageGateway
    {
        QuestionImage Load(GetByQuestionCodeCriterion criterion);
        QuestionImageResponse Save(CreateQuestionImageRequest reqeust);
    }
}
