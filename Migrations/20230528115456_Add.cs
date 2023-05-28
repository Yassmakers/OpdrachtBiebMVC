using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRole<int>",
                table: "IdentityRole<int>");

            migrationBuilder.RenameTable(
                name: "IdentityRole<int>",
                newName: "Roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "570a1baf-ccaf-4054-bde6-619c391fc6ad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4dfc1257-d109-4bd9-8220-e3b4b4fe4c4f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "bfb503c8-e858-405a-a834-6fd4221df0d8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b6e1d01a-08c1-4217-841f-2188f2a74cdc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d4ed7c9e-0252-46ae-8fd6-e67a8df01018");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "IdentityRole<int>");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRole<int>",
                table: "IdentityRole<int>",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "272e2dfd-d4db-4817-9ea3-af001eb5cbd1");

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
    }
}
