using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Quiz.Migrations
{
    /// <inheritdoc />
    public partial class AddedSessionIdFiesdToQuizResult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "QuizResults",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "QuizResults");
        }
    }
}
