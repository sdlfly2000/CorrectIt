using Domain.Exercises;
using Domain.Exercises.Aspects;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Exercise : IExercise
    {
        private readonly IQuestionAspect _questionAspect;
        private List<IAnswer> _answers;
        public Exercise(
            IQuestionAspect questionAspect, 
            List<IAnswer> answers)
        {
            _questionAspect = questionAspect;
            _answers = answers ?? new List<IAnswer>();
        }

        public string QuestionCode { get => _questionAspect.QuestionCode; set => _questionAspect.QuestionCode = value; }
        public string QuestionCategory { get => _questionAspect.QuestionCategory; set => _questionAspect.QuestionCategory = value; }
        public string QuestionTitle { get => _questionAspect.QuestionTitle; set => _questionAspect.QuestionTitle = value; }
        public DateTime QuestionCreatedOn { get => _questionAspect.QuestionCreatedOn; set => _questionAspect.QuestionCreatedOn = value; }
        public string QuestionCreatedBy { get => _questionAspect.QuestionCreatedBy; set => _questionAspect.QuestionCreatedBy = value; }
        public string QuestionComments { get => _questionAspect.QuestionComments; set => _questionAspect.QuestionComments = value; }
        public List<IAnswer> Answers { get => _answers; set => _answers = value; }
    }
}
