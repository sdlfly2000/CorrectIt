using System;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Requests
{
    public class SaveQuestionImageRequest
    {
        
        public string ImageCategory { get; set; }
        public string ImageFileName { get; set; }
        public string ImageCreatedBy { get; set; }
        public string ImageComments { get; set; }

        public Guid QuestionId { get; set; }
    }
}
