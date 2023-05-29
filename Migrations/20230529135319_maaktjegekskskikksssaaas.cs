using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class maaktjegekskskikksssaaas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "49328577-b2c5-4b59-95fc-32308485749c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c16eb02a-bbf1-4fbe-a919-092b330e2da5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e7faa323-7359-4b03-93fb-cc182d45e44f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32a6c7b4-c8f6-4584-8241-2f0589e50496", "AQAAAAEAACcQAAAAEEReNbr+lDomdacWarrR5WscKRF/D5wh/xVN73GCPaabLbkfs/a2tlnG9PSLE3Af+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5edcaec-358a-45f2-8f48-c25d4b604719", "AQAAAAEAACcQAAAAEESjlKmWWOZwwbZLIHyYtUBdTccmVUl7yYwgLBpaC5aTDsUDPnnKBxve/DuOw/7J6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a199692-e9ec-4af0-b805-f29234819bdd", "AQAAAAEAACcQAAAAEE4kSmX80WuS10s9n5TgQa5MO/OG/JFUJEqrH1maQa0I4xw9keIaGWvIYx0jpH3L6w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9baa58bb-0668-4520-955e-f87c68528a34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a2b273a0-4e2c-40eb-b804-64842f96b805");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b744cbf5-4fef-4903-a86a-63b2149cce73");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61210396-b710-4e0f-addb-89f8a68b8f95", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0335368-aa85-4ddf-8bdf-410726488693", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad1582d0-7f71-4520-8c12-4d639017fcd2", null });
        }
    }
}
