using System.Collections.Generic;

namespace Application.Services.Questions.Contractors
{
    public class QuestionsRequest
    {
        public QuestionsRequest()
        {
            QuestionCodes = new List<string>();
        }

        public List<string> QuestionCodes { get; set; }
    }
}
