using Common.Core.DependencyInjection;
using Infrastructure.Data.SqlServer.Answers;
using Infrastructure.Data.SqlServer.Questions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.SqlServer
{
    [ServiceLocate(typeof(ICorrectItDbContext))]
    public class CorrectItDbContext : DbContext, ICorrectItDbContext
    {
        public CorrectItDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerEntityConfiguration());
        }

        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<AnswerEntity> Answers { get; set; }
    }
}