using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthTestApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustetTestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestDataJson",
                table: "UserTests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TestName",
                table: "UserTests",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestDataJson",
                table: "UserTests");

            migrationBuilder.DropColumn(
                name: "TestName",
                table: "UserTests");
        }
    }
}
