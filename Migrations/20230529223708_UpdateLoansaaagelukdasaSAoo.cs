using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoansaaagelukdasaSAoo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c3275056-47d8-4d12-a502-078ffd632cb1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b436bc34-8e9c-4086-95e4-c94311bbab36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "6cc4c619-2a30-448a-a613-f4db2344ea0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37b3ecf2-d2e5-43a1-adba-667ce70d703a", "AQAAAAEAACcQAAAAEFdAiQYKMedi5g88H6jVX7xEOlrBwnI/cFjtvPMaDJZ+PWovWXVIALATUiWYYzIIHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e8162ab-c465-4dc6-8b35-2e7abd05d072", "AQAAAAEAACcQAAAAEDK/sqdfVV1KvrVC5EF8Y6WB3+/ir6teYBFInjhc1sibIi++9lAA3fJU4yWRD3EEpQ==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 30, 0, 37, 8, 830, DateTimeKind.Local).AddTicks(1720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b4072d24-860f-47a7-a5a6-334f6bd99c1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1a17aeee-704d-469e-88d9-20954bc08741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4b72fefd-fdc8-4b04-8994-e99511d55ea9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8b87cfc7-697e-4be3-957c-ff558245eeca", "AQAAAAEAACcQAAAAEMMRapJUg59OpJT4j3RgzIH3FTOpXl86sNve23WoWOVthLf2t6BG/asmScXRJ4ls2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1296b64-e078-4a62-9d5b-35cbbb82b5c1", "AQAAAAEAACcQAAAAEGyjWqw3I8XtJhT3mTs8nYUK1Lf37ApB5vh7rw07rZTHMCccKs3Yu5rcnCTp5RrFJg==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 23, 54, 17, 517, DateTimeKind.Local).AddTicks(9863));
        }
    }
}
