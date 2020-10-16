using Microsoft.EntityFrameworkCore.Migrations;

namespace EFExample.Migrations
{
    public partial class addedmoreproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Articles");
        }
    }
}
