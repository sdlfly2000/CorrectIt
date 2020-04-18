﻿using Application.Questions.Models;
using Application.Services.Questions.Contractors;
using Common.Core.DependencyInjection;
using Domain.Exercises;
using Domain.Service.Exercises.Gateways;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services.Questions.Actions
{
    [ServiceLocate(typeof(IQuestionAction))]
    public class QuestionAction : IQuestionAction
    {
        private readonly IExerciseGateway _exerciseGateway;

        public QuestionAction(
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
            throw new System.NotImplementedException();
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
