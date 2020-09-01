using System;
using System.Collections.Generic;
using Common.Core.AOP;

namespace Domain.Exercises.Aspects
{
    public interface IQuestionAspect : ICacheAspect
    {
        string QuestionCode { get; set; }
        string QuestionCategory { get; set; }
        string QuestionTitle { get; set; }
        DateTime QuestionCreatedOn { get; set; }
        string QuestionCreatedBy { get; set; }
        string QuestionComments { get; set; }
        List<IAnswer> Answers { get; set; }
    }
}
