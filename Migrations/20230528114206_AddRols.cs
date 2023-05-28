using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRols : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1458c441-a375-4ed4-818b-9baf7a79b579");

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "535ce640-1c73-4d0b-850d-8b187f6fc9df");

            migrationBuilder.InsertData(
                table: "IdentityRole<int>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "272e2dfd-d4db-4817-9ea3-af001eb5cbd1", "Librarian", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "95352ea5-ff80-4cf2-bc28-fc1c388d4e71");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5a9aa25b-1b12-4b2f-8fe3-d4b8a31a847b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "177add3b-ef3b-4d43-a161-0fa2c9fb8456");

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "cfadfb93-d9fe-4fef-9fbf-d51ba701057d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b0bae886-b55d-4c0e-be89-0fef479dfd14");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d2ab115f-034a-4ccc-a073-b2072ca50e09");
        }
    }
}
