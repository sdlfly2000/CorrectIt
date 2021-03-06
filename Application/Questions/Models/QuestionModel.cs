﻿using System;

namespace Application.Questions.Models
{
    public class QuestionModel
    {
        public string QuestionCode { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionCreatedBy { get; set; }
        public DateTime QuestionCreatedOn { get; set; }
        public string QuestionComments { get; set; }
    }
}
