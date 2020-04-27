using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Sql.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<Guid>(nullable: false),
                    QuestionCategory = table.Column<string>(nullable: true),
                    QuestionTitle = table.Column<string>(nullable: true),
                    QuestionImageName = table.Column<string>(nullable: true),
                    QuestionCreatedOn = table.Column<DateTime>(nullable: false),
                    QuestionCreatedBy = table.Column<string>(nullable: true),
                    QuestionComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<Guid>(nullable: false),
                    AnswerSolution = table.Column<string>(nullable: true),
                    AnswerImageName = table.Column<string>(nullable: true),
                    AnswerComments = table.Column<string>(nullable: true),
                    AnswerCreatedOn = table.Column<DateTime>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
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
