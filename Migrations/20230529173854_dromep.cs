using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class dromep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "01ed79ac-a1aa-41f3-9c3d-d8be869d1510");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "31475c4b-20e7-4ef2-a505-dad9b1be0ce2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a9558c94-8c4f-40c2-aa9e-c17edbf192a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a7e63e5-e160-4ac2-96ea-997a7a0309db", "AQAAAAEAACcQAAAAEEtxOgN+HLRDxfDmwL5uB0vYGGf4wOcN5k+Fns41TsCwb3t08KInuQwy+3cUn6cLLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d16894e-108c-4c44-9e2e-0da521aea78b", "AQAAAAEAACcQAAAAEGw0KRttAiqmG55izN54TinCy9bRtuN7mV8iNS/GR8TvZU6fqLqs7zl64zsrVe+F1Q==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 38, 54, 169, DateTimeKind.Local).AddTicks(2946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
