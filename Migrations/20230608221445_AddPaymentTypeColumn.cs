using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    HasSubscription = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxItemsPerYear = table.Column<int>(type: "int", nullable: false),
                    HasPaid = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceType = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    LoanDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasPaid", "HasSubscription", "IsBlocked", "LockoutEnabled", "LockoutEnd", "MaxItemsPerYear", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionType", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "9ba4ac69-f29f-43fd-9696-ceb06138acf3", "admin@example.com", true, false, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEbnDbJCy6GyFqc4aqjhCWjgbXVC8DkDjDHzIn6/ayEryXZYXz6pMi2GkBnS9z8kpA==", null, false, "5544687f-363a-45f3-89cc-9acd48baa30c", "4", false, 2, "admin@example.com" },
                    { 2, 0, "47814f33-f5fc-42ff-970d-86446931724d", "librarian@example.com", true, false, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHg7O4Hd5p/v5KxBgHt7EBM1ezQ0bn7JJwHUVyWW+epwI69/DVYXEHJwVHqjsJRlyg==", null, false, "e4fa7332-4699-40da-8599-2a1acc5f3135", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "39a6bd70-a941-416e-961b-262b9a439102", "member@example.com", true, false, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOdTDHzgeNSrcS8npdCgKPLnLnkMTSaKjpNfqkCogw3XhtB1At6nov0j/ojypOnYMg==", null, false, "6ea92023-bb68-4d33-b22e-87c294b75bb8", "2", false, 0, "member@example.com" },
                    { 4, 0, "a7e7de23-fa6d-4b47-917a-0a857622e8d5", "Amari18@hotmail.com", true, false, false, false, true, null, 0, "Shanelle Strosin", "EDUARDO.RAU@HOTMAIL.COM", "REANNA_WALSH@GMAIL.COM", "AQAAAAEAACcQAAAAECYeJtSdJ3OejEzVOiZvPIM1QE8dZQfMB/4friTSgVj+13ehpwCfRaJNekjvL3LiUg==", null, false, "b7ce3ae8-f9a8-47ae-9fcf-8fa77c5ea64c", "1", false, 0, "Jaquan_Walsh@hotmail.com" },
                    { 5, 0, "9ef57db1-05c8-4168-ad54-3e6fe2805329", "Alysson_Orn@yahoo.com", true, false, false, false, true, null, 0, "Adolph Hettinger", "JERMAIN43@YAHOO.COM", "MALCOLM.HAYES54@GMAIL.COM", "AQAAAAEAACcQAAAAEE6spGID3Gw5zQ1kU9oGTGIO3kH4VxxofDKm4H2K0NhhZPjtYqyf1KxM3BeyW7Re2g==", null, false, "adb15e4f-a084-4331-823c-cb16d94163f2", "3", false, 0, "Berry.Hansen25@yahoo.com" },
                    { 6, 0, "f056efda-f6b7-41c7-93b1-447ecf1f7559", "Prince24@yahoo.com", true, false, false, false, true, null, 0, "Kamille Jacobi", "DON25@YAHOO.COM", "PEYTON_COLE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBF8l5EL5yS2RWZu18iAGD6XBx8qHvoED1JVzBazgqpjZr/uy81UvsbYrCBpDVG44w==", null, false, "efe1cbdf-36f1-44e5-b249-66ed69b7ef7e", "4", false, 0, "Lance_Berge@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Jarvis Sawayn", 1, "Port Emmy", 0, "Handmade Soft Tuna", 2010 },
                    { 2, "Darrin Blick", 0, "Vadahaven", 0, "Small Fresh Mouse", 2018 },
                    { 3, "Ervin Jacobs", 0, "New Beulahland", 0, "Sleek Plastic Bacon", 2020 },
                    { 4, "Elisa Kiehn", 2, "Shyannfort", 0, "Sleek Frozen Cheese", 2016 },
                    { 5, "Sally Toy", 0, "New Ross", 0, "Rustic Plastic Towels", 2006 },
                    { 6, "Kaylie Hoeger", 2, "West Antoinetteland", 0, "Gorgeous Concrete Computer", 2012 },
                    { 7, "Sidney West", 1, "East Kayleybury", 0, "Refined Concrete Table", 2019 },
                    { 8, "Charley Jerde", 1, "Fredamouth", 0, "Refined Soft Pants", 2001 },
                    { 9, "Breana Kessler", 1, "Lake Hannaburgh", 0, "Intelligent Fresh Hat", 2011 },
                    { 10, "Aryanna Haag", 1, "West Prince", 0, "Handmade Metal Computer", 2013 },
                    { 11, "Gwen Kuphal", 2, "New Eliezer", 0, "Intelligent Soft Sausages", 2022 },
                    { 12, "Alex Douglas", 1, "West Arch", 0, "Licensed Frozen Computer", 2023 },
                    { 13, "Elta Bosco", 2, "Conroyville", 0, "Licensed Rubber Salad", 2004 },
                    { 14, "Brian Pollich", 0, "Lake Jessica", 0, "Gorgeous Rubber Towels", 2021 },
                    { 15, "Flossie Zulauf", 2, "Shaynaview", 0, "Sleek Concrete Hat", 2004 },
                    { 16, "Lenore Gutmann", 3, "Treviontown", 0, "Ergonomic Rubber Bike", 2003 },
                    { 17, "Foster Mayer", 0, "Stantonville", 0, "Fantastic Steel Salad", 2005 },
                    { 18, "Alessandra Pollich", 1, "Pfannerstillside", 0, "Practical Soft Table", 2019 },
                    { 19, "Kaelyn Herman", 1, "Patriciafort", 0, "Small Granite Salad", 2012 },
                    { 20, "Weldon Windler", 3, "Judgeville", 0, "Practical Concrete Soap", 2013 },
                    { 21, "Florencio Cronin", 3, "Makenziebury", 0, "Awesome Metal Chicken", 2000 },
                    { 22, "Raheem Casper", 2, "South Arnulfo", 0, "Rustic Frozen Soap", 2013 },
                    { 23, "Maeve Ratke", 2, "East Werner", 0, "Generic Granite Salad", 2009 },
                    { 24, "Hailie Powlowski", 0, "Kellenton", 0, "Sleek Frozen Salad", 2023 },
                    { 25, "Deja Wiza", 2, "New Clovisland", 0, "Awesome Metal Gloves", 2012 },
                    { 26, "Dennis Prosacco", 1, "Pearliemouth", 0, "Tasty Frozen Tuna", 2020 },
                    { 27, "Moses Kris", 1, "New Brennafort", 0, "Awesome Fresh Table", 2023 },
                    { 28, "Bertrand Wintheiser", 3, "North Katlynn", 0, "Ergonomic Wooden Tuna", 2007 },
                    { 29, "Corrine Stroman", 3, "Jordihaven", 0, "Small Concrete Towels", 2000 },
                    { 30, "Chasity Wintheiser", 1, "New Dallas", 0, "Ergonomic Cotton Fish", 2017 },
                    { 31, "Reva Hamill", 2, "New Adellafurt", 0, "Sleek Cotton Pants", 2017 },
                    { 32, "Axel Erdman", 2, "Stromanfort", 0, "Intelligent Concrete Towels", 2011 },
                    { 33, "Grace Gottlieb", 0, "Boscoberg", 0, "Awesome Plastic Chips", 2000 },
                    { 34, "Leone Haag", 3, "Carrollshire", 0, "Fantastic Granite Car", 2014 },
                    { 35, "Greta Brown", 2, "Susiebury", 0, "Handcrafted Cotton Computer", 2015 },
                    { 36, "Jaren Fritsch", 3, "Leuschkeberg", 0, "Refined Frozen Chicken", 2013 },
                    { 37, "Sean Reynolds", 1, "Amaraside", 0, "Unbranded Steel Towels", 2015 },
                    { 38, "Darius Hessel", 2, "Theresiaville", 0, "Handcrafted Plastic Shoes", 2011 },
                    { 39, "Johnathan Swift", 2, "New Shanel", 0, "Practical Cotton Cheese", 2004 },
                    { 40, "Don Hammes", 0, "North Grayce", 0, "Tasty Frozen Table", 2004 },
                    { 41, "Lexi Hintz", 1, "North Judeshire", 0, "Handmade Steel Shoes", 2004 },
                    { 42, "Dana Kuphal", 1, "Beermouth", 0, "Rustic Soft Table", 2008 },
                    { 43, "Tate Bogisich", 3, "Krisborough", 0, "Incredible Wooden Sausages", 2006 },
                    { 44, "Kellen Hettinger", 0, "Ebbamouth", 0, "Fantastic Fresh Shirt", 2009 },
                    { 45, "Ray Considine", 1, "Hermistonland", 0, "Unbranded Frozen Chair", 2012 },
                    { 46, "Kristin Stiedemann", 2, "Breannemouth", 0, "Licensed Concrete Fish", 2023 },
                    { 47, "Modesta Murazik", 3, "West Mafaldaview", 0, "Gorgeous Concrete Towels", 2000 },
                    { 48, "Edd Ondricka", 3, "North Heleneside", 0, "Awesome Rubber Table", 2009 },
                    { 49, "Zander Upton", 0, "Gavinville", 0, "Rustic Steel Computer", 2000 },
                    { 50, "Myrtie Kihn", 3, "North Aubree", 0, "Licensed Fresh Salad", 2012 },
                    { 51, "Adelia Cronin", 0, "Roselynberg", 0, "Awesome Plastic Bike", 2008 },
                    { 52, "Gina Rosenbaum", 3, "Beckerside", 0, "Licensed Metal Shoes", 2010 },
                    { 53, "Garrison Trantow", 1, "Lake Dax", 0, "Tasty Rubber Shoes", 2021 },
                    { 54, "Scarlett Breitenberg", 0, "Bobbiechester", 0, "Gorgeous Metal Hat", 2000 },
                    { 55, "Jamir Haag", 0, "South Rachaelberg", 0, "Intelligent Plastic Shirt", 2015 },
                    { 56, "Vicky Schmitt", 0, "New Daphneefort", 0, "Licensed Frozen Car", 2014 },
                    { 57, "Alanis Gislason", 3, "Lake Roselynbury", 0, "Practical Frozen Cheese", 2007 },
                    { 58, "Hiram Kertzmann", 3, "East Richardstad", 0, "Practical Granite Fish", 2001 },
                    { 59, "Ceasar Hyatt", 3, "Lake Leslyside", 0, "Intelligent Soft Hat", 2019 },
                    { 60, "Dovie Ortiz", 2, "New Casper", 0, "Tasty Steel Mouse", 2014 },
                    { 61, "Forest Gerlach", 0, "Beckerland", 0, "Intelligent Soft Soap", 2016 },
                    { 62, "Jarrett McClure", 3, "Port Millerfort", 0, "Sleek Wooden Sausages", 2014 },
                    { 63, "Tania Schaefer", 3, "New Tomasaport", 0, "Generic Plastic Bike", 2020 },
                    { 64, "Mohammed Wilkinson", 3, "West Golden", 0, "Handmade Plastic Shoes", 2001 },
                    { 65, "Ayla Walter", 2, "Darrionport", 0, "Fantastic Cotton Bike", 2009 },
                    { 66, "Arvilla Davis", 2, "North Jayden", 0, "Small Concrete Cheese", 2001 },
                    { 67, "Ceasar Dibbert", 2, "East Cieloberg", 0, "Refined Cotton Chair", 2016 },
                    { 68, "Bria Okuneva", 2, "Marcellusside", 0, "Licensed Fresh Pizza", 2019 },
                    { 69, "Garland Torphy", 2, "Kristianshire", 0, "Ergonomic Steel Shirt", 2000 },
                    { 70, "Cora Kertzmann", 2, "Enoshaven", 0, "Ergonomic Cotton Gloves", 2011 },
                    { 71, "Rowan Hammes", 2, "New Don", 0, "Handmade Fresh Sausages", 2012 },
                    { 72, "Domingo Wilkinson", 1, "Dibbertton", 0, "Awesome Granite Bike", 2019 },
                    { 73, "Ole Jerde", 2, "Reesemouth", 0, "Ergonomic Wooden Tuna", 2021 },
                    { 74, "Austyn Runte", 1, "Port Deshawnview", 0, "Handmade Metal Pants", 2021 },
                    { 75, "Heather Bruen", 0, "Barrowsville", 0, "Generic Rubber Chicken", 2008 },
                    { 76, "Buddy Bradtke", 3, "Lake Wilmer", 0, "Refined Rubber Cheese", 2007 },
                    { 77, "Shaniya Littel", 0, "West Louisaland", 0, "Practical Steel Shirt", 2022 },
                    { 78, "Ola Kshlerin", 3, "Larsonland", 0, "Handmade Metal Chicken", 2010 },
                    { 79, "Seamus Luettgen", 3, "Lake Ervin", 0, "Unbranded Rubber Computer", 2022 },
                    { 80, "Vallie Wilkinson", 0, "Lake Adolphus", 0, "Generic Granite Computer", 2013 },
                    { 81, "Leatha Brakus", 3, "Port Vadaburgh", 0, "Practical Wooden Car", 2011 },
                    { 82, "Violette Bernhard", 1, "West Bobbieburgh", 0, "Fantastic Cotton Chips", 2001 },
                    { 83, "Jaime Feest", 1, "Marciafort", 0, "Incredible Concrete Chips", 2003 },
                    { 84, "Neha Emard", 1, "Port Noble", 0, "Handcrafted Fresh Fish", 2022 },
                    { 85, "Kurt Roberts", 0, "Boehmborough", 0, "Licensed Plastic Table", 2011 },
                    { 86, "Phoebe Hansen", 0, "Prohaskabury", 0, "Unbranded Rubber Pizza", 2016 },
                    { 87, "Donnie Beatty", 3, "New Preston", 0, "Licensed Granite Ball", 2008 },
                    { 88, "Victor Halvorson", 3, "New Ari", 0, "Sleek Fresh Computer", 2003 },
                    { 89, "Sam Schimmel", 2, "East Alberto", 0, "Incredible Fresh Hat", 2006 },
                    { 90, "Neil Klocko", 3, "Trantowmouth", 0, "Small Granite Towels", 2022 },
                    { 91, "Jada Trantow", 1, "Weimannburgh", 0, "Ergonomic Concrete Shirt", 2014 },
                    { 92, "Arvel Gottlieb", 0, "Lindaburgh", 0, "Fantastic Rubber Towels", 2007 },
                    { 93, "Melyna Quitzon", 1, "Wardfort", 0, "Handcrafted Steel Tuna", 2020 },
                    { 94, "Titus Gerhold", 2, "South Elena", 0, "Ergonomic Plastic Sausages", 2007 },
                    { 95, "Jalon Boehm", 0, "Stromanburgh", 0, "Intelligent Concrete Mouse", 2007 },
                    { 96, "Mathew Wilkinson", 1, "North Baylee", 0, "Incredible Granite Bike", 2002 },
                    { 97, "Rowland Swaniawski", 1, "New Jamarcus", 0, "Unbranded Fresh Fish", 2019 },
                    { 98, "Donnie Murray", 0, "West Austyn", 0, "Unbranded Rubber Table", 2009 },
                    { 99, "Assunta Olson", 2, "Schmelerview", 0, "Unbranded Frozen Chicken", 2009 },
                    { 100, "Devonte Upton", 1, "New David", 0, "Generic Steel Fish", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "New Kellieport" },
                    { 2, "Rebekahchester" },
                    { 3, "Metzside" },
                    { 4, "Annaliseview" },
                    { 5, "Ramonafort" },
                    { 6, "East Sanfordville" },
                    { 7, "Nyasiaton" },
                    { 8, "Rippinbury" },
                    { 9, "West Chloeport" },
                    { 10, "Lake Royceton" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "DueDate", "InvoiceDate", "InvoiceType", "UserId" },
                values: new object[,]
                {
                    { 1, 72.48m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 2, 86.92m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 3, 57.07m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 4, 52.75m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 5, 32.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 6, 39.82m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 7, 90.82m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 8, 19.55m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 9, 76.96m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 10, 88.08m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 11, 73.86m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 12, 59.07m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 13, 51.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 14, 13.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 15, 40.76m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 16, 46.92m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 17, 33.95m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 18, 92.86m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 19, 16.53m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 20, 51.19m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 21, 20.06m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 22, 81.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 23, 65.19m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 24, 20.50m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 25, 87.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 26, 57.66m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 27, 95.67m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 28, 22.91m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 29, 76.43m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 30, 76.06m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 31, 15.48m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 32, 68.89m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 33, 85.57m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 34, 99.58m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 35, 45.53m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 36, 48.71m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 37, 21.93m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 38, 22.93m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 39, 14.26m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 40, 98.66m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 41, 98.64m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 42, 24.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 43, 88.69m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 44, 31.36m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 45, 37.81m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 46, 43.76m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 47, 49.40m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 48, 25.98m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 49, 52.23m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 50, 20.33m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 74, new DateTime(2022, 11, 2, 15, 27, 42, 105, DateTimeKind.Local).AddTicks(2630), 3 },
                    { 2, 12, new DateTime(2023, 4, 27, 17, 18, 29, 754, DateTimeKind.Local).AddTicks(3691), 3 },
                    { 3, 80, new DateTime(2022, 12, 23, 12, 6, 43, 899, DateTimeKind.Local).AddTicks(468), 3 },
                    { 4, 86, new DateTime(2022, 11, 8, 11, 44, 51, 596, DateTimeKind.Local).AddTicks(8807), 1 },
                    { 5, 24, new DateTime(2023, 1, 31, 4, 41, 16, 531, DateTimeKind.Local).AddTicks(2416), 2 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 71, new DateTime(2022, 12, 24, 3, 34, 46, 895, DateTimeKind.Local).AddTicks(7595), 1, new DateTime(2023, 10, 12, 7, 15, 2, 573, DateTimeKind.Local).AddTicks(2475), 2 },
                    { 2, 37, new DateTime(2023, 2, 13, 5, 15, 24, 317, DateTimeKind.Local).AddTicks(3422), 1, new DateTime(2023, 7, 18, 15, 45, 58, 256, DateTimeKind.Local).AddTicks(900), 2 },
                    { 3, 39, new DateTime(2022, 7, 27, 1, 45, 35, 520, DateTimeKind.Local).AddTicks(2638), 4, new DateTime(2023, 12, 26, 13, 20, 41, 142, DateTimeKind.Local).AddTicks(6509), 3 },
                    { 4, 69, new DateTime(2023, 1, 8, 18, 17, 19, 650, DateTimeKind.Local).AddTicks(5028), 3, new DateTime(2024, 3, 12, 22, 17, 56, 759, DateTimeKind.Local).AddTicks(7162), 2 },
                    { 5, 64, new DateTime(2022, 9, 22, 16, 12, 16, 753, DateTimeKind.Local).AddTicks(7201), 5, new DateTime(2024, 2, 21, 8, 18, 52, 147, DateTimeKind.Local).AddTicks(1411), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ItemId",
                table: "Loans",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_ReservationId",
                table: "Loans",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_UserId",
                table: "Loans",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ItemId",
                table: "Reservations",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
