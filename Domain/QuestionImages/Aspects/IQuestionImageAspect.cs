using System;

namespace Domain.QuestionImages.Aspects
{
    public interface IQuestionImageAspect
    {
        Guid ImageId { get; set; }
        string ImageCategory { get; set; }
        string ImageFileName { get; set; }
        DateTime ImageCreatedOn { get; set; }
        string ImageCreatedBy { get; set; }
        string ImageStatus { get; set; }
        string ImageComments { get; set; }
    }
}