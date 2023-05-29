using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoansaaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3da847ef-c729-4348-acd3-a7ceea2b19f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "1a74c226-8345-4646-8a58-d6086d13c05e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "668d2a44-6a9c-4066-8bba-940b9caf0d65");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5acd1b6-21ad-4f1a-ad91-969b769edc84", "AQAAAAEAACcQAAAAEGY4XYEj1yKNwfcl+eF01QsnCshOteaGTxUgau5gZvbi51vTxPGobDuaZYtre+/juQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af4db3e4-a000-4ab5-88c3-f5e3647b371d", "AQAAAAEAACcQAAAAEFbd6FDErXgdnuxl8P5Sq99dfUHIO/nICLJFDRyM89IkYZk8sv+LjIDJ1E5VPbsFbg==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 23, 4, 50, 964, DateTimeKind.Local).AddTicks(3483));
        }
    }
}
