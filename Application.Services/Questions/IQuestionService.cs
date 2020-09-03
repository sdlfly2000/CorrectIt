using Application.Services.Questions.Contractors;

namespace Application.Services.Questions
{
    public interface IQuestionService
    {
        QuestionsResponse Get();
        QuestionsResponse Get(string questionCode);
        QuestionsResponse Get(QuestionsRequest request);
    }
}