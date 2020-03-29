using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercises.Aspects
{
    public class QuestionAspect : IQuestionAspect
    {
        public string QuestionCode { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionTitle { get; set; }
        public DateTime QuestionCreatedOn { get; set; }
        public string QuestionCreatedBy { get; set; }
        public string QuestionComments { get; set; }
    }
}
