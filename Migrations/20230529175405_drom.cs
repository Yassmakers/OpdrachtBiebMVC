using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class drom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "65b6eada-eb1e-4211-8827-b2470e12fe2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b17034fd-9756-4255-ad70-6d3869e67d18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a67e0810-d13f-425f-85af-addccc432eca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbde09e7-6b2f-44d6-853d-fb31b557cd6c", "AQAAAAEAACcQAAAAEOtQ8zGLRjbfnPWDm8X1EgooYCOrjbjTs1pAzjkxF0n0XqkxUdm34uSW9V6B++aaZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14ab850d-f828-4ee5-9a5a-f33be2fa9635", "AQAAAAEAACcQAAAAEOMnTV9L69iLM+qO3ffXTHfFAP2LrykGKvVLRzSRx/ebeDltK3PzP3cgOaNRnJbjeg==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 19, 54, 5, 143, DateTimeKind.Local).AddTicks(853));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
