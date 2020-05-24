using System;

namespace Domain.Services.QuestionImages.Gateways.Persistors.Contracts
{
    public class CreateQuestionImageRequest
    {

        public string ImageCategory { get; set; }
        public string ImageFileName { get; set; }
        public string ImageCreatedBy { get; set; }
        public string ImageComments { get; set; }

        public Guid QuestionId { get; set; }
    }
}
