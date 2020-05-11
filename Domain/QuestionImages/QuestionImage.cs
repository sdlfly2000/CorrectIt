using Domain.QuestionImages.Aspects;
using System;

namespace Domain.QuestionImages
{
    public class QuestionImage : IQuestionImage
    {
        private readonly IQuestionImageAspect _questionImageAspect;

        public QuestionImage(IQuestionImageAspect questionImageAspect)
        {
            _questionImageAspect = questionImageAspect;
        }

        public Guid ImageId => _questionImageAspect.ImageId;

        public string ImageCategory => _questionImageAspect.ImageCategory;

        public string ImageFileName => _questionImageAspect.ImageFileName;

        public string ImageCreatedBy => _questionImageAspect.ImageCreatedBy;

        public string ImageStatus => _questionImageAspect.ImageStatus;

        public string ImageComments => _questionImageAspect.ImageComments;

        public DateTime ImageCreatedOn => _questionImageAspect.ImageCreatedOn;
    }
}
