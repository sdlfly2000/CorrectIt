using Infrastructure.Data.SqlServer.Answers;
using Infrastructure.Data.SqlServer.Questions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.SqlServer
{
    public interface ICorrectItDbContext
    {
        DbSet<AnswerEntity> Answers { get; set; }
        DbSet<QuestionEntity> Questions { get; set; }
    }
}