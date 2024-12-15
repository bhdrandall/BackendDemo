using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRolesAndBookAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequiredRole",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "BooksId", "GenresId" },
                values: new object[,]
                {
                    { 3, 8 },
                    { 5, 5 },
                    { 6, 8 },
                    { 7, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "RequiredRole",
                value: "Basic");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Role", "Username" },
                values: new object[] { 1, "admin@library.com", "$2a$11$zp7n3fLfU3YgiBsAYvC8MOI7nvfV0exF1nR3m6lD7O3vfA1QmE1aq", "Admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumns: new[] { "BooksId", "GenresId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RequiredRole",
                table: "Books");

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "BooksId", "GenresId" },
                values: new object[,]
                {
                    { 4, 5 },
                    { 5, 8 },
                    { 6, 2 },
                    { 7, 3 },
                    { 7, 7 }
                });
        }
    }
}
