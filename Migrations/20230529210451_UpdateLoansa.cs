using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoansa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1c26548c-8a15-46ff-b76d-15675afd771d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "93fa431c-82aa-4445-9fe7-41172c09db04");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "58f613be-b2ab-420d-a247-08a5fc3464d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f451f45-c3b8-488e-8424-70fb1e041a3d", "AQAAAAEAACcQAAAAEF+gGXUSFoRS97NlkVU59UsezO8ndAldQvbBp6yTlerpJPkboO3V1xkApRTCSTDjTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f421427-d2e2-4539-93a1-6b41934531d7", "AQAAAAEAACcQAAAAEOWtq9oMuxTxDAG0LKnwReI2nrU7q3OA/zx9BTdzDlfC1Z9tQwkSHIeF3U4mRh0OJQ==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 22, 56, 36, 133, DateTimeKind.Local).AddTicks(6414));
        }
    }
}
