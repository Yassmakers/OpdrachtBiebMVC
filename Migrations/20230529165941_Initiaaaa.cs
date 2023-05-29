using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initiaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7c9c2b1d-ceba-4efa-b740-228487e2bc8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "13ec86e7-1ea2-49c1-862f-33bc2e343297");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3708db8c-3706-4c75-95ff-49b1fbf12ad2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "875728df-7c8c-441a-a59c-4d86ec064363", "AQAAAAEAACcQAAAAEHzcH5LjuOmKRs76AbSuHJ8q4YbAG6kpyXnt6QTCl9ITSMO3idwZOdyt3eD/FK+fGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29c38d5a-674c-44f6-ab14-f10fddc57a54", "AQAAAAEAACcQAAAAEKzk6jFowPwSCp+g3R5e9X4W2T2GwAgTFxCuGm4gStm9crFojeDtXqjHkxU+1o8aqg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
