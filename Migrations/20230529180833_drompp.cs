using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class drompp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ba8293ae-70e3-406b-8a4d-49dd8dc09ca9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3473b366-8ca0-4ba7-b74e-0530daa6fc69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8a2f7111-844c-4b45-9aae-bc83287d62f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1987f8df-6fcf-422f-a93b-f32f95bc25cb", "AQAAAAEAACcQAAAAEPeATRFMPZt1IBXFdy9X6L1CmIYubSJAQdMkP0jkTgz+Y70MtYNqqF1sRIE6gF5paw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e30945f-9d88-4936-a33d-632f22fe8e5d", "AQAAAAEAACcQAAAAECUnD5F+3L6uf5NlSFBDK78qi0AE6MslSLa0nEJvrEGV5Csqq+ZGKBIpImunER6Q+g==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 20, 8, 33, 389, DateTimeKind.Local).AddTicks(8311));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
