using Common.Core.DependencyInjection;
using Infrastructure.Data.Sql.Answers;
using Infrastructure.Data.Sql.Images;
using Infrastructure.Data.Sql.Questions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Sql
{
    [ServiceLocate(typeof(ICorrectItDbContext))]
    public class CorrectItDbContext : DbContext, ICorrectItDbContext
    {
        public CorrectItDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new QuestionEntityConfiguration());
            //modelBuilder.ApplyConfiguration(new AnswerEntityConfiguration());
        }

        public void Commit()
        {
            SaveChanges();
        }

        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<AnswerEntity> Answers { get; set; }
        public DbSet<ImageEntity> Images { get; set; }
    }
}