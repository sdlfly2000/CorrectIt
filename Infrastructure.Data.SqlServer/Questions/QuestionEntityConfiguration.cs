using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.SqlServer.Questions
{
    public class QuestionEntityConfiguration : IEntityTypeConfiguration<QuestionEntity>
    {
        public QuestionEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<QuestionEntity> builder)
        {
            builder.Property(e => e.QuestionId).HasColumnName("questionId").HasColumnType("uniqueidentifier").ValueGeneratedOnAdd();
            builder.Property(e => e.QuestionCategory).HasColumnName("questionCategory").HasColumnType("nvarchar(max)");
            builder.Property(e => e.QuestionTitle).HasColumnName("questionTitle").HasColumnType("nvarchar(max)");
            builder.Property(e => e.QuestionImageName).HasColumnName("questionImageName").HasColumnType("nvarchar(max)");
            builder.Property(e => e.QuestionCreatedBy).HasColumnName("questionCreatedBy").HasColumnType("nvarchar(max)");
            builder.Property(e => e.QuestionComments).HasColumnName("questionComments").HasColumnType("nvarchar(max)");
            builder.Property(e => e.QuestionCreatedOn).HasColumnName("questionCreatedOn").HasColumnType("datetime");
                            
            builder.HasKey("QuestionId");
            builder.HasMany(e => e.Answers).WithOne();
            builder.ToTable("Questions");
        }
    }
}
