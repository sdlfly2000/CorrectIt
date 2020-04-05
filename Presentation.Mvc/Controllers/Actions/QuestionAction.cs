using Common.Core.DependencyInjection;
using Domain.Exercises;
using Domain.Service.Exercises.Gateways;
using Presentation.Mvc.Models.Questions;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Mvc.Controllers.Actions
{
    [ServiceLocate(typeof(IQuestionAction))]
    public class QuestionAction : IQuestionAction
    {
        private readonly IExerciseGateway _exerciseGateway;

        public QuestionAction(
            IExerciseGateway exeriseGateway )
        {
            _exerciseGateway = exeriseGateway;
        }

        public IEnumerable<QuestionModel> Get()
        {
            var exercises = _exerciseGateway.LoadAll();

            return exercises.Select(e => Map(e)).ToList();

        }

        #region Private Methods
        private QuestionModel Map(IExercise exercise)
        {
            return new QuestionModel
            {
                QuestionCode = exercise.QuestionCode,
                QuestionCategory = exercise.QuestionCategory,
                QuestionTitle = exercise.QuestionTitle,
                QuestionCreatedOn = exercise.QuestionCreatedOn,
                QuestionCreatedBy = exercise.QuestionCreatedBy,
                QuestionComments = exercise.QuestionComments
            };
        }
        #endregion
    }
}
