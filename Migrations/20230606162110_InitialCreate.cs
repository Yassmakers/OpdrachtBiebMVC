using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3139084-29f4-4971-b525-5020242a8cc0", "AQAAAAEAACcQAAAAEBn4auWOKFcBriVQrcAqkPJU08mlMI4E5I3lbocF+PyCJJSrNz6ITXn8ezmcxVBzpw==", "d3f53511-8004-4bb0-98f9-dc2bada410bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ced3a36-559a-4a52-ad36-566c2120768e", "AQAAAAEAACcQAAAAEP7WnhnLiuCFh6xKRliU7qK6vnzD5X1ipaNKaOmMLoogJYQ70PzwHAut7XvRDSxk8w==", "39f7a8a1-0e2e-448f-8f82-b29e6f97623c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff2f1b2-84dd-4866-b3ec-46a9fe93bf9f", "AQAAAAEAACcQAAAAEHzWuxV5cKbCNISbTbZNkHYPD+i0C1a8D7U9RJCjrbseXqMi2dOclEUx0UmRg9vIHA==", "fc0f7b0a-31a3-48e1-a786-9e2343a331e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8a563195-c372-4273-87ad-a2779e27dafa", "Yasmin_Stiedemann@gmail.com", "Hettie Jaskolski", "ALFORD24@GMAIL.COM", "RONNY_HUELS63@HOTMAIL.COM", "AQAAAAEAACcQAAAAEMo4OUSG3hO7yES+8OKJQe4AUnjqziwtyg76XW5yzoVyh3fU7EnSQG5gOok2kA5O3g==", "373baa20-8c66-44dc-a00f-6ea1f206ca76", "Lenna.Spencer@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "996d1b6e-3bc8-40ed-b990-6ba3613f93c3", "Meda30@gmail.com", "Tobin Rohan", "MERCEDES73@YAHOO.COM", "OTTILIE.FERRY17@YAHOO.COM", "AQAAAAEAACcQAAAAENtoYjiNREFJ4WkVNNuYyHSsIFOUimwkjWIChsIe2iFX136wwzGEWOrcsM11HvA4Gg==", "0d75eefe-b24e-45a9-a36c-f53943ed56a1", "Conner70@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "04bf99b2-9994-452b-bfa6-04cc89fa0f8a", "Kiley.Steuber@hotmail.com", "Sam O'Reilly", "MAXWELL.STEHR11@HOTMAIL.COM", "LEMUEL66@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBqfGMvK3R3iSCAKmqWD3OePH+CO7h1Z9xpLYzmgr2uL3HVUq8w3Uhtlj415nfjAvw==", "c42b9cf6-bd05-4ffd-8cb5-4cfc0da30017", "Hulda.Runolfsson@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 78.31m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 37.52m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 48.38m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 36.37m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 92.66m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 15.22m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 17.80m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 12.55m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 83.73m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 28.27m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 48.51m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 20.88m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 95.10m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 14,
                column: "Amount",
                value: 82.42m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 15,
                column: "Amount",
                value: 62.65m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 82.64m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 19.22m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 18,
                column: "Amount",
                value: 33.41m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 16.64m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 20,
                column: "Amount",
                value: 96.01m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 97.17m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 83.56m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 23,
                column: "Amount",
                value: 72.37m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 27.01m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 25,
                column: "Amount",
                value: 69.57m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 93.48m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 24.63m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 28,
                column: "Amount",
                value: 82.89m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 29,
                column: "Amount",
                value: 86.70m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 30,
                column: "Amount",
                value: 25.74m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 85.05m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 81.03m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 75.56m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 88.49m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 38.95m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 48.98m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 35.80m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 87.55m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 39,
                column: "Amount",
                value: 66.06m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 39.63m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 28.97m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 87.92m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 43,
                column: "Amount",
                value: 42.31m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 16.79m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 45,
                column: "Amount",
                value: 61.21m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 46,
                column: "Amount",
                value: 89.42m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 47,
                column: "Amount",
                value: 77.00m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 49.12m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 20.49m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 65.62m, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Isidro Daniel", 3, "East Keeganville", "Gorgeous Cotton Pizza", 2019 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Priscilla McGlynn", 0, "North Natmouth", "Tasty Granite Car", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Eula Yundt", 2, "Jayneville", "Handmade Plastic Shirt", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Giovanni Predovic", 3, "Port Verna", "Handmade Wooden Chips", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Barry Greenfelder", "Jordynborough", "Intelligent Cotton Car", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Fermin Bruen", 3, "West Audreyland", "Incredible Fresh Ball", 2003 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Ned Wunsch", 0, "Emilianoburgh", "Refined Rubber Chips", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Shanelle Brown", "Adamborough", "Rustic Metal Sausages", 2004 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Jennifer Stokes", 3, "Finnshire", "Ergonomic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Henry Vandervort", 1, "East Antonette", "Practical Granite Chicken", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Carmine Kris", 1, "Corkerybury", "Refined Fresh Hat", 2003 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Antwan Crist", 2, "Wilmaland", "Tasty Metal Keyboard", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Reanna Wunsch", 2, "Garettside", "Licensed Plastic Shirt", 2019 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Darian Hills", 1, "Mayraside", "Generic Concrete Keyboard", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Winifred Collier", 2, "Frederiqueville", "Gorgeous Soft Chair", 2010 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Kieran Becker", "Nicholashaven", "Unbranded Steel Shoes", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Aniya Schinner", "West Shawnaton", "Licensed Wooden Shoes", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Monroe Trantow", 1, "East Coy", "Licensed Granite Computer", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Richard Yost", 3, "West Flo", "Rustic Rubber Pants", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Orin Blick", 2, "New Ari", "Intelligent Fresh Pizza", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Margie Zieme", 3, "North Jamilport", "Handmade Steel Keyboard", 2019 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Domenick Bartell", 3, "South Lizashire", "Ergonomic Frozen Table", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Raheem Schimmel", 1, "Brianland", "Intelligent Plastic Car", 2004 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Kenyon Schowalter", 3, "East Theodoreland", "Refined Steel Soap", 2019 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Janice Bednar", 2, "Quigleyborough", "Fantastic Plastic Towels", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Halie Grant", "Izaiahside", "Handcrafted Metal Keyboard", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Eda Hickle", 1, "Norbertoburgh", "Tasty Cotton Mouse", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alphonso Marvin", 1, "East Jailyn", "Fantastic Soft Chicken", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Mae Champlin", 2, "North Lilla", "Gorgeous Fresh Shirt", 2010 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Bailee Bartell", "Port Daryl", "Gorgeous Rubber Hat", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Kallie Feil", "Port Isai", "Fantastic Wooden Ball", 2007 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Jamal Pagac", 3, "Claudebury", "Fantastic Frozen Computer", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Ova Cassin", "Dudleybury", "Gorgeous Steel Computer", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Bailee Rowe", 3, "Lylamouth", "Rustic Cotton Ball", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Yesenia Cruickshank", 3, "Arnoldofurt", "Sleek Wooden Computer", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Viviane Kunze", 2, "North Todberg", "Fantastic Wooden Computer", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dedric McLaughlin", 3, "Lebsacktown", "Unbranded Granite Towels", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Rose Lakin", "Kohlertown", "Small Rubber Tuna", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Gerda Fahey", 0, "Lake Brown", "Sleek Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Freeman Harber", "McGlynnland", "Tasty Soft Ball", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Fleta Rippin", 2, "New Orpha", "Tasty Wooden Gloves", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Shany Okuneva", "Haneland", "Refined Concrete Fish" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Burnice Kunze", "Kuvalisborough", "Refined Metal Salad", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Eldred McDermott", 1, "Port Tomasafort", "Sleek Soft Chips", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Joanie Funk", 1, "South Baronberg", "Sleek Rubber Soap", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alena Nolan", 1, "North Ladarius", "Gorgeous Cotton Pizza", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Rodrick Collins", 3, "Mosciskiburgh", "Licensed Soft Pizza", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Orion Terry", "North Alenafurt", "Fantastic Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Jaleel Trantow", "Port Adammouth", "Tasty Granite Shoes", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dan Rice", 2, "New Gustave", "Sleek Fresh Salad", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Sonny Bogisich", "Lake Georgianafurt", "Small Granite Bacon" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Quinten Kerluke", "Stoltenbergmouth", "Rustic Cotton Pants", 2004 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alisha Davis", 0, "Lake Ariel", "Unbranded Concrete Pants", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Irwin Klocko", 0, "Bellebury", "Fantastic Frozen Pizza", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Jeremie Simonis", 3, "North Jaunita", "Tasty Fresh Table" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Hardy Brekke", 1, "Marksshire", "Gorgeous Concrete Tuna", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Marlen Kiehn", "Eramouth", "Licensed Fresh Shirt", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Mavis Hahn", 2, "Cummingsmouth", "Incredible Rubber Soap", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Willie Gerlach", 3, "New Mitchellhaven", "Handmade Soft Keyboard", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Bennie Raynor", 1, "East Shaniatown", "Sleek Granite Sausages", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Regan Bernier", 1, "Ryanburgh", "Sleek Soft Sausages", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Shirley Lockman", 0, "Rigobertobury", "Unbranded Rubber Gloves", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Vilma Effertz", 3, "East Stone", "Gorgeous Cotton Shoes", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Shakira Wyman", "North Keltonshire", "Rustic Steel Fish", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Rhea Romaguera", 1, "East Green", "Practical Cotton Bacon", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Jamil Lowe", "Sauerberg", "Ergonomic Concrete Car", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Hester Kuhn", 2, "Bogisichland", "Unbranded Concrete Shirt", 2020 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Jake Hickle", 1, "Prohaskafurt", "Licensed Concrete Mouse", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Kenny Breitenberg", 1, "Sengershire", "Handmade Rubber Ball", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Kyla Franecki", 1, "Weberhaven", "Fantastic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dorothea Greenholt", 2, "Buckridgeland", "Awesome Steel Fish", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Rollin Heller", 2, "Roderickport", "Small Wooden Shirt", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Cristopher Hyatt", 2, "Port Theresia", "Intelligent Soft Tuna", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Mitchell Hahn", 0, "New Gilbertofurt", "Intelligent Soft Bacon", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Carrie Leuschke", 1, "Wilhelminechester", "Small Steel Computer", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Una Gleichner", 2, "Port Amaramouth", "Fantastic Steel Hat", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Katelin Considine", 1, "Mariahtown", "Incredible Plastic Chicken", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Torrance Lind", "South Ephraimmouth", "Sleek Cotton Gloves", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Bettye Dickens", 2, "East Tyreetown", "Fantastic Plastic Car", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Mervin Maggio", "Schneiderland", "Handmade Frozen Sausages", 2020 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Carmine Swift", "New Caletown", "Incredible Metal Ball", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Greg Botsford", 2, "Port Josuefurt", "Practical Concrete Chair", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Karson Volkman", 3, "West Theodora", "Handcrafted Soft Towels", 2003 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Enrico Lehner", "Alffurt", "Rustic Frozen Cheese", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Reece Rempel", "South Vicente", "Practical Metal Bike", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Vida Abbott", 1, "Terrychester", "Incredible Soft Chips", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Chelsie Maggio", 1, "North Susan", "Incredible Wooden Computer", 2011 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Ambrose Powlowski", 3, "East Burley", "Intelligent Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Gordon Morissette", "Ryanfort", "Refined Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Garth Koch", 0, "New Glendaberg", "Unbranded Fresh Hat", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Buster Ratke", 0, "East Malcolmfort", "Handmade Wooden Mouse", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Robyn Mohr", "Port Kyliefort", "Incredible Soft Sausages", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Janie Casper", "South Dameon", "Licensed Granite Cheese", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Stuart Schimmel", 2, "New Lerastad", "Handmade Cotton Table", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Justine Bernhard", "Howeborough", "Incredible Plastic Ball", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Nettie Russel", 2, "Terrystad", "Fantastic Wooden Bacon", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Norris Carter", "Jenniferville", "Practical Metal Soap", 2020 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Janie Heller", 0, "South Violetteborough", "Unbranded Plastic Car", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Maeve Hammes", 2, "Wisozkburgh", "Handmade Cotton Pizza", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Paul Hilpert", 3, "Douglasland", "Intelligent Plastic Bacon", 2012 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 81, new DateTime(2023, 3, 22, 15, 40, 38, 124, DateTimeKind.Local).AddTicks(8640), 2, new DateTime(2023, 12, 26, 14, 22, 44, 925, DateTimeKind.Local).AddTicks(4795), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 78, new DateTime(2022, 12, 18, 19, 52, 6, 286, DateTimeKind.Local).AddTicks(3239), 1, new DateTime(2023, 11, 10, 19, 13, 9, 687, DateTimeKind.Local).AddTicks(9667), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate" },
                values: new object[] { 60, new DateTime(2022, 11, 14, 8, 28, 46, 849, DateTimeKind.Local).AddTicks(2863), 3, new DateTime(2024, 4, 20, 19, 19, 59, 462, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 98, new DateTime(2023, 4, 26, 5, 24, 22, 604, DateTimeKind.Local).AddTicks(2492), 1, new DateTime(2023, 7, 24, 14, 30, 27, 145, DateTimeKind.Local).AddTicks(1646), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 46, new DateTime(2023, 2, 5, 7, 7, 56, 578, DateTimeKind.Local).AddTicks(8530), 4, new DateTime(2023, 10, 18, 20, 35, 19, 383, DateTimeKind.Local).AddTicks(1802), 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationName",
                value: "Lake Clarabelle");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocationName",
                value: "Wolfmouth");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationName",
                value: "Lake Elta");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocationName",
                value: "East Brandthaven");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocationName",
                value: "East Isabel");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "LocationName",
                value: "Kuphalton");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "LocationName",
                value: "Jackelineburgh");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "LocationName",
                value: "New Austynberg");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "LocationName",
                value: "Lauriannehaven");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "LocationName",
                value: "East Sarina");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 43, new DateTime(2023, 4, 12, 6, 14, 18, 389, DateTimeKind.Local).AddTicks(8914), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "ReservationDate" },
                values: new object[] { 87, new DateTime(2023, 2, 4, 0, 17, 28, 875, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 7, new DateTime(2023, 6, 5, 15, 19, 17, 292, DateTimeKind.Local).AddTicks(7912), 1 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 91, new DateTime(2023, 3, 11, 12, 27, 37, 311, DateTimeKind.Local).AddTicks(4149), 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemId", "ReservationDate" },
                values: new object[] { 4, new DateTime(2023, 5, 23, 19, 10, 6, 276, DateTimeKind.Local).AddTicks(6344) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a33900-6a1d-4115-8cfe-5cd65506fdd7", "AQAAAAEAACcQAAAAEHumYUpiEnL20BYmkDhBm+DGg1+YKqe1KnLQwMu2RtV36JSkNRQrtd3+FXhTAPmZEw==", "673bbe76-5b9f-4325-a1ec-a9141d8803ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838718a4-da68-40c8-bcaf-d885b3f7feb8", "AQAAAAEAACcQAAAAEKgy++PkuUtukNXqZbno28HIJf7dDLE+FskUnK9FmSnYOwLOyfHckqtTLOA25otP7Q==", "dd6b60f3-5c92-46aa-b2f0-cdeb7276953f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1831ee4c-66d5-4a8d-9875-b344c1afe7db", "AQAAAAEAACcQAAAAEIOTcF8xu7tUEbyLY5QZ9P9LxOTOuoQ7YxNdXvmYJDrXKD9EYr4zAK8IVxGyckmwdA==", "f9fe5d63-be67-4f9b-b13a-4bff46d9eb21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ef1b7070-3079-4653-96ea-26abf6fb9c29", "Rogers_McClure@hotmail.com", "Emelie Jast", "BILLIE_POLLICH@HOTMAIL.COM", "ROSALIA.TORPHY28@YAHOO.COM", "AQAAAAEAACcQAAAAEKV5wT7FXMRrmyjC3zvOUTDpX48iMdB/ipPlABEnO4T6nOd46hN8h4B+zhBoHq8EDg==", "d13a68da-52f4-4420-9c80-faf4522f39dd", "Amelie.Hagenes@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8bf990c4-1d38-46be-80cf-c61f18205308", "Caleb.Hickle50@gmail.com", "Akeem Bernier", "CALLIE.STOKES80@YAHOO.COM", "BENNETT_PACOCHA@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJzAZA2kMIaEyvc2ur0eHASB2/SoDbNMX77R+cJY1vCwkSUM3pU7rjYboqDNzRetEw==", "086f700b-2b0c-4e34-a788-87e4d09cb871", "Damaris90@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c105c087-656f-40cf-9eeb-5adb3849e96e", "Mekhi_Cassin@yahoo.com", "Sienna Prohaska", "LACEY48@GMAIL.COM", "KEIRA_NITZSCHE82@YAHOO.COM", "AQAAAAEAACcQAAAAEGt6FTNoNUdzLNGTuDtLmVm9fArAifr6WDRdWTZjC+txl1Qs1GueGOQtE+f5prscIw==", "b67a6eaa-d3b4-4031-8442-30944909e62c", "Damien11@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 63.07m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 22.45m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 66.42m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 19.59m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 57.57m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 50.86m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 32.19m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 43.84m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 96.18m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 84.80m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 15.79m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 90.51m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 77.27m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 14,
                column: "Amount",
                value: 99.65m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 15,
                column: "Amount",
                value: 51.09m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 12.38m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 56.43m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 18,
                column: "Amount",
                value: 28.48m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 84.72m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 20,
                column: "Amount",
                value: 32.23m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 53.67m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 47.03m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 23,
                column: "Amount",
                value: 68.13m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 68.08m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 25,
                column: "Amount",
                value: 33.27m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 62.39m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 80.15m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 28,
                column: "Amount",
                value: 25.95m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 29,
                column: "Amount",
                value: 30.52m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 30,
                column: "Amount",
                value: 99.14m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 23.52m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 11.43m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 41.82m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 88.72m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 16.47m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 81.09m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 17.13m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 52.40m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 39,
                column: "Amount",
                value: 59.75m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 36.68m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 49.58m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 58.91m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 43,
                column: "Amount",
                value: 87.69m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 18.61m, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 45,
                column: "Amount",
                value: 68.01m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 46,
                column: "Amount",
                value: 68.95m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 47,
                column: "Amount",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 39.95m, 3 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 51.91m, 2 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "UserId" },
                values: new object[] { 57.91m, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alejandrin Dickens", 1, "South Fredericmouth", "Licensed Soft Table", 2004 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Delilah Stanton", 2, "East Freddie", "Refined Plastic Chicken", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Liliane Von", 1, "West Edgardo", "Refined Concrete Hat", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dominique Huel", 2, "Wildermanfort", "Small Wooden Computer", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Brandyn Ruecker", "South Yoshiko", "Practical Plastic Gloves", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Krista Aufderhar", 2, "South Kenyon", "Licensed Soft Shirt", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Annabelle Abernathy", 3, "Lake Ora", "Ergonomic Rubber Salad", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Arvel Blick", "Pietromouth", "Small Soft Tuna", 2003 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Emma Renner", 0, "Hughmouth", "Rustic Cotton Towels" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Ronny Turcotte", 2, "Port Natburgh", "Ergonomic Frozen Salad", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Marvin Halvorson", 3, "Effertzfurt", "Rustic Metal Chair", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Raina Windler", 1, "Lake Filomena", "Practical Metal Chips", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Jacky Koepp", 3, "West Edmond", "Unbranded Steel Shirt", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Jodie Hills", 3, "West Waldofurt", "Practical Frozen Tuna", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Ali Steuber", 0, "Port Dalebury", "Practical Cotton Shirt", 2007 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Lemuel Kuvalis", "East Kennithbury", "Unbranded Frozen Bike", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Andrew Wuckert", "Ahmedside", "Gorgeous Soft Chicken", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Mekhi Hilll", 2, "Howellland", "Intelligent Granite Hat", 2003 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Althea Wisoky", 1, "Gaylordchester", "Handmade Granite Towels", 2010 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dorothea Haag", 0, "Stokesmouth", "Gorgeous Soft Shirt", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Calista Ritchie", 2, "Dedrickberg", "Ergonomic Wooden Car", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Orlo West", 1, "Davidshire", "Rustic Metal Pants", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Marvin Denesik", 0, "Lake Marionview", "Ergonomic Metal Chair", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Beryl Larson", 1, "Port Austyn", "Generic Metal Pants", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Lourdes Sporer", 0, "Murraystad", "Incredible Cotton Hat", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Conor Hyatt", "Queenshire", "Rustic Granite Hat", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Polly Feil", 3, "Heaneyview", "Unbranded Concrete Soap", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Juanita Cormier", 3, "New Ashlystad", "Awesome Cotton Gloves", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dagmar Osinski", 0, "Borisborough", "Incredible Metal Chips", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Donnie Huel", "Torphymouth", "Tasty Wooden Soap", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Guy Littel", "Macistad", "Sleek Fresh Pizza", 2010 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Mackenzie Oberbrunner", 2, "Eldorafurt", "Generic Cotton Shirt", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Casper Beahan", "Bergnaumburgh", "Handmade Metal Tuna", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Neal Ferry", 0, "Loyburgh", "Tasty Metal Table", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Rosella Bode", 0, "Nicolettemouth", "Handcrafted Metal Cheese", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Felicia Batz", 1, "Annehaven", "Handmade Granite Tuna", 2007 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Serena Goodwin", 0, "Dibbertstad", "Refined Metal Mouse", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Sam Grant", "Christafort", "Intelligent Rubber Chicken", 2004 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Karen Abernathy", 2, "McGlynnville", "Refined Fresh Keyboard" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Melvin Schroeder", "North Enid", "Fantastic Fresh Fish", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Daphney Tremblay", 1, "Elissaland", "Generic Steel Shirt", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Annamae Rolfson", "Jerryview", "Awesome Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Margaret Schmitt", "West Jameymouth", "Practical Frozen Chicken", 2020 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Nathanial Orn", 3, "Jacobiland", "Tasty Soft Hat", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Gilbert Rosenbaum", 3, "South Paxtonberg", "Ergonomic Cotton Computer", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Lue Tromp", 2, "Reillymouth", "Tasty Wooden Cheese", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Zachary Senger", 1, "Laishamouth", "Small Plastic Chicken", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Araceli Lind", "Port Roosevelt", "Ergonomic Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Hortense Block", "Port Adan", "Handmade Soft Computer", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alexandrea Denesik", 1, "Jensenstad", "Handmade Concrete Pizza", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Douglas Lang", "Angelaview", "Incredible Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Keara Torp", "Joeymouth", "Handcrafted Steel Chair", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Ally VonRueden", 2, "Rollinton", "Sleek Soft Chair", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Brandyn Quigley", 1, "West Leslie", "Refined Steel Shoes", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Ernesto Ullrich", 0, "Lake Devan", "Rustic Rubber Hat" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Eda Hane", 0, "Port Athena", "Small Plastic Fish", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Jed Gleason", "Ritchietown", "Rustic Granite Chair", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Elenora Graham", 0, "New Sunnybury", "Handcrafted Cotton Soap", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Alyce Doyle", 0, "Considinebury", "Handcrafted Plastic Soap", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Felicity Kilback", 3, "Shirleyville", "Sleek Plastic Shoes", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Lisa Harvey", 3, "Blakebury", "Licensed Concrete Gloves", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Johanna Frami", 2, "Jeradton", "Generic Metal Cheese", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Kacey Hyatt", 1, "Naderton", "Gorgeous Rubber Table", 2015 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Vivien Cummings", "New Brookston", "Ergonomic Frozen Bike", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Paige Walker", 0, "Kerlukeland", "Generic Metal Salad", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Mylene O'Reilly", "Lake Eleanoraborough", "Ergonomic Soft Chicken", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Kaleigh Thompson", 3, "Doloreshaven", "Tasty Metal Table", 2016 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Eleanore Tromp", 3, "Kittymouth", "Awesome Steel Mouse", 2007 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Trace Langworth", 2, "Randalberg", "Unbranded Fresh Bacon", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Leland Koss", 3, "West Jarrell", "Licensed Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Louvenia Bogisich", 1, "Annastad", "Rustic Plastic Pizza", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Gertrude Osinski", 1, "Lake Lazarobury", "Unbranded Granite Fish", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Sarina Ritchie", 1, "Hoegerton", "Small Plastic Fish", 2012 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Thea Sporer", 2, "North Irmaton", "Refined Steel Pizza", 2014 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Kelly Keeling", 2, "Lisettemouth", "Licensed Frozen Keyboard", 2022 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Merle Macejkovic", 0, "Blockmouth", "Ergonomic Fresh Shirt", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Virginia Auer", 3, "Lake Joanny", "Practical Fresh Bacon", 2010 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Celestino Bahringer", "Lake Emmanuelview", "Unbranded Frozen Table", 2000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Andreanne O'Kon", 3, "South Catalinaport", "Tasty Cotton Pants", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Thea Rau", "North Jarodtown", "Awesome Granite Computer", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Lea Hahn", "Sabinashire", "Unbranded Granite Towels", 2017 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "George Armstrong", 3, "Reichertstad", "Unbranded Wooden Chips", 2005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Annabelle Ratke", 0, "Steuberville", "Handcrafted Concrete Table", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Krystel Smith", "Summerfurt", "Awesome Frozen Chicken", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Gideon Hoeger", "Port Loyalshire", "Generic Fresh Fish", 2011 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Nova Mante", 0, "Bartolettifurt", "Gorgeous Steel Fish", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Joannie McGlynn", 3, "Bernadettebury", "Sleek Concrete Fish", 2021 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Author", "ItemType", "Location", "Title" },
                values: new object[] { "Eriberto Strosin", 2, "Maximomouth", "Small Steel Chair" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Author", "Location", "Title" },
                values: new object[] { "Bertha Jones", "Francestown", "Small Steel Keyboard" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Dameon Lindgren", 1, "Pasqualeton", "Ergonomic Metal Chicken", 2002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Columbus Feest", 3, "Vonfurt", "Rustic Frozen Shoes", 2008 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Lessie Mosciski", "Bradlybury", "Fantastic Soft Tuna", 2007 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Amie Stokes", "Casimershire", "Incredible Concrete Cheese", 2018 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Ova Frami", 1, "Buckridgebury", "Tasty Concrete Fish", 2009 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Nicholaus Waelchi", "East Nathanael", "Small Cotton Chair", 2019 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Terrance Sporer", 1, "Pierremouth", "Gorgeous Concrete Tuna", 2001 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Author", "Location", "Title", "Year" },
                values: new object[] { "Juliana Sanford", "Gradytown", "Tasty Wooden Pizza", 2023 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Jarvis Zboncak", 1, "Kochberg", "Licensed Plastic Fish", 2006 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Marty Muller", 1, "Port Fredashire", "Incredible Plastic Chicken", 2013 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Author", "ItemType", "Location", "Title", "Year" },
                values: new object[] { "Hillary Jacobs", 1, "Cartertown", "Intelligent Wooden Computer", 2021 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 96, new DateTime(2022, 6, 15, 18, 7, 19, 514, DateTimeKind.Local).AddTicks(9182), 1, new DateTime(2023, 6, 7, 13, 46, 31, 843, DateTimeKind.Local).AddTicks(5865), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 87, new DateTime(2023, 2, 8, 5, 30, 53, 671, DateTimeKind.Local).AddTicks(2961), 3, new DateTime(2024, 5, 8, 20, 0, 43, 9, DateTimeKind.Local).AddTicks(7623), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate" },
                values: new object[] { 73, new DateTime(2022, 11, 21, 16, 3, 16, 543, DateTimeKind.Local).AddTicks(1527), 1, new DateTime(2023, 11, 28, 18, 51, 24, 842, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 37, new DateTime(2022, 12, 8, 13, 41, 36, 981, DateTimeKind.Local).AddTicks(2789), 3, new DateTime(2023, 10, 25, 11, 29, 30, 261, DateTimeKind.Local).AddTicks(3123), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[] { 14, new DateTime(2023, 5, 30, 16, 36, 5, 473, DateTimeKind.Local).AddTicks(3461), 5, new DateTime(2024, 5, 8, 6, 0, 13, 933, DateTimeKind.Local).AddTicks(1977), 2 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "LocationName",
                value: "Port Alexandreview");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LocationName",
                value: "Hacketttown");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationName",
                value: "Port Mauricioville");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "LocationName",
                value: "West Eldredchester");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "LocationName",
                value: "North Felipastad");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "LocationName",
                value: "Beaulahside");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "LocationName",
                value: "West Wadeshire");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "LocationName",
                value: "West Kip");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "LocationName",
                value: "North Eloiseport");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "LocationName",
                value: "West Addison");

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 27, new DateTime(2022, 10, 9, 3, 30, 57, 914, DateTimeKind.Local).AddTicks(9964), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ItemId", "ReservationDate" },
                values: new object[] { 58, new DateTime(2022, 9, 17, 20, 27, 25, 103, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 76, new DateTime(2023, 5, 12, 21, 48, 41, 289, DateTimeKind.Local).AddTicks(5653), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ItemId", "ReservationDate", "UserId" },
                values: new object[] { 72, new DateTime(2023, 5, 24, 14, 24, 20, 5, DateTimeKind.Local).AddTicks(1414), 2 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ItemId", "ReservationDate" },
                values: new object[] { 53, new DateTime(2022, 9, 7, 2, 1, 12, 175, DateTimeKind.Local).AddTicks(3401) });
        }
    }
}
