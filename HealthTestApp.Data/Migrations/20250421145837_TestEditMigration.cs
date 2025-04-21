using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthTestApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestEditMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Difficulty",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedDuration",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "EstimatedDuration",
                table: "Tests");
        }
    }
}
