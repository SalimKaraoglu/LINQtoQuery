using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LINQtoQuery.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6595), null, "Michelle", "Alexander", 1, null },
                    { 2, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6592), null, "Stephen e.", "Ambrose", 1, null },
                    { 3, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6597), null, "Margaret", "Atwood", 1, null },
                    { 4, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6598), null, "Jane", "Austen", 1, null },
                    { 5, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6600), null, "James", "Baldwin", 1, null },
                    { 6, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6601), null, "Emily", "Bronte", 1, null },
                    { 7, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6603), null, "Agatha", "Chistia", 1, null },
                    { 8, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6604), null, "Ta-Nehishi", "Coates", 1, null },
                    { 9, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6605), null, "Jared", "Diamond", 1, null },
                    { 10, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6607), null, "Joa", "Didion", 1, null },
                    { 11, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6609), null, "Daphne", "Du Maurier", 1, null },
                    { 12, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6610), null, "Tina", "Fey", 1, null },
                    { 13, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6611), null, "Roxane", "Gay", 1, null },
                    { 14, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6613), null, "Dashiel", "Hamment", 1, null },
                    { 15, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6614), null, "Frank", "Harbert", 1, null },
                    { 16, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6616), null, "Aldous", "Huxley", 1, null },
                    { 17, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6618), null, "Stieg", "Larsson", 1, null },
                    { 18, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6619), null, "David", "MsCullogh", 1, null },
                    { 19, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6621), null, "Toni", "Morrison", 1, null },
                    { 20, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6622), null, "George", "Orwell", 1, null },
                    { 21, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6624), null, "Mary", "Shelly", 1, null },
                    { 22, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6625), null, "Sun", "Tzu", 1, null },
                    { 23, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6626), null, "Augusten", "Burroughs", 1, null },
                    { 25, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6628), null, "JK", "Rowling", 1, null },
                    { 26, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6630), null, "Seth", "Grahame-Smith", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "history", new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5869), null, "History", 1, null },
                    { "memoir", new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5864), null, "Memoir", 1, null },
                    { "mystery", new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5866), null, "Mystery", 1, null },
                    { "novel", new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5848), null, "Novel", 1, null },
                    { "scifi", new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(5867), null, "Science Finction", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "GenreId", "Price", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6257), null, "history", 18.0, 1, "1776", null },
                    { 2, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6263), null, "scifi", 5.5, 1, "1984", null },
                    { 3, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6265), null, "mystery", 4.5, 1, "And Then There Were None", null },
                    { 4, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6266), null, "history", 11.5, 1, "Band of Brothers", null },
                    { 5, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6268), null, "novel", 10.99, 1, "Beloved", null },
                    { 6, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6269), null, "memoir", 13.5, 1, "Between The World And Me", null },
                    { 7, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6271), null, "memoir", 4.25, 1, "Bossypants", null },
                    { 8, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6273), null, "scifi", 16.25, 1, "Brave New World", null },
                    { 9, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6274), null, "history", 15.0, 1, "D-Day", null },
                    { 10, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6276), null, "memoir", 4.25, 1, "Down and Out in Paris and London", null },
                    { 11, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6277), null, "scifi", 8.75, 1, "Dune", null },
                    { 12, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6279), null, "novel", 9.0, 1, "Emma", null },
                    { 13, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6280), null, "scifi", 6.5, 1, "Frankestein", null },
                    { 14, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6282), null, "novel", 10.25, 1, "Go Tell It On The Mountain", null },
                    { 15, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6283), null, "history", 15.5, 1, "Guns, Germs and Steel", null },
                    { 16, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6285), null, "memoir", 14.5, 1, "Hunger", null },
                    { 17, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6287), null, "mystery", 6.75, 1, "Murder on the Orient Express", null },
                    { 18, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6288), null, "novel", 8.5, 1, "Pride and Prejudice", null },
                    { 19, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6290), null, "mystery", 10.99, 1, "Rebecca", null },
                    { 20, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6291), null, "history", 5.75, 1, "The Art of War", null },
                    { 21, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6293), null, "mystery", 8.5, 1, "The Girl With The Dragon Tattoo", null },
                    { 22, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6295), null, "scifi", 12.5, 1, "The Handmaid's Tale", null },
                    { 23, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6296), null, "mystery", 10.99, 1, "The Maltese Falcon", null },
                    { 24, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6298), null, "history", 13.75, 1, "The New Jim Crow", null },
                    { 25, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6299), null, "memoir", 13.5, 1, "The Year of Magical Thinking", null },
                    { 26, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6301), null, "novel", 9.0, 1, "Wuthering Heights", null },
                    { 27, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6303), null, "memoir", 11.0, 1, "Running With Scissors", null },
                    { 28, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6305), null, "novel", 8.75, 1, "Pride and Prejudice and Zombies", null },
                    { 29, new DateTime(2023, 12, 4, 22, 43, 14, 519, DateTimeKind.Local).AddTicks(6385), null, "novel", 9.75, 1, "Harry Potter and The Sorcerer's Stone", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 24 },
                    { 2, 4 },
                    { 2, 9 },
                    { 3, 22 },
                    { 4, 12 },
                    { 4, 18 },
                    { 4, 28 },
                    { 5, 14 },
                    { 6, 26 },
                    { 7, 3 },
                    { 7, 17 },
                    { 9, 15 },
                    { 10, 25 },
                    { 11, 19 },
                    { 12, 7 },
                    { 13, 16 },
                    { 14, 23 },
                    { 15, 11 },
                    { 16, 8 },
                    { 17, 21 },
                    { 18, 1 },
                    { 19, 5 },
                    { 20, 2 },
                    { 20, 10 },
                    { 21, 13 },
                    { 22, 20 },
                    { 23, 27 },
                    { 25, 29 },
                    { 26, 28 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
