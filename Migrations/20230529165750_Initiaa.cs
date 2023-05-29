using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initiaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "50a79b4a-2bfe-499b-a142-042b54178f44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8c4e5312-97e3-43f1-b746-c378da1b02e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4bfd03aa-1a96-4987-a157-84c2e504ea56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d516b312-4061-4342-8b8a-8930acf5b178", "AQAAAAEAACcQAAAAEPcD6klJDMZTrQL41sbW2qmQfglHm6boPEeTENSwTiYFZ/F/7mUMRGsCQ3rcLd9XLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f974215-f223-4753-a779-e0c633a01019", "AQAAAAEAACcQAAAAEHOOaglLwU59cxiupufA8/MPMc4ZJOqU7Kh1mFX8+OYq8Csh/uFFni9Mb8BSBDMPqg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
