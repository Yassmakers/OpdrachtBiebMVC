using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class mahkz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d695d34d-81e6-4a7b-830c-883afe346691", "AQAAAAEAACcQAAAAEO/FHcfTSfp5gKZQ8KVQaoqv35uAxp44KtJN5xJE2tN7dYJ6aAW/P3aaJJ8mN4R3dA==", "60c5bb13-6a91-4d83-91b6-ef603eace9a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaf411dd-6089-4ea3-898c-a991dfd5b1fb", "AQAAAAEAACcQAAAAEDJMBc9wQQQbKR2E02sVrpiXJf0TRJzFQgG4kMe36lgtxeu6nFp2GzWP1sBtmWC/BQ==", "f8793e74-4c41-4072-ac9f-960693912991" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 53, 46, 71, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 6, 15, 0, 53, 46, 71, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 25, 0, 53, 46, 71, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 25, 0, 53, 46, 71, DateTimeKind.Local).AddTicks(9253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "179ad1ca-5129-42f3-bab8-84acb8732b2f", "AQAAAAEAACcQAAAAENQP2jJL96pEzPIKZre4xFy4gS1JWKhgEr4NmBDa18CBzgSxbd+zfu7OGv5i0yp24Q==", "bb6b1f2a-e942-4b7a-bd11-a8a9db12fdd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f1d06ec-1e75-4292-b0f8-8dce4e59ba3a", "AQAAAAEAACcQAAAAEDIHgH+adKBbY9svBZElImvt4ZmrjHbCyhJD9OVVMWHgzXU4zRc0C0MR1RJ1LOmY1A==", "478ddf55-efc2-4f61-b5e1-3316d1c9fc13" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 5, 25, 0, 49, 55, 940, DateTimeKind.Local).AddTicks(1893), new DateTime(2023, 6, 15, 0, 49, 55, 940, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 25, 0, 49, 55, 940, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 5, 25, 0, 49, 55, 940, DateTimeKind.Local).AddTicks(1946));
        }
    }
}
