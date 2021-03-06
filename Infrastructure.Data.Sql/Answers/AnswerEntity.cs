﻿using Infrastructure.Data.Sql.Questions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Sql.Answers
{
    public class AnswerEntity
    {
        [Key]
        public Guid AnswerId { get; set; }
        public string AnswerSolution { get; set; }
        public string AnswerImageName { get; set; }
        public string AnswerComments { get; set; }
        public DateTime AnswerCreatedOn { get; set; }
        public string AnswerStatus { get; set; }

        public Guid QuestionId { get; set; }
        public QuestionEntity Question { get; set; }
    }
}
