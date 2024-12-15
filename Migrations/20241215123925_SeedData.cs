using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendDemo.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CheckedOutAt", "Description", "DueDate", "Name", "Owner", "ReturnedAt" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A story of the fabulously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "George Orwell", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dystopian social science fiction novel that follows the life of Winston Smith.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Jane Austen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A romantic novel following the character development of Elizabeth Bennet.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride and Prejudice", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "J.R.R. Tolkien", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fantasy novel about the adventures of Bilbo Baggins.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Harper Lee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A novel about racial injustice and the loss of innocence in the American South.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To Kill a Mockingbird", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Frank Herbert", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A science fiction masterpiece about politics, religion, and power in a desert world.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dune", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Dan Brown", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thriller involving a conspiracy within the Catholic Church.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Da Vinci Code", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "J.D. Salinger", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A story of teenage alienation and loss of innocence in America.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Catcher in the Rye", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Paulo Coelho", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A philosophical novel about following one's dreams.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Alchemist", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Yuval Noah Harari", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A brief history of humankind exploring the evolution of human societies.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sapiens", "Library", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Science Fiction" },
                    { 3, "Mystery" },
                    { 4, "Romance" },
                    { 5, "Fantasy" },
                    { 6, "Non-Fiction" },
                    { 7, "Thriller" },
                    { 8, "Historical Fiction" }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "BooksId", "GenresId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 8 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 8 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 1 },
                    { 7, 3 },
                    { 7, 7 },
                    { 8, 1 },
                    { 9, 1 },
                    { 9, 5 },
                    { 10, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
