﻿// <auto-generated />
using System;
using Infrastructure.Data.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.SqlServer.Migrations
{
    [DbContext(typeof(CorrectItDbContext))]
    partial class CorrectItDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infrastructure.Data.SqlServer.Answers.AnswerEntity", b =>
                {
                    b.Property<Guid>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("answerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnswerComments")
                        .HasColumnName("answerComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AnswerCreatedOn")
                        .HasColumnName("answerCreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("AnswerImageName")
                        .HasColumnName("answerImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerSolution")
                        .HasColumnName("answerSolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Infrastructure.Data.SqlServer.Questions.QuestionEntity", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("questionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("QuestionCategory")
                        .HasColumnName("questionCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionComments")
                        .HasColumnName("questionComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionCreatedBy")
                        .HasColumnName("questionCreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("QuestionCreatedOn")
                        .HasColumnName("questionCreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("QuestionImageName")
                        .HasColumnName("questionImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTitle")
                        .HasColumnName("questionTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Infrastructure.Data.SqlServer.Answers.AnswerEntity", b =>
                {
                    b.HasOne("Infrastructure.Data.SqlServer.Questions.QuestionEntity", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}