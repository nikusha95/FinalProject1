using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class correctForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_BookAuthorId",
                schema: "book",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Author_BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "BookAuthorId",
                schema: "book",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BookAuthorId",
                schema: "book",
                table: "Author");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId",
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
                name: "FK_BookAuthors_Book_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalSchema: "book",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Author_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Book_BookId",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors");

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorId",
                schema: "book",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookAuthorId",
                schema: "book",
                table: "Author",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookAuthorId",
                schema: "book",
                table: "Book",
                column: "BookAuthorId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookAuthors_BookAuthorId",
                schema: "book",
                table: "Book",
                column: "BookAuthorId",
                principalTable: "BookAuthors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
