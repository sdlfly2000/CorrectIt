using System;

namespace Domain.Exercises.Aspects
{
    public interface IQuestionAspect
    {
        string QuestionCode { get; set; }
        string QuestionCategory { get; set; }
        string QuestionTitle { get; set; }
        DateTime QuestionCreatedOn { get; set; }
        string QuestionCreatedBy { get; set; }
        string QuestionComments { get; set; }
    }
}
