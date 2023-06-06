using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class asdlp : Migration
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
                    { 1, 0, "d3a33900-6a1d-4115-8cfe-5cd65506fdd7", "admin@example.com", true, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHumYUpiEnL20BYmkDhBm+DGg1+YKqe1KnLQwMu2RtV36JSkNRQrtd3+FXhTAPmZEw==", null, false, "673bbe76-5b9f-4325-a1ec-a9141d8803ec", "4", false, 2, "admin@example.com" },
                    { 2, 0, "838718a4-da68-40c8-bcaf-d885b3f7feb8", "librarian@example.com", true, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKgy++PkuUtukNXqZbno28HIJf7dDLE+FskUnK9FmSnYOwLOyfHckqtTLOA25otP7Q==", null, false, "dd6b60f3-5c92-46aa-b2f0-cdeb7276953f", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "1831ee4c-66d5-4a8d-9875-b344c1afe7db", "member@example.com", true, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEIOTcF8xu7tUEbyLY5QZ9P9LxOTOuoQ7YxNdXvmYJDrXKD9EYr4zAK8IVxGyckmwdA==", null, false, "f9fe5d63-be67-4f9b-b13a-4bff46d9eb21", "2", false, 0, "member@example.com" },
                    { 4, 0, "ef1b7070-3079-4653-96ea-26abf6fb9c29", "Rogers_McClure@hotmail.com", true, false, false, true, null, 0, "Emelie Jast", "BILLIE_POLLICH@HOTMAIL.COM", "ROSALIA.TORPHY28@YAHOO.COM", "AQAAAAEAACcQAAAAEKV5wT7FXMRrmyjC3zvOUTDpX48iMdB/ipPlABEnO4T6nOd46hN8h4B+zhBoHq8EDg==", null, false, "d13a68da-52f4-4420-9c80-faf4522f39dd", "1", false, 0, "Amelie.Hagenes@yahoo.com" },
                    { 5, 0, "8bf990c4-1d38-46be-80cf-c61f18205308", "Caleb.Hickle50@gmail.com", true, false, false, true, null, 0, "Akeem Bernier", "CALLIE.STOKES80@YAHOO.COM", "BENNETT_PACOCHA@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJzAZA2kMIaEyvc2ur0eHASB2/SoDbNMX77R+cJY1vCwkSUM3pU7rjYboqDNzRetEw==", null, false, "086f700b-2b0c-4e34-a788-87e4d09cb871", "3", false, 0, "Damaris90@yahoo.com" },
                    { 6, 0, "c105c087-656f-40cf-9eeb-5adb3849e96e", "Mekhi_Cassin@yahoo.com", true, false, false, true, null, 0, "Sienna Prohaska", "LACEY48@GMAIL.COM", "KEIRA_NITZSCHE82@YAHOO.COM", "AQAAAAEAACcQAAAAEGt6FTNoNUdzLNGTuDtLmVm9fArAifr6WDRdWTZjC+txl1Qs1GueGOQtE+f5prscIw==", null, false, "b67a6eaa-d3b4-4031-8442-30944909e62c", "4", false, 0, "Damien11@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Alejandrin Dickens", 1, "South Fredericmouth", 0, "Licensed Soft Table", 2004 },
                    { 2, "Delilah Stanton", 2, "East Freddie", 0, "Refined Plastic Chicken", 2005 },
                    { 3, "Liliane Von", 1, "West Edgardo", 0, "Refined Concrete Hat", 2021 },
                    { 4, "Dominique Huel", 2, "Wildermanfort", 0, "Small Wooden Computer", 2009 },
                    { 5, "Brandyn Ruecker", 2, "South Yoshiko", 0, "Practical Plastic Gloves", 2018 },
                    { 6, "Krista Aufderhar", 2, "South Kenyon", 0, "Licensed Soft Shirt", 2016 },
                    { 7, "Annabelle Abernathy", 3, "Lake Ora", 0, "Ergonomic Rubber Salad", 2009 },
                    { 8, "Arvel Blick", 0, "Pietromouth", 0, "Small Soft Tuna", 2003 },
                    { 9, "Emma Renner", 0, "Hughmouth", 0, "Rustic Cotton Towels", 2011 },
                    { 10, "Ronny Turcotte", 2, "Port Natburgh", 0, "Ergonomic Frozen Salad", 2022 },
                    { 11, "Marvin Halvorson", 3, "Effertzfurt", 0, "Rustic Metal Chair", 2023 },
                    { 12, "Raina Windler", 1, "Lake Filomena", 0, "Practical Metal Chips", 2018 },
                    { 13, "Jacky Koepp", 3, "West Edmond", 0, "Unbranded Steel Shirt", 2006 },
                    { 14, "Jodie Hills", 3, "West Waldofurt", 0, "Practical Frozen Tuna", 2001 },
                    { 15, "Ali Steuber", 0, "Port Dalebury", 0, "Practical Cotton Shirt", 2007 },
                    { 16, "Lemuel Kuvalis", 3, "East Kennithbury", 0, "Unbranded Frozen Bike", 2017 },
                    { 17, "Andrew Wuckert", 2, "Ahmedside", 0, "Gorgeous Soft Chicken", 2021 },
                    { 18, "Mekhi Hilll", 2, "Howellland", 0, "Intelligent Granite Hat", 2003 },
                    { 19, "Althea Wisoky", 1, "Gaylordchester", 0, "Handmade Granite Towels", 2010 },
                    { 20, "Dorothea Haag", 0, "Stokesmouth", 0, "Gorgeous Soft Shirt", 2000 },
                    { 21, "Calista Ritchie", 2, "Dedrickberg", 0, "Ergonomic Wooden Car", 2016 },
                    { 22, "Orlo West", 1, "Davidshire", 0, "Rustic Metal Pants", 2017 },
                    { 23, "Marvin Denesik", 0, "Lake Marionview", 0, "Ergonomic Metal Chair", 2023 },
                    { 24, "Beryl Larson", 1, "Port Austyn", 0, "Generic Metal Pants", 2005 },
                    { 25, "Lourdes Sporer", 0, "Murraystad", 0, "Incredible Cotton Hat", 2012 },
                    { 26, "Conor Hyatt", 1, "Queenshire", 0, "Rustic Granite Hat", 2000 },
                    { 27, "Polly Feil", 3, "Heaneyview", 0, "Unbranded Concrete Soap", 2016 },
                    { 28, "Juanita Cormier", 3, "New Ashlystad", 0, "Awesome Cotton Gloves", 2006 },
                    { 29, "Dagmar Osinski", 0, "Borisborough", 0, "Incredible Metal Chips", 2021 },
                    { 30, "Donnie Huel", 2, "Torphymouth", 0, "Tasty Wooden Soap", 2009 },
                    { 31, "Guy Littel", 2, "Macistad", 0, "Sleek Fresh Pizza", 2010 },
                    { 32, "Mackenzie Oberbrunner", 2, "Eldorafurt", 0, "Generic Cotton Shirt", 2008 },
                    { 33, "Casper Beahan", 3, "Bergnaumburgh", 0, "Handmade Metal Tuna", 2017 },
                    { 34, "Neal Ferry", 0, "Loyburgh", 0, "Tasty Metal Table", 2006 },
                    { 35, "Rosella Bode", 0, "Nicolettemouth", 0, "Handcrafted Metal Cheese", 2012 },
                    { 36, "Felicia Batz", 1, "Annehaven", 0, "Handmade Granite Tuna", 2007 },
                    { 37, "Serena Goodwin", 0, "Dibbertstad", 0, "Refined Metal Mouse", 2009 },
                    { 38, "Sam Grant", 2, "Christafort", 0, "Intelligent Rubber Chicken", 2004 },
                    { 39, "Karen Abernathy", 2, "McGlynnville", 0, "Refined Fresh Keyboard", 2005 },
                    { 40, "Melvin Schroeder", 0, "North Enid", 0, "Fantastic Fresh Fish", 2013 },
                    { 41, "Daphney Tremblay", 1, "Elissaland", 0, "Generic Steel Shirt", 2005 },
                    { 42, "Annamae Rolfson", 1, "Jerryview", 0, "Awesome Concrete Towels", 2008 },
                    { 43, "Margaret Schmitt", 2, "West Jameymouth", 0, "Practical Frozen Chicken", 2020 },
                    { 44, "Nathanial Orn", 3, "Jacobiland", 0, "Tasty Soft Hat", 2021 },
                    { 45, "Gilbert Rosenbaum", 3, "South Paxtonberg", 0, "Ergonomic Cotton Computer", 2018 },
                    { 46, "Lue Tromp", 2, "Reillymouth", 0, "Tasty Wooden Cheese", 2015 },
                    { 47, "Zachary Senger", 1, "Laishamouth", 0, "Small Plastic Chicken", 2009 },
                    { 48, "Araceli Lind", 3, "Port Roosevelt", 0, "Ergonomic Rubber Bike", 2003 },
                    { 49, "Hortense Block", 1, "Port Adan", 0, "Handmade Soft Computer", 2002 },
                    { 50, "Alexandrea Denesik", 1, "Jensenstad", 0, "Handmade Concrete Pizza", 2001 },
                    { 51, "Douglas Lang", 1, "Angelaview", 0, "Incredible Metal Towels", 2021 },
                    { 52, "Keara Torp", 1, "Joeymouth", 0, "Handcrafted Steel Chair", 2005 },
                    { 53, "Ally VonRueden", 2, "Rollinton", 0, "Sleek Soft Chair", 2006 },
                    { 54, "Brandyn Quigley", 1, "West Leslie", 0, "Refined Steel Shoes", 2023 },
                    { 55, "Ernesto Ullrich", 0, "Lake Devan", 0, "Rustic Rubber Hat", 2022 },
                    { 56, "Eda Hane", 0, "Port Athena", 0, "Small Plastic Fish", 2018 },
                    { 57, "Jed Gleason", 1, "Ritchietown", 0, "Rustic Granite Chair", 2017 },
                    { 58, "Elenora Graham", 0, "New Sunnybury", 0, "Handcrafted Cotton Soap", 2013 },
                    { 59, "Alyce Doyle", 0, "Considinebury", 0, "Handcrafted Plastic Soap", 2006 },
                    { 60, "Felicity Kilback", 3, "Shirleyville", 0, "Sleek Plastic Shoes", 2018 },
                    { 61, "Lisa Harvey", 3, "Blakebury", 0, "Licensed Concrete Gloves", 2008 },
                    { 62, "Johanna Frami", 2, "Jeradton", 0, "Generic Metal Cheese", 2008 },
                    { 63, "Kacey Hyatt", 1, "Naderton", 0, "Gorgeous Rubber Table", 2015 },
                    { 64, "Vivien Cummings", 0, "New Brookston", 0, "Ergonomic Frozen Bike", 2021 },
                    { 65, "Paige Walker", 0, "Kerlukeland", 0, "Generic Metal Salad", 2014 },
                    { 66, "Mylene O'Reilly", 3, "Lake Eleanoraborough", 0, "Ergonomic Soft Chicken", 2018 },
                    { 67, "Kaleigh Thompson", 3, "Doloreshaven", 0, "Tasty Metal Table", 2016 },
                    { 68, "Eleanore Tromp", 3, "Kittymouth", 0, "Awesome Steel Mouse", 2007 },
                    { 69, "Trace Langworth", 2, "Randalberg", 0, "Unbranded Fresh Bacon", 2006 },
                    { 70, "Leland Koss", 3, "West Jarrell", 0, "Licensed Steel Shirt", 2006 },
                    { 71, "Louvenia Bogisich", 1, "Annastad", 0, "Rustic Plastic Pizza", 2009 },
                    { 72, "Gertrude Osinski", 1, "Lake Lazarobury", 0, "Unbranded Granite Fish", 2000 },
                    { 73, "Sarina Ritchie", 1, "Hoegerton", 0, "Small Plastic Fish", 2012 },
                    { 74, "Thea Sporer", 2, "North Irmaton", 0, "Refined Steel Pizza", 2014 },
                    { 75, "Kelly Keeling", 2, "Lisettemouth", 0, "Licensed Frozen Keyboard", 2022 },
                    { 76, "Merle Macejkovic", 0, "Blockmouth", 0, "Ergonomic Fresh Shirt", 2017 },
                    { 77, "Virginia Auer", 3, "Lake Joanny", 0, "Practical Fresh Bacon", 2010 },
                    { 78, "Celestino Bahringer", 1, "Lake Emmanuelview", 0, "Unbranded Frozen Table", 2000 },
                    { 79, "Andreanne O'Kon", 3, "South Catalinaport", 0, "Tasty Cotton Pants", 2017 },
                    { 80, "Thea Rau", 1, "North Jarodtown", 0, "Awesome Granite Computer", 2018 },
                    { 81, "Lea Hahn", 1, "Sabinashire", 0, "Unbranded Granite Towels", 2017 },
                    { 82, "George Armstrong", 3, "Reichertstad", 0, "Unbranded Wooden Chips", 2005 },
                    { 83, "Annabelle Ratke", 0, "Steuberville", 0, "Handcrafted Concrete Table", 2008 },
                    { 84, "Krystel Smith", 0, "Summerfurt", 0, "Awesome Frozen Chicken", 2002 },
                    { 85, "Gideon Hoeger", 3, "Port Loyalshire", 0, "Generic Fresh Fish", 2011 },
                    { 86, "Nova Mante", 0, "Bartolettifurt", 0, "Gorgeous Steel Fish", 2018 },
                    { 87, "Joannie McGlynn", 3, "Bernadettebury", 0, "Sleek Concrete Fish", 2021 },
                    { 88, "Eriberto Strosin", 2, "Maximomouth", 0, "Small Steel Chair", 2008 },
                    { 89, "Bertha Jones", 0, "Francestown", 0, "Small Steel Keyboard", 2000 },
                    { 90, "Dameon Lindgren", 1, "Pasqualeton", 0, "Ergonomic Metal Chicken", 2002 },
                    { 91, "Columbus Feest", 3, "Vonfurt", 0, "Rustic Frozen Shoes", 2008 },
                    { 92, "Lessie Mosciski", 0, "Bradlybury", 0, "Fantastic Soft Tuna", 2007 },
                    { 93, "Amie Stokes", 1, "Casimershire", 0, "Incredible Concrete Cheese", 2018 },
                    { 94, "Ova Frami", 1, "Buckridgebury", 0, "Tasty Concrete Fish", 2009 },
                    { 95, "Nicholaus Waelchi", 0, "East Nathanael", 0, "Small Cotton Chair", 2019 },
                    { 96, "Terrance Sporer", 1, "Pierremouth", 0, "Gorgeous Concrete Tuna", 2001 },
                    { 97, "Juliana Sanford", 0, "Gradytown", 0, "Tasty Wooden Pizza", 2023 },
                    { 98, "Jarvis Zboncak", 1, "Kochberg", 0, "Licensed Plastic Fish", 2006 },
                    { 99, "Marty Muller", 1, "Port Fredashire", 0, "Incredible Plastic Chicken", 2013 },
                    { 100, "Hillary Jacobs", 1, "Cartertown", 0, "Intelligent Wooden Computer", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Port Alexandreview" },
                    { 2, "Hacketttown" },
                    { 3, "Port Mauricioville" },
                    { 4, "West Eldredchester" },
                    { 5, "North Felipastad" },
                    { 6, "Beaulahside" },
                    { 7, "West Wadeshire" },
                    { 8, "West Kip" },
                    { 9, "North Eloiseport" },
                    { 10, "West Addison" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "DueDate", "InvoiceDate", "InvoiceType", "UserId" },
                values: new object[,]
                {
                    { 1, 63.07m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 2, 22.45m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 3, 66.42m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 4, 19.59m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 5, 57.57m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 6, 50.86m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 7, 32.19m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 8, 43.84m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 9, 96.18m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 10, 84.80m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 11, 15.79m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 12, 90.51m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 13, 77.27m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 14, 99.65m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 15, 51.09m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 16, 12.38m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 17, 56.43m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 18, 28.48m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 19, 84.72m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 20, 32.23m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 21, 53.67m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 22, 47.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 23, 68.13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 24, 68.08m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 25, 33.27m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 26, 62.39m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 27, 80.15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 28, 25.95m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 29, 30.52m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 30, 99.14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 31, 23.52m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 32, 11.43m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 33, 41.82m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 34, 88.72m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 35, 16.47m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 36, 81.09m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 37, 17.13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 38, 52.40m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 39, 59.75m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 40, 36.68m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 41, 49.58m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 42, 58.91m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 43, 87.69m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 44, 18.61m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 45, 68.01m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 46, 68.95m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 47, 19.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 48, 39.95m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 49, 51.91m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 50, 57.91m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(2022, 10, 9, 3, 30, 57, 914, DateTimeKind.Local).AddTicks(9964), 2 },
                    { 2, 58, new DateTime(2022, 9, 17, 20, 27, 25, 103, DateTimeKind.Local).AddTicks(4838), 3 },
                    { 3, 76, new DateTime(2023, 5, 12, 21, 48, 41, 289, DateTimeKind.Local).AddTicks(5653), 2 },
                    { 4, 72, new DateTime(2023, 5, 24, 14, 24, 20, 5, DateTimeKind.Local).AddTicks(1414), 2 },
                    { 5, 53, new DateTime(2022, 9, 7, 2, 1, 12, 175, DateTimeKind.Local).AddTicks(3401), 2 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 96, new DateTime(2022, 6, 15, 18, 7, 19, 514, DateTimeKind.Local).AddTicks(9182), 1, new DateTime(2023, 6, 7, 13, 46, 31, 843, DateTimeKind.Local).AddTicks(5865), 3 },
                    { 2, 87, new DateTime(2023, 2, 8, 5, 30, 53, 671, DateTimeKind.Local).AddTicks(2961), 3, new DateTime(2024, 5, 8, 20, 0, 43, 9, DateTimeKind.Local).AddTicks(7623), 2 },
                    { 3, 73, new DateTime(2022, 11, 21, 16, 3, 16, 543, DateTimeKind.Local).AddTicks(1527), 1, new DateTime(2023, 11, 28, 18, 51, 24, 842, DateTimeKind.Local).AddTicks(9238), 1 },
                    { 4, 37, new DateTime(2022, 12, 8, 13, 41, 36, 981, DateTimeKind.Local).AddTicks(2789), 3, new DateTime(2023, 10, 25, 11, 29, 30, 261, DateTimeKind.Local).AddTicks(3123), 3 },
                    { 5, 14, new DateTime(2023, 5, 30, 16, 36, 5, 473, DateTimeKind.Local).AddTicks(3461), 5, new DateTime(2024, 5, 8, 6, 0, 13, 933, DateTimeKind.Local).AddTicks(1977), 2 }
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
