using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Data.SqlServer.Answers;

namespace Infrastructure.Data.SqlServer.Questions
{
    public class QuestionEntity
    {
        [Key]
        [Required]
        public Guid QuestionId { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionImageName { get; set; }
        public DateTime QuestionCreatedOn { get; set; }
        public string QuestionCreatedBy { get; set; }
        public string QuestionComments { get; set; }

        public List<AnswerEntity> Answers { get; set; }
    }
}
