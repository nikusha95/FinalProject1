using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class Addlanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Author_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Publisher_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_Publisher_BookAuthorId",
                schema: "book",
                table: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropColumn(
                name: "BookAuthorId",
                schema: "book",
                table: "Publisher");

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorId",
                schema: "book",
                table: "Author",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Author_BookAuthorId",
                schema: "book",
                table: "Author",
                column: "BookAuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Author",
                column: "BookAuthorId",
                principalTable: "BookAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorId",
                schema: "book",
                table: "Publisher",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publisher_BookAuthorId",
                schema: "book",
                table: "Publisher",
                column: "BookAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Author_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalSchema: "book",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publisher_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Publisher",
                column: "BookAuthorId",
                principalTable: "BookAuthors",
                principalColumn: "Id");
        }
    }
}
