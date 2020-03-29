using System;

namespace Domain.Exercises.Aspects
{
    public class Answer : IAnswer
    {
        private readonly IAnswerAspect _aspect;
        public Answer(IAnswerAspect aspect)
        {
            _aspect = aspect;
        }
        public string AnswerCode { get => _aspect.AnswerCode; set => _aspect.AnswerCode = value; }
        public string AnswerSolution { get => _aspect.AnswerSolution; set => _aspect.AnswerSolution = value; }
        public string AnswerImageName { get => _aspect.AnswerImageName; set => _aspect.AnswerImageName = value; }
        public string AnswerComments { get => _aspect.AnswerComments; set => _aspect.AnswerComments = value; }
        public DateTime AnswerCreatedOn { get => _aspect.AnswerCreatedOn; set => _aspect.AnswerCreatedOn = value; }
    }
}
