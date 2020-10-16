using Microsoft.EntityFrameworkCore.Migrations;

namespace EFExample.Migrations
{
    public partial class comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleComment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    ArticleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleComment_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleComment_ArticleId",
                table: "ArticleComment",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleComment");
        }
    }
}
