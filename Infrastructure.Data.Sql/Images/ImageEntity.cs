﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Sql.Images
{
    public class ImageEntity
    {
        [Key]
        [Required]
        public Guid ImageId { get; set; }
        public string ImageCategory { get; set; }
        public string ImageFileName { get; set; }
        public DateTime ImageCreatedOn { get; set; }
        public string ImageCreatedBy { get; set; }
        public string ImageStatus { get; set; }
        public string ImageComments { get; set; }

        public Guid QuestionId { get; set; }
        public Guid AnswerId { get; set; }
    }
}
