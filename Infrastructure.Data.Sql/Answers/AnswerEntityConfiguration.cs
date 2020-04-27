using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Sql.Answers
{
    public class AnswerEntityConfiguration : IEntityTypeConfiguration<AnswerEntity>
    {
        public void Configure(EntityTypeBuilder<AnswerEntity> builder)
        {
            builder.Property(e => e.AnswerId).HasColumnName("answerId").HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
            builder.Property(e => e.AnswerSolution).HasColumnName("answerSolution").HasColumnType("nvarchar(max)");
            builder.Property(e => e.AnswerImageName).HasColumnName("answerImageName").HasColumnType("nvarchar(max)");
            builder.Property(e => e.AnswerComments).HasColumnName("answerComments").HasColumnType("nvarchar(max)");
            builder.Property(e => e.AnswerCreatedOn).HasColumnName("answerCreatedOn").HasColumnType("datetime");

            builder.HasKey(e => e.AnswerId);
            builder.HasOne(e => e.Question).WithMany(e => e.Answers).HasForeignKey(e => e.QuestionId).OnDelete(DeleteBehavior.Cascade);
            builder.ToTable("Answers");
        }
    }
}
