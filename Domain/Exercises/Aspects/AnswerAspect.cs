using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercises.Aspects
{
    public class AnswerAspect : IAnswerAspect
    {
        public string AnswerCode { get; set; }
        public string AnswerSolution { get; set; }
        public string AnswerImageName { get; set; }
        public string AnswerComments { get; set; }
        public DateTime AnswerCreatedOn { get; set; }
    }
}
