using System;

namespace Domain.Exercises.Aspects
{
    public interface IAnswerAspect
    {
        string AnswerCode { get; set; }
        string AnswerSolution { get; set; }
        string AnswerImageName { get; set; }
        string AnswerComments { get; set; }
        DateTime AnswerCreatedOn { get; set; }
    }
}
