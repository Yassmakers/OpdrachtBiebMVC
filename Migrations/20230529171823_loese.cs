using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class loese : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e9a2b95f-8f61-4ea2-9575-d38967a491c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fbb7a77d-144e-4a1b-977e-bdb62e050cba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a94a25f2-1291-48c9-a5f1-c40062c8bb7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4778dad6-04ad-4f9f-8210-3480a22ff4e3", "AQAAAAEAACcQAAAAEFcPaipHAu63+gMTc2pjI+YLKb8z0bWIub76lV7hsxMfz3MN6wN5NBj6UFnYAYZ75A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95ff45e3-0297-410c-a34c-7956c1dca670", "AQAAAAEAACcQAAAAEPipynJ8QdiIoHSI+OUFLuZQPD/x5AKOqXV71pQGgJnjvZPNagiJR5OdIXwwFLNUpA==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 18, 23, 667, DateTimeKind.Local).AddTicks(5650));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
