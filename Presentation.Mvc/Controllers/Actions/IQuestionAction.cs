using Presentation.Mvc.Models.Questions;
using System.Collections.Generic;

namespace Presentation.Mvc.Controllers.Actions
{
    public interface IQuestionAction
    {
        IEnumerable<QuestionModel> Get();
    }
}