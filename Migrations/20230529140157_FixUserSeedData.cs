using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class FixUserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e8124478-4dfd-49a9-b42f-b350105e932c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fcd03490-6bfd-4b52-a8fc-d60a725f81ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "019bbf39-3fcd-4dbc-826f-afa685936ec7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b3cdd82-aeac-4b49-ae8f-bbd049895537", "AQAAAAEAACcQAAAAEKFY/Oq8CcLGtL46uwJ+pDungPyH/oP8oaBy3/G6dbX7tvuHe9lZgoEfzguswot6mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13e26c8a-ea84-4166-844a-8f01436098b4", "AQAAAAEAACcQAAAAEM92cqG2kAEr2/wYDzyoG2FO5X//nEQRnFaJRXwX13dDQcyFF0LmsvFnBwqCDJ49LA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0e13ea3d-e87b-47fc-aa23-36cd15143b81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "25556ed4-a4f6-49fb-8933-d0e921c5a365");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ba5817ef-3465-4e4c-99c4-869676e95923");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1029524c-d407-441b-b569-76e1d0a057a4", "AQAAAAEAACcQAAAAEDkUUKkMcodB07fNxl2pN7dqbusYmVHUeK8NRiJjgh4wIvghy4wC91R+nEbZpJrHXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5d12108-5eeb-45fb-9524-df3f951034ee", "AQAAAAEAACcQAAAAEHnX3NGTKnl/RrOBkvzRoZwZvvMxn8i3bTkp275Gf4q5CQGHeIP7fvKaOT13gyHZEQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[] { 3, 0, "b7a678e6-fafe-4b8b-9324-d4df322bb5b3", "robertjohnson@example.com", false, false, null, "Robert Johnson", null, null, "AQAAAAEAACcQAAAAELDI/2nnhgNsxNMewuDX1XWgw6P0du/FG2H9uG/rEd+ry5MrHPFxNdxWgCPNjXICDQ==", null, false, null, false, 1, "Robert Johnson" });
        }
    }
}
