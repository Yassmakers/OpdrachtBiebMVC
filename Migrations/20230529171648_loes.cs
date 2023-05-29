using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class loes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "779462f5-8390-4c5a-9410-5e1e80fc8ae1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7bb2bb56-33ce-4a10-947b-7ae4e90bb5e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f11149ad-3b24-4012-a74b-a8812aa31687");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79daa2e4-92e4-455c-b341-d8788a3c9249", "AQAAAAEAACcQAAAAEBr5T0siu09SfrwLyeZzS22uFYx2Rq7pZiHfcXxqjInZ7LXagW2maoioQMbj/GAxFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "be7e743e-92b5-4e5b-bd2e-85e6f0a09c0f", "AQAAAAEAACcQAAAAEGL3M0yhc2EH2Xjc9U+6s/dBK0qIw208GC2QCgRPt9wTkVKbn4MjUnGpiL6iQUEXqQ==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 16, 48, 752, DateTimeKind.Local).AddTicks(421));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
