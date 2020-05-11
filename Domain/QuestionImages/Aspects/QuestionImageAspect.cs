using System;

namespace Domain.QuestionImages.Aspects
{
    public class QuestionImageAspect : IQuestionImageAspect
    {
        public Guid ImageId { get; set; }
        public string ImageFileName { get; set; }
        public DateTime ImageCreatedOn { get; set; }
        public string ImageCreatedBy { get; set; }
        public string ImageStatus { get; set; }
        public string ImageComments { get; set; }
        public string ImageCategory { get; set; }
    }
}
