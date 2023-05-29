using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class drome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "85397ab1-cee3-4cb1-a91e-4d7b25a61cd8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5c25d40b-7956-48e1-a096-752775b9807a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6b9bd27e-db32-44a4-a4fc-9504a09f6e18");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aab5f7e8-6823-4b89-9c40-7c8b0a84d2a4", "AQAAAAEAACcQAAAAEApxR8k0YTumZqKHpzr1Se+LQubvuEnnE2Vl2dvYPqBYfQmUCvAsqGvCcSm2TwRyig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "687e51d8-21bf-49e5-9f5e-7cc2d182a5cf", "AQAAAAEAACcQAAAAEEqWGNB7uduNCETbqrH86DX6SefZw3alAbtB/8pDI3jLMRhmL5x0tvDy6dWehEmF6A==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 25, 36, 650, DateTimeKind.Local).AddTicks(1509));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
