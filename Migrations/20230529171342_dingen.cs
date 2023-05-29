using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class dingen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "71a6fcf3-9e98-4b43-bc66-55a21ab023cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c46b6af8-2452-43b5-94fe-fcad5b82e1e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "331798e0-06d0-446b-8486-a8d49fe13032");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3702570-9772-45cb-8858-40468a887b32", "AQAAAAEAACcQAAAAEAkxaEMrlPE2abHaoREWRygoT68x1AuQjn01sfpd4FvyBKeEFp8+IhQvuMpMHU2OPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b3c2bed-9199-4840-8f2d-c86e357aee76", "AQAAAAEAACcQAAAAEFUYhCVv/7IZ9f52cOQ3s4SaRzdX/aitPvwotZOuEjAXZkA9k4D7Iyl5xOkNlkErwQ==" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 1, 1, new DateTime(2023, 5, 29, 19, 13, 42, 416, DateTimeKind.Local).AddTicks(7887), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
