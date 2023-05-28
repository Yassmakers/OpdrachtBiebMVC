using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_IdentityRole<int>_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

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
                columns: new[] { "ConcurrencyStamp", "Email", "UserName" },
                values: new object[] { "b0bae886-b55d-4c0e-be89-0fef479dfd14", "johndoe@example.com", "John Doe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "UserName" },
                values: new object[] { "d2ab115f-034a-4ccc-a073-b2072ca50e09", "janesmith@example.com", "Jane Smith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0e0c185b-1dee-483c-999b-3eca595f444c");

            migrationBuilder.UpdateData(
                table: "IdentityRole<int>",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e52f5da0-cbf6-4ccd-9582-1b765912b1d4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "RoleId", "UserName" },
                values: new object[] { "2ef9aca1-ccb4-41d1-8647-fd206bce8a06", null, 1, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "RoleId", "UserName" },
                values: new object[] { "848a7c60-e150-4853-bca7-bda15b885e23", null, 2, null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IdentityRole<int>_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "IdentityRole<int>",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
