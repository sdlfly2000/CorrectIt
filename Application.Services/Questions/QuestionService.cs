using Application.Services.Questions.Actions;
using Application.Services.Questions.Contractors;
using Common.Core.DependencyInjection;

namespace Application.Services.Questions
{
    [ServiceLocate(typeof(IQuestionService))]
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionAction _questionAction;

        public QuestionService(IQuestionAction questionAction)
        {
            _questionAction = questionAction;
        }

        public QuestionsResponse Get()
        {
            return _questionAction.Get();
        }

        public QuestionsResponse Get(QuestionsRequest request)
        {
            return _questionAction.Get(request);
        }
    }
}
