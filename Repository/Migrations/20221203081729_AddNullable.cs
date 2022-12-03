using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Book_LanguageId",
                schema: "book",
                table: "Book",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Language_LanguageId",
                schema: "book",
                table: "Book",
                column: "LanguageId",
                principalSchema: "book",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Language_LanguageId",
                schema: "book",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_LanguageId",
                schema: "book",
                table: "Book");
        }
    }
}
