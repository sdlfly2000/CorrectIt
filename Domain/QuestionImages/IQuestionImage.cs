using System;

namespace Domain.QuestionImages
{
    public interface IQuestionImage
    {
        Guid ImageId { get; }
        string ImageCategory { get; }
        string ImageFileName { get; }
        string ImageCreatedBy { get; }
        string ImageStatus { get; }
        string ImageComments { get; }
        DateTime ImageCreatedOn { get; }
    }
}