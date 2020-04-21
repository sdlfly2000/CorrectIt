using Application.Questions.Models;
using Application.Services.Questions.Contractors;
using Common.Core.DependencyInjection;
using Domain.Exercises;
using Domain.Service.Exercises.Gateways;
using Domain.Service.Exercises.Gateways.Criteria;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services.Questions.Processes
{
    [ServiceLocate(typeof(IQuestionProcess))]
    public class QuestionProcess : IQuestionProcess
    {
        private readonly IExerciseGateway _exerciseGateway;

        public QuestionProcess(
            IExerciseGateway exeriseGateway)
        {
            _exerciseGateway = exeriseGateway;
        }

        public QuestionsResponse Get()
        {
            var exercises = _exerciseGateway.LoadAll();

            return new QuestionsResponse
            {
                QuestionModels = exercises.Select(e => Map(e)).ToList()
            };
        }

        public QuestionsResponse Get(QuestionsRequest request)
        {
            var exercises = new List<IExercise>();

            foreach (var code in request.QuestionCodes)
            {
                var exercise = _exerciseGateway.Load(new GetByQuestionCodeCriterion
                {
                    Code = code
                });

                exercises.Add(exercise);
            }

            return new QuestionsResponse
            {
                QuestionModels = exercises.Select(e => Map(e)).ToList()
            };
        }

        #region Private Methods
        private QuestionModel Map(IExercise exercise)
        {
            return new QuestionModel
            {
                QuestionCode = exercise.QuestionCode,
                QuestionCategory = exercise.QuestionCategory,
                QuestionTitle = exercise.QuestionTitle,
                QuestionCreatedBy = exercise.QuestionCreatedBy,
                QuestionCreatedOn = exercise.QuestionCreatedOn,
                QuestionComments = exercise.QuestionComments
            };
        }
        #endregion
    }
}
