using Domain.QuestionImages;
using GetByQuestionCodeCriterion = Domain.Services.QuestionImages.Gateways.Criteria.GetByQuestionCodeCriterion;

namespace Domain.Services.QuestionImages.Gateways
{
    public interface IQuestionImageGateway
    {
        QuestionImage Load(GetByQuestionCodeCriterion criterion);
    }
}
