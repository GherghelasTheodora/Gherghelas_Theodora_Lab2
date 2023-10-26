using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gherghelas_Theodora_Lab2.Migrations
{
    public partial class AddFullNameToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Author");
        }
    }
}
