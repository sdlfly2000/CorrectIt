using Application.Services.Questions.Contractors;
using Application.Services.Questions.Processes;
using Common.Core.DependencyInjection;

namespace Application.Services.Questions
{
    [ServiceLocate(typeof(IQuestionService))]
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionProcess _questionProcess;

        public QuestionService(IQuestionProcess questionProcess)
        {
            _questionProcess = questionProcess;
        }

        public QuestionsResponse Get()
        {
            return _questionProcess.Get();
        }

        public QuestionsResponse Get(QuestionsRequest request)
        {
            return _questionProcess.Get(request);
        }
    }
}
