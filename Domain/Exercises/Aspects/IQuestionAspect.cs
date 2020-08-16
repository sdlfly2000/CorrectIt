using Common.Core.Cache;
using System;
using System.Collections.Generic;

namespace Domain.Exercises.Aspects
{
    public interface IQuestionAspect : ICache
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
