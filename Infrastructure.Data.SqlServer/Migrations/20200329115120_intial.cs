using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Infrastructure.Data.SqlServer.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    questionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    questionCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    questionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    questionImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    questionCreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    questionCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    questionComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.questionId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    answerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    answerSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answerImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answerComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answerCreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    QuestionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.answerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "questionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
