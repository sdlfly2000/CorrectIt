using Infrastructure.Data.Sql.Answers;
using Infrastructure.Data.Sql.Questions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Sql
{
    public interface ICorrectItDbContext
    {
        DbSet<AnswerEntity> Answers { get; set; }
        DbSet<QuestionEntity> Questions { get; set; }
    }
}