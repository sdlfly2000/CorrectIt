using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Sql.Migrations
{
    public partial class ImageEntityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionStatus",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerStatus",
                table: "Answers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(nullable: false),
                    ImageCategory = table.Column<string>(nullable: true),
                    ImageFileName = table.Column<string>(nullable: true),
                    ImageCreatedOn = table.Column<DateTime>(nullable: false),
                    ImageCreatedBy = table.Column<string>(nullable: true),
                    ImageStatus = table.Column<string>(nullable: true),
                    ImageComments = table.Column<string>(nullable: true),
                    QuestionId = table.Column<Guid>(nullable: false),
                    AnswerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropColumn(
                name: "QuestionStatus",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerStatus",
                table: "Answers");
        }
    }
}
