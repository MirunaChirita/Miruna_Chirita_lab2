using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Miruna_Chirita_lab2.Migrations
{
    public partial class author1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Author",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Author",
                newName: "PublisherName");
        }
    }
}
