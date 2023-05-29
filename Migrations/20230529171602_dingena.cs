using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class dingena : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "14601cc4-9bee-4713-b0cc-e2dd14e04712");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c8c81fc1-88d4-4c33-9776-6d2e3295f5d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f5dc6ffa-d199-4c11-a150-de9b479f1fb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "898e99a6-8f7b-4f8a-bc3d-a92470e1279b", "AQAAAAEAACcQAAAAEALUGzPtneyLisc9RqPq8Gf0A0a4NS10eSiB4FZWQM9yQzMMSZ0d9jZTyZfO7wyC1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6433c05-c070-4c3d-99cb-d8d0ec906560", "AQAAAAEAACcQAAAAEERlQaLewgVbbeSrcUXKS5r+EWnZ7fTyM262g6xKKr71cLVzw709MJlIy6iWzR6RYA==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 16, 1, 918, DateTimeKind.Local).AddTicks(6798));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 13, 42, 416, DateTimeKind.Local).AddTicks(7887));
        }
    }
}
