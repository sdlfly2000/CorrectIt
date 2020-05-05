using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel;

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
