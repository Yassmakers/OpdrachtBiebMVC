using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasSubscription", "IsBlocked", "LockoutEnabled", "LockoutEnd", "MaxItemsPerYear", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionType", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "390721fd-b36f-4e11-9982-e1bed7d7cbfd", "admin@example.com", true, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOR82YUK/PiulTyWSCr1Ucxiq+ZeH2jlRovVqdbzjG1mBZWgdirM/qDi7DmYBK7kBw==", null, false, "77ca5a3d-e039-4b48-94b6-345bfb7a1a20", "4", false, 2, "admin@example.com" },
                    { 2, 0, "9c2f8d5b-7034-4f88-938b-5df814a0f6e3", "librarian@example.com", true, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOj+lBw7xt6kpN+sfnd7zn1eEjVtrcbppxN8bNoY+AHrRjlZ6hZmbweqdS2k4BL7vg==", null, false, "3442883d-018a-4bb6-96ec-66c7c8400027", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "2937032d-a558-48ca-9c0f-ebe5a50e1a64", "member@example.com", true, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMUXLoxQK1Wt0qUes1b5vIf/7jsyAfvmnpqdvGSV4ojxCp4rW39eoexhYe6uD/g0fg==", null, false, "15a7a42d-0595-4091-b06c-ede301c86e7c", "2", false, 0, "member@example.com" },
                    { 4, 0, "18b8b442-469f-40c9-b716-4c65884ef05d", "Danial.Frami38@yahoo.com", true, false, false, true, null, 0, "Mustafa Yundt", "JAMEY.OCONNELL32@GMAIL.COM", "MARIANNE.SAUER@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBuIDae9X09ghIff1qORicmOquBAgFPfw/qkWV369VOUJ50KsLYe6rdIEUpKnTlRfg==", null, false, "1d045988-1d24-4661-aa5a-f9078f8e87cd", "1", false, 0, "Delbert.Olson37@gmail.com" },
                    { 5, 0, "73201b46-2def-4922-b4b4-730d4a368785", "Maximo_Hodkiewicz@gmail.com", true, false, false, true, null, 0, "Lorna Gusikowski", "EVANS.DICKENS@HOTMAIL.COM", "ORRIN_CONROY82@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBFTl0kHbpm9vVDe57iVKP1gyjVwGvtFm28yDYs/Qpb7tVoCeZSE6xTYg3fEbRbKow==", null, false, "e1f72566-2a34-491f-b521-9c51938f3747", "3", false, 0, "Darius_Rippin@yahoo.com" },
                    { 6, 0, "7399ff15-e45d-4ece-abed-8b6a00f0bc07", "Wilhelmine65@yahoo.com", true, false, false, true, null, 0, "Amara Hayes", "PRICE52@YAHOO.COM", "LENORA83@YAHOO.COM", "AQAAAAEAACcQAAAAEHtyAstwC41pHVYLsKVZr0N+AufZXIQf2ENY2reUB7nlBd75WySUB5qDZhtjjiWq3w==", null, false, "1341d899-2ddb-4b24-bded-743f45f687ec", "4", false, 0, "Rae.Zboncak71@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Horace Kiehn", 1, "Krystalshire", 0, "Fantastic Wooden Hat", 2009 },
                    { 2, "Alejandra Marquardt", 0, "North Ken", 0, "Licensed Frozen Chair", 2010 },
                    { 3, "Kenton Terry", 2, "North Lizaside", 0, "Handcrafted Plastic Shoes", 2018 },
                    { 4, "Jimmy Abernathy", 2, "North Noahview", 0, "Generic Frozen Gloves", 2006 },
                    { 5, "Kayli Bauch", 0, "South Devan", 0, "Refined Cotton Bike", 2016 },
                    { 6, "Bailey Koelpin", 0, "Vanceburgh", 0, "Handcrafted Plastic Hat", 2010 },
                    { 7, "Joseph Doyle", 0, "Ratkeport", 0, "Incredible Plastic Pizza", 2015 },
                    { 8, "Mariam Turcotte", 3, "Mrazmouth", 0, "Generic Granite Pants", 2023 },
                    { 9, "Aglae Pfannerstill", 2, "Manleymouth", 0, "Generic Rubber Salad", 2007 },
                    { 10, "Maybelle Pouros", 0, "Lake Duanemouth", 0, "Sleek Wooden Soap", 2016 },
                    { 11, "Katharina Treutel", 0, "Port Katrina", 0, "Handmade Wooden Sausages", 2014 },
                    { 12, "Heber Monahan", 0, "South Schuyler", 0, "Sleek Granite Tuna", 2023 },
                    { 13, "Kristy Schmitt", 1, "Oranshire", 0, "Incredible Metal Keyboard", 2004 },
                    { 14, "Bart Gerhold", 2, "Lake Krisborough", 0, "Awesome Rubber Pants", 2023 },
                    { 15, "Shannon Kuhn", 1, "Corkeryhaven", 0, "Fantastic Soft Tuna", 2019 },
                    { 16, "Abdul Huel", 2, "Starkshire", 0, "Rustic Frozen Shirt", 2003 },
                    { 17, "Lexie Shields", 2, "Colefurt", 0, "Rustic Soft Fish", 2017 },
                    { 18, "Cordie Kohler", 1, "Port Natbury", 0, "Small Granite Chair", 2018 },
                    { 19, "Westley Stiedemann", 2, "South Garthbury", 0, "Ergonomic Concrete Tuna", 2012 },
                    { 20, "Kristoffer Considine", 1, "Borisfurt", 0, "Licensed Steel Soap", 2023 },
                    { 21, "Darien Walker", 2, "West Griffin", 0, "Rustic Frozen Cheese", 2001 },
                    { 22, "Margaret McCullough", 2, "New Yesseniaville", 0, "Awesome Steel Car", 2000 },
                    { 23, "Ronaldo Bernhard", 3, "Port Dakota", 0, "Licensed Cotton Ball", 2017 },
                    { 24, "Hosea Mohr", 3, "East Venafort", 0, "Awesome Soft Salad", 2011 },
                    { 25, "Marcelino Anderson", 1, "South Randy", 0, "Refined Plastic Shoes", 2016 },
                    { 26, "Baron Greenholt", 0, "Kassandrastad", 0, "Unbranded Soft Keyboard", 2016 },
                    { 27, "Katelyn Pouros", 3, "Angelineland", 0, "Awesome Concrete Towels", 2002 },
                    { 28, "Savanah Schaden", 3, "New Lesleyburgh", 0, "Sleek Fresh Hat", 2001 },
                    { 29, "Molly Kuhic", 2, "Bergnaumfurt", 0, "Handmade Wooden Shoes", 2022 },
                    { 30, "Carmine Rosenbaum", 2, "Lake Augustine", 0, "Rustic Rubber Chips", 2018 },
                    { 31, "Abby Zulauf", 1, "New Reece", 0, "Unbranded Granite Hat", 2011 },
                    { 32, "Kaley West", 0, "Vonborough", 0, "Unbranded Frozen Ball", 2012 },
                    { 33, "Beau Walsh", 0, "Douglastown", 0, "Tasty Soft Salad", 2009 },
                    { 34, "Ephraim Doyle", 2, "Wiltonton", 0, "Generic Soft Keyboard", 2022 },
                    { 35, "Bennie Cremin", 1, "Westport", 0, "Refined Rubber Mouse", 2023 },
                    { 36, "Steve Brown", 0, "West Lizethmouth", 0, "Practical Wooden Car", 2023 },
                    { 37, "Thaddeus Nolan", 2, "South Dillanport", 0, "Incredible Metal Fish", 2003 },
                    { 38, "Korey Armstrong", 3, "New Karina", 0, "Generic Rubber Fish", 2010 },
                    { 39, "Brook Walter", 1, "Hanechester", 0, "Rustic Plastic Bacon", 2000 },
                    { 40, "Tristian Padberg", 1, "West Orlo", 0, "Ergonomic Frozen Gloves", 2000 },
                    { 41, "Albertha Wunsch", 3, "Willchester", 0, "Handmade Steel Shoes", 2013 },
                    { 42, "Rosalee Stamm", 2, "South Colin", 0, "Rustic Concrete Table", 2022 },
                    { 43, "Moses McLaughlin", 1, "Johnstonmouth", 0, "Fantastic Wooden Chicken", 2017 },
                    { 44, "Madge Funk", 3, "Jarretmouth", 0, "Intelligent Soft Bike", 2009 },
                    { 45, "Gabe Quigley", 1, "Smithshire", 0, "Unbranded Frozen Soap", 2020 },
                    { 46, "Amya Bradtke", 3, "South Elveraview", 0, "Incredible Cotton Chips", 2015 },
                    { 47, "Courtney Gislason", 1, "New Isidroport", 0, "Handmade Steel Ball", 2001 },
                    { 48, "Jordon Champlin", 1, "Jordyport", 0, "Handcrafted Wooden Salad", 2016 },
                    { 49, "Kayla Schultz", 0, "Port Nestortown", 0, "Licensed Cotton Soap", 2006 },
                    { 50, "Casper Reynolds", 2, "Judahland", 0, "Rustic Soft Computer", 2014 },
                    { 51, "Vern White", 2, "Erdmanland", 0, "Incredible Concrete Ball", 2012 },
                    { 52, "Cedrick Gaylord", 3, "Coryville", 0, "Gorgeous Wooden Mouse", 2016 },
                    { 53, "Norbert Labadie", 1, "North Angeline", 0, "Incredible Rubber Chicken", 2000 },
                    { 54, "Nichole Hahn", 0, "New Nevabury", 0, "Incredible Steel Computer", 2010 },
                    { 55, "Clemens Casper", 2, "Bartonside", 0, "Gorgeous Wooden Fish", 2014 },
                    { 56, "Maverick Ankunding", 1, "South Caseyport", 0, "Handmade Soft Gloves", 2004 },
                    { 57, "Mabelle Jakubowski", 2, "Lake Jennie", 0, "Licensed Soft Car", 2011 },
                    { 58, "Nicola Mraz", 1, "New Theodoreshire", 0, "Tasty Frozen Salad", 2006 },
                    { 59, "Martine Labadie", 0, "North Tommie", 0, "Sleek Fresh Bike", 2000 },
                    { 60, "Edgardo Boyle", 0, "North Oral", 0, "Handmade Fresh Hat", 2008 },
                    { 61, "Freeda Cummings", 0, "Port Pamelamouth", 0, "Sleek Granite Tuna", 2007 },
                    { 62, "Berta Hauck", 1, "Lake Lilyanville", 0, "Intelligent Metal Fish", 2016 },
                    { 63, "Keaton Schneider", 1, "Fannyfurt", 0, "Fantastic Metal Cheese", 2009 },
                    { 64, "Ricardo Bailey", 0, "North Dangelo", 0, "Rustic Granite Shoes", 2009 },
                    { 65, "Diana Muller", 0, "Port Rahulmouth", 0, "Incredible Cotton Mouse", 2003 },
                    { 66, "Edwina Bruen", 3, "Schambergerbury", 0, "Rustic Wooden Bacon", 2001 },
                    { 67, "Otto Rau", 1, "Chesleyfurt", 0, "Gorgeous Cotton Sausages", 2018 },
                    { 68, "Maia Windler", 2, "New Vincenza", 0, "Fantastic Concrete Shoes", 2000 },
                    { 69, "Kendall Franecki", 0, "Hazlemouth", 0, "Sleek Concrete Shoes", 2018 },
                    { 70, "Selmer Stark", 3, "Port Thalia", 0, "Ergonomic Concrete Chicken", 2019 },
                    { 71, "Kane Kohler", 3, "Gorczanyborough", 0, "Small Soft Table", 2007 },
                    { 72, "Dereck Mitchell", 0, "Toytown", 0, "Handcrafted Frozen Bacon", 2013 },
                    { 73, "Taurean Zemlak", 0, "Zulaufburgh", 0, "Gorgeous Rubber Shoes", 2009 },
                    { 74, "Albertha Kuhn", 3, "Jaidaside", 0, "Generic Wooden Keyboard", 2003 },
                    { 75, "Abby Padberg", 3, "Hoppebury", 0, "Unbranded Steel Ball", 2019 },
                    { 76, "Franco Orn", 1, "Cartwrightton", 0, "Handcrafted Plastic Shirt", 2003 },
                    { 77, "Haley Hilll", 1, "East Magalistad", 0, "Gorgeous Plastic Tuna", 2008 },
                    { 78, "Liza Steuber", 1, "Camillafurt", 0, "Intelligent Concrete Chair", 2009 },
                    { 79, "Diamond Kub", 1, "Glennieview", 0, "Small Plastic Tuna", 2021 },
                    { 80, "Ivory Franecki", 0, "North Waylon", 0, "Rustic Fresh Gloves", 2010 },
                    { 81, "Cordia Reichert", 3, "Runolfssonview", 0, "Unbranded Steel Chair", 2007 },
                    { 82, "Kimberly Erdman", 2, "North Alysonbury", 0, "Licensed Wooden Mouse", 2012 },
                    { 83, "Jocelyn Kassulke", 3, "Breitenbergborough", 0, "Practical Steel Chicken", 2018 },
                    { 84, "Destini Durgan", 0, "East Cathrineshire", 0, "Practical Granite Bacon", 2002 },
                    { 85, "Shawn Schmeler", 0, "East Vena", 0, "Tasty Wooden Chicken", 2003 },
                    { 86, "Karine Wyman", 0, "West Georgette", 0, "Awesome Rubber Salad", 2020 },
                    { 87, "Regan Harvey", 2, "New Earnest", 0, "Unbranded Rubber Computer", 2008 },
                    { 88, "Wallace Erdman", 0, "New Aleen", 0, "Generic Steel Pizza", 2000 },
                    { 89, "Oceane Conroy", 1, "West Gertrudestad", 0, "Unbranded Granite Mouse", 2019 },
                    { 90, "Lesley Terry", 2, "Thaliachester", 0, "Gorgeous Rubber Ball", 2016 },
                    { 91, "Bailey Harris", 1, "West Burnice", 0, "Generic Fresh Salad", 2017 },
                    { 92, "Lennie O'Reilly", 2, "Larsonville", 0, "Incredible Metal Towels", 2022 },
                    { 93, "Ivy Thiel", 0, "Tomfort", 0, "Handcrafted Granite Pizza", 2011 },
                    { 94, "Ayana Huels", 1, "New Chesley", 0, "Rustic Concrete Table", 2016 },
                    { 95, "Rhianna Boyer", 2, "North Pedroview", 0, "Incredible Frozen Bacon", 2000 },
                    { 96, "Lorine Breitenberg", 0, "Hertastad", 0, "Generic Concrete Chicken", 2015 },
                    { 97, "Malvina Carroll", 2, "Rogahnbury", 0, "Sleek Frozen Chair", 2014 },
                    { 98, "Haley Beahan", 3, "New Clovis", 0, "Sleek Steel Keyboard", 2022 },
                    { 99, "Litzy Leuschke", 2, "Ashtonport", 0, "Handcrafted Cotton Salad", 2011 },
                    { 100, "Rhett Greenfelder", 3, "Aryannatown", 0, "Gorgeous Frozen Salad", 2010 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Gagechester" },
                    { 2, "North Aracelichester" },
                    { 3, "East Willisfort" },
                    { 4, "Beerland" },
                    { 5, "Collierview" },
                    { 6, "Gibsonborough" },
                    { 7, "Port Myrtie" },
                    { 8, "Lake Rocky" },
                    { 9, "Schultzfurt" },
                    { 10, "West Fay" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "DueDate", "InvoiceDate", "InvoiceType", "UserId" },
                values: new object[,]
                {
                    { 1, 11.25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 2, 37.16m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 3, 84.83m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 4, 21.95m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 5, 13.87m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 6, 39.23m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 7, 41.68m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 8, 46.63m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 9, 11.33m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 10, 22.26m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 11, 62.94m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 12, 23.83m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 13, 19.30m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 14, 94.57m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 15, 26.50m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 16, 74.86m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 17, 66.23m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 18, 73.68m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 19, 44.97m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 20, 42.27m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 21, 18.14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 22, 82.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 23, 92.68m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 24, 83.37m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 25, 26.41m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 26, 40.05m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 27, 71.44m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 28, 16.58m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 29, 69.88m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 30, 43.45m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 31, 48.81m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 32, 11.12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 33, 53.31m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 34, 35.64m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 35, 19.76m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 36, 13.00m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 37, 73.96m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 38, 42.38m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 39, 68.15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 40, 94.01m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 41, 61.20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 42, 57.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 43, 29.83m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 44, 28.63m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 45, 29.78m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 46, 95.52m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 47, 71.24m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 48, 17.46m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 49, 86.40m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 50, 11.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 19, new DateTime(2023, 3, 13, 23, 13, 4, 763, DateTimeKind.Local).AddTicks(651), 3 },
                    { 2, 47, new DateTime(2022, 11, 13, 22, 35, 4, 633, DateTimeKind.Local).AddTicks(1320), 3 },
                    { 3, 48, new DateTime(2023, 1, 22, 5, 14, 5, 395, DateTimeKind.Local).AddTicks(261), 1 },
                    { 4, 47, new DateTime(2022, 6, 16, 11, 11, 2, 835, DateTimeKind.Local).AddTicks(8426), 3 },
                    { 5, 82, new DateTime(2022, 7, 18, 10, 21, 41, 834, DateTimeKind.Local).AddTicks(8512), 2 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 17, new DateTime(2023, 3, 2, 21, 38, 0, 716, DateTimeKind.Local).AddTicks(316), 3, new DateTime(2024, 4, 18, 12, 0, 22, 68, DateTimeKind.Local).AddTicks(2671), 1 },
                    { 2, 5, new DateTime(2023, 2, 1, 3, 16, 15, 500, DateTimeKind.Local).AddTicks(7358), 2, new DateTime(2023, 8, 9, 6, 15, 30, 195, DateTimeKind.Local).AddTicks(6722), 1 },
                    { 3, 97, new DateTime(2023, 4, 17, 7, 8, 45, 38, DateTimeKind.Local).AddTicks(8552), 2, new DateTime(2023, 8, 27, 3, 25, 11, 293, DateTimeKind.Local).AddTicks(4340), 3 },
                    { 4, 98, new DateTime(2022, 11, 19, 10, 55, 4, 171, DateTimeKind.Local).AddTicks(5071), 1, new DateTime(2024, 5, 13, 8, 50, 50, 120, DateTimeKind.Local).AddTicks(1061), 1 },
                    { 5, 18, new DateTime(2022, 12, 2, 13, 22, 53, 461, DateTimeKind.Local).AddTicks(1709), 2, new DateTime(2024, 4, 6, 4, 8, 11, 881, DateTimeKind.Local).AddTicks(8234), 3 }
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
