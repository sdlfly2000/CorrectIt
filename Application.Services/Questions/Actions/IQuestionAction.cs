using Application.Services.Questions.Models;
using System.Collections.Generic;

namespace Application.Services.Questions.Actions
{
    public interface IQuestionAction
    {
        IEnumerable<QuestionModel> Get();
    }
}