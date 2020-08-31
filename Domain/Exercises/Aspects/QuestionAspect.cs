using Common.Core.AOP;
using System;
using System.Collections.Generic;

namespace Domain.Exercises.Aspects
{
    public class QuestionAspect : IQuestionAspect, ICacheAspect
    {
        public string QuestionCode { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionTitle { get; set; }
        public DateTime QuestionCreatedOn { get; set; }
        public string QuestionCreatedBy { get; set; }
        public string QuestionComments { get; set; }
        public List<IAnswer> Answers { get; set; } = new List<IAnswer>();

        public string Code { get => QuestionCode; }
    }
}
