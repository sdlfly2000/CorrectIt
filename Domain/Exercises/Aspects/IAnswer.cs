using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercises.Aspects
{
    public interface IAnswer
    {
        string AnswerCode { get; set; }
        string AnswerSolution { get; set; }
        string AnswerImageName { get; set; }
        string AnswerComments { get; set; }
        DateTime AnswerCreatedOn { get; set; }
    }
}
