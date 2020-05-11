using Domain.QuestionImages.Aspects;
using Domain.Services.QuestionImages.Gateways.Criteria;

namespace Domain.Services.QuestionImages.Gateways.Loaders
{
    public interface IQuestionImageAspectLoader
    {
        QuestionImageAspect Load(GetByQuestionCodeCriterion criterion);
    }
}
