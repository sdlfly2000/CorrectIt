using Domain.Exercises.Aspects;
using Infrastructure.Data.SqlServer.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.Exercises.Mappers
{
    public class QuestionAspectMapper
    {
        public QuestionAspectMapper()
        {
        }

        public QuestionAspect Map(QuestionEntity entity)
        {
            return new QuestionAspect
            {
                QuestionTitle = entity.QuestionTitle,
                QuestionCategory = entity.QuestionCategory,
                QuestionCode = entity.QuestionId.ToString(),
                QuestionComments = entity.QuestionComments,
                QuestionCreatedBy = entity.QuestionCreatedBy,
                QuestionCreatedOn = entity.QuestionCreatedOn    
            };
        }
    }
}
