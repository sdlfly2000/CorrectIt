using Application.Questions.Models;
using System.Collections.Generic;

namespace Application.Services.Questions.Contractors
{
    public class QuestionsResponse
    {
        public QuestionsResponse()
        {
            QuestionModels = new List<QuestionModel>();
        }

        public List<QuestionModel> QuestionModels { get; set; }
    }
}
