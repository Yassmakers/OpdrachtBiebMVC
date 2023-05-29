using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLoans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "26046800-b515-4cd4-b16d-6318340e93f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "78f25357-63a3-4752-aefd-6e6b31de2dfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9f350128-325c-457c-9b1f-c783305b597e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad156140-7e76-46f8-a9b9-e2d4a74e6f6f", "AQAAAAEAACcQAAAAEBf2BzCe2hk545sfoMMQhlAsFEu8gCiJHS+fBvPPPoCQzW1Dpu7RIacfXt2/eqlqzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8099a45b-5b42-4596-88fd-a8a9cb9c6eda", "AQAAAAEAACcQAAAAEDJR991H+UUFfK4kAS8mrPbonZcQ321IBZYY3IER/IZzDbjTnRx/+kYnxnHA66kuBw==" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 29, 22, 24, 29, 950, DateTimeKind.Local).AddTicks(6096));
        }
    }
}
