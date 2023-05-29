using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a84ae82c-47f3-43e7-b6b9-4cf5f4e9d4d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8aa45577-94cd-4378-9ded-35852534bf67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cf97c7cb-8c51-4faa-82df-d5b0e5a0fa51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c9c331-9037-47a9-a871-57955a25a04c", "AQAAAAEAACcQAAAAEDYkEMnMlYR7fwcmIPloVKzkPDf7Beb5dpy+iBYqwfVO+IyuktzSEIA61ufjGzFNBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8af4f618-f3fa-4d80-8ed6-62e063919f87", "AQAAAAEAACcQAAAAEN9dF1X5NmMvPNKsN5NzU6Fp1bEd+JhDF443E6OobILrAQZnyhY7HORfXcda9KX9YQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2c25fe72-1be7-48c0-8be6-e854d73e500b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b5a55ef4-a884-405d-ae2f-f61c8803cde6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "339223bd-c6ad-4920-a6fc-66919efeaaca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d3d995a-a8ac-4142-908d-38b963be8b7e", "AQAAAAEAACcQAAAAENu+oqyU/XtTebtSazqkFn7hlWttxjxl86vSB6B8t8Gxv4js2GuaZnpuB7TuoiBkvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e1fa641-d2e0-421a-b14f-ca638e764451", "AQAAAAEAACcQAAAAEKDGzwEwcl8CGFRjWgb/CD3g8WhQ8710hso479fjL+1VBk0Fz1raHz+8kyNtU5fv0w==" });
        }
    }
}
