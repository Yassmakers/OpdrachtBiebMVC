using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class igrationNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "40a733fc-6157-4114-af57-ac31b6a6e91d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9c70c6d0-1f8a-45ff-8178-4ff5302adb0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b51cec10-1d67-426f-b3f0-00d8bdcacd28");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "f65c43dd-ca4a-473b-b52e-9a190cd8c7d6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "76a112bf-c9ef-4bbe-92e5-67f3309d41e5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e5ae2a8f-a843-4ee0-92a1-92bae50a5615");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3ee41092-d50a-45b4-a5a8-7b9e22a6ca10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1547a05c-9fb8-4d7f-8f94-d98de5fe4d1c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a36f6ece-3d60-48fa-9358-d610ee7d2c59");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5dd536d7-894c-4f5e-b23d-6719f097d0a8");
        }
    }
}
