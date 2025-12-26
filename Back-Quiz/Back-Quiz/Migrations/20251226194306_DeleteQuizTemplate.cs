using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Quiz.Migrations
{
    /// <inheritdoc />
    public partial class DeleteQuizTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizResults_QuizTemplates_QuizTemplateId",
                table: "QuizResults");

            migrationBuilder.DropTable(
                name: "QuizTemplates");

            migrationBuilder.DropIndex(
                name: "IX_QuizResults_QuizTemplateId",
                table: "QuizResults");

            migrationBuilder.DropColumn(
                name: "QuizTemplateId",
                table: "QuizResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "QuizTemplateId",
                table: "QuizResults",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "QuizTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Difficulty = table.Column<int>(type: "integer", nullable: false),
                    QuestionCount = table.Column<int>(type: "integer", nullable: false),
                    TimeLimitSeconds = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizTemplates", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizResults_QuizTemplateId",
                table: "QuizResults",
                column: "QuizTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizResults_QuizTemplates_QuizTemplateId",
                table: "QuizResults",
                column: "QuizTemplateId",
                principalTable: "QuizTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
