using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Alltables : Migration
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
                    { 1, 0, "d9a6e515-4e33-435c-82f1-c6f31774b609", "admin@example.com", true, false, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEFUXpZvyGaqIzAgtdthuX/NI8eBX4m1IPdzLxTVSTdlv+NT80L8Cc/101IFGV7xNzw==", null, false, "69355d52-012e-495e-9796-c47188bf0d94", "4", false, 2, "admin@example.com" },
                    { 2, 0, "1de1cc08-c1ed-472f-a9b9-4f078f65eb01", "librarian@example.com", true, false, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEE3IqHP9Pstduj70ZxIEMeSMziax/VZ4UVpY/d7JKZkACTSRbPLvxM24LdkAxtczAQ==", null, false, "b5bf94b3-b74c-4743-85e4-dc9050c93715", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "26aa5abb-24ac-4ef0-8f7f-03eea8d1aea7", "member@example.com", true, false, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEKQaIS8ET8vz+BZr5FNXHe8t4dSO3sy5dhF+XgcwncojOgs0t4rBQOFaViSpJLeKhw==", null, false, "a71a3ba2-d75f-44ef-8dfd-5c42840649df", "2", false, 0, "member@example.com" },
                    { 4, 0, "04ee63c4-60ad-4ad5-a407-8e16d0aaae90", "Nannie_Brown@gmail.com", true, false, false, false, true, null, 0, "Stephon Marks", "FREDRICK_WOLF22@GMAIL.COM", "SCOTTY38@GMAIL.COM", "AQAAAAEAACcQAAAAEHftPqb5RL/yDvoAS/NfCqef6Jk0+3JuOn15L3XUUgdUSI4kzLT7+7P+kIEuyhTb+Q==", null, false, "e7353ecd-71fd-46e4-89b5-b0a057f74b77", "1", false, 0, "Ludie20@yahoo.com" },
                    { 5, 0, "d42ca94c-0496-46d5-ac28-17a017941f32", "Sean.Effertz@hotmail.com", true, false, false, false, true, null, 0, "Gabe Stiedemann", "DAGMAR_KRIS@GMAIL.COM", "JERMEY.COLLINS@GMAIL.COM", "AQAAAAEAACcQAAAAEIJyaA9F3Igupvj0hnCZ0cxxDiJBYec3sv4cFArRXgxcWFe0/bLMXek4TsAAk25Wug==", null, false, "024615ae-0a70-4a8e-a20e-4a31706c7944", "3", false, 0, "Khalil45@gmail.com" },
                    { 6, 0, "a0123dd3-10e3-47f3-8ab4-2c370799b7cc", "Carlie_Mohr71@yahoo.com", true, false, false, false, true, null, 0, "Camylle Volkman", "DYLAN1@GMAIL.COM", "MAUDIE79@GMAIL.COM", "AQAAAAEAACcQAAAAEAgRb+7NprLjg7P5DY8d+/5cVF+uB10Yznc5daPBRC3/PtxJ1wKwmQekyhP4LGsCGQ==", null, false, "5ee6a12e-7fd5-40f3-83cd-20e0215735eb", "4", false, 0, "Claire75@hotmail.com" },
                    { 7, 0, "3e6a8818-e58a-495e-8a3e-e057a93ebec3", "Lucious.Swaniawski68@hotmail.com", true, false, false, false, true, null, 0, "Talon Murphy", "GARRET66@GMAIL.COM", "CONNER.CRIST@HOTMAIL.COM", "AQAAAAEAACcQAAAAEGwIxaGXHKI37HGxGJah7R5ewOMX7Kv8YeJF7a6iOm3p6YNdLgBxLV86WQ5QOtOKHA==", null, false, "737e500b-eb14-41b6-82e7-28f09b864973", "2", false, 0, "Ricardo58@yahoo.com" },
                    { 8, 0, "6a41f195-50c0-4c3e-8053-23fb4d5b3dd4", "Tristian.Quitzon20@yahoo.com", true, false, false, false, true, null, 0, "Dax Morissette", "NORA77@GMAIL.COM", "ALYSA33@GMAIL.COM", "AQAAAAEAACcQAAAAEE3CKgEzX3Z5P3QqJK1EExAqWtBb57SbIQ3qEE4kTmKHf2tes0rtUCL0hG7jZREDdQ==", null, false, "da8d1a03-b85f-43c5-ac97-ec040b68c47e", "3", false, 0, "Jordyn_OReilly45@hotmail.com" },
                    { 9, 0, "2651cb65-d10f-4d47-af50-f4a569931004", "Dedric_Hermiston34@gmail.com", true, false, false, false, true, null, 0, "Stewart Steuber", "ERNESTINE32@YAHOO.COM", "TYREEK.RUNTE66@GMAIL.COM", "AQAAAAEAACcQAAAAEHXpVCkOYV25O24t67ng8pLqMT/pEpmWMzPGEp1svPJZMRsO0VmlpOeP39FU+im6Fg==", null, false, "9c07da3c-e349-4680-901e-df3c05c29d30", "4", false, 0, "Lincoln37@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Breanna Feest", 1, "Port Eileen", 0, "Fantastic Granite Pizza", 2016 },
                    { 2, "Abdiel Treutel", 0, "Lake Emmalee", 0, "Handcrafted Rubber Pants", 2010 },
                    { 3, "Brendon Hirthe", 1, "Caraside", 0, "Sleek Granite Salad", 2010 },
                    { 4, "Maryjane Torphy", 1, "Hettingerside", 0, "Licensed Wooden Car", 2015 },
                    { 5, "Morgan Anderson", 2, "North Domenicberg", 0, "Fantastic Cotton Shirt", 2002 },
                    { 6, "Jermain Kassulke", 0, "Port Winifredstad", 0, "Rustic Granite Bacon", 2008 },
                    { 7, "Patrick Bradtke", 0, "North Aileen", 0, "Fantastic Metal Shoes", 2007 },
                    { 8, "Rogelio Rodriguez", 2, "Smithshire", 0, "Small Rubber Chicken", 2001 },
                    { 9, "Ozella Cormier", 0, "West Alphonso", 0, "Ergonomic Concrete Hat", 2018 },
                    { 10, "Dortha Hyatt", 2, "New Santinoville", 0, "Tasty Metal Chicken", 2015 },
                    { 11, "Jude Hermiston", 2, "Whiteview", 0, "Tasty Rubber Car", 2014 },
                    { 12, "Christ Schowalter", 0, "Lake Zelda", 0, "Tasty Wooden Car", 2001 },
                    { 13, "Rico Fahey", 0, "New Rae", 0, "Handmade Fresh Gloves", 2012 },
                    { 14, "Ressie Ratke", 0, "New Onie", 0, "Small Cotton Bike", 2003 },
                    { 15, "Samantha O'Reilly", 2, "Swiftton", 0, "Generic Soft Pizza", 2018 },
                    { 16, "Virginie Maggio", 0, "Oranchester", 0, "Unbranded Steel Bacon", 2021 },
                    { 17, "Travis Bauch", 0, "Chancetown", 0, "Unbranded Soft Mouse", 2003 },
                    { 18, "Aracely Williamson", 0, "Prohaskashire", 0, "Ergonomic Plastic Soap", 2022 },
                    { 19, "Troy Mraz", 2, "Fishershire", 0, "Rustic Cotton Soap", 2015 },
                    { 20, "Tyshawn Nienow", 2, "Miltonland", 0, "Incredible Steel Bike", 2020 },
                    { 21, "Cora Moore", 2, "Lake Ferminport", 0, "Ergonomic Cotton Bacon", 2015 },
                    { 22, "Herminia Orn", 3, "Rodriguezton", 0, "Refined Fresh Ball", 2013 },
                    { 23, "Conrad Rice", 3, "Robertfurt", 0, "Generic Metal Mouse", 2000 },
                    { 24, "Thaddeus Lindgren", 1, "Kuhlmanland", 0, "Small Cotton Ball", 2015 },
                    { 25, "Filomena Kessler", 1, "Marcoland", 0, "Fantastic Steel Pizza", 2008 },
                    { 26, "Derek Heaney", 0, "East Agustin", 0, "Licensed Granite Ball", 2015 },
                    { 27, "Cole Davis", 1, "East Mariamborough", 0, "Incredible Fresh Chicken", 2011 },
                    { 28, "Jennie Hamill", 2, "South Everette", 0, "Awesome Fresh Gloves", 2006 },
                    { 29, "Emmy Johnson", 1, "South Edgar", 0, "Ergonomic Concrete Towels", 2016 },
                    { 30, "Harry Kulas", 1, "Toyfurt", 0, "Sleek Plastic Chair", 2005 },
                    { 31, "Jaquelin Stark", 2, "North Lori", 0, "Tasty Wooden Bacon", 2010 },
                    { 32, "Alexandro Grady", 0, "North Brando", 0, "Ergonomic Steel Salad", 2018 },
                    { 33, "Sally Schoen", 0, "Kathrynechester", 0, "Awesome Steel Chair", 2003 },
                    { 34, "Jedidiah Torphy", 3, "Janmouth", 0, "Ergonomic Plastic Hat", 2002 },
                    { 35, "Jalyn Cummings", 3, "South Allenberg", 0, "Small Metal Gloves", 2012 },
                    { 36, "Laurine Stehr", 3, "Aaliyahbury", 0, "Rustic Soft Ball", 2014 },
                    { 37, "Cyril DuBuque", 0, "North Toni", 0, "Practical Steel Bacon", 2002 },
                    { 38, "Brandyn Kessler", 1, "South Loraine", 0, "Licensed Steel Chair", 2020 },
                    { 39, "Jaqueline Stroman", 1, "North Antonina", 0, "Incredible Wooden Mouse", 2004 },
                    { 40, "Joany Beahan", 0, "Willmsbury", 0, "Handmade Wooden Cheese", 2011 },
                    { 41, "Amely Von", 1, "Annaliseton", 0, "Awesome Frozen Keyboard", 2007 },
                    { 42, "Jensen Waelchi", 0, "North Federico", 0, "Practical Granite Bike", 2000 },
                    { 43, "Katelin Bernhard", 3, "Lake Jodyville", 0, "Sleek Metal Pizza", 2023 },
                    { 44, "Johnson Homenick", 1, "Jaydenbury", 0, "Refined Rubber Table", 2002 },
                    { 45, "Maribel Howell", 1, "East Rebekahside", 0, "Awesome Granite Car", 2012 },
                    { 46, "Fern Lesch", 0, "South Freemanmouth", 0, "Small Soft Cheese", 2021 },
                    { 47, "Marianna Gerhold", 1, "Wymanburgh", 0, "Practical Frozen Pizza", 2011 },
                    { 48, "Baron Welch", 2, "Jaynestad", 0, "Handmade Steel Shirt", 2016 },
                    { 49, "Leone Rau", 0, "Ziemeview", 0, "Handcrafted Cotton Shoes", 2022 },
                    { 50, "Mae Bins", 1, "Ernestinabury", 0, "Handcrafted Cotton Mouse", 2011 },
                    { 51, "Alberto Langosh", 1, "Laurafurt", 0, "Incredible Frozen Ball", 2020 },
                    { 52, "Ferne Fadel", 0, "Kaileytown", 0, "Small Granite Soap", 2020 },
                    { 53, "Karianne Pouros", 3, "East Dionmouth", 0, "Gorgeous Rubber Car", 2021 },
                    { 54, "Dana Williamson", 2, "Ebonyland", 0, "Tasty Granite Mouse", 2016 },
                    { 55, "Seth Huels", 3, "North Darientown", 0, "Licensed Wooden Fish", 2003 },
                    { 56, "Rosendo Hegmann", 1, "Walterland", 0, "Tasty Rubber Computer", 2022 },
                    { 57, "Erika Mitchell", 3, "West Earlinefort", 0, "Generic Cotton Tuna", 2022 },
                    { 58, "Marisa Kulas", 1, "Thelmastad", 0, "Sleek Fresh Tuna", 2014 },
                    { 59, "Violette Douglas", 3, "Shermanmouth", 0, "Small Plastic Bike", 2015 },
                    { 60, "Della Kozey", 2, "Howardchester", 0, "Tasty Wooden Computer", 2018 },
                    { 61, "Garland Gleason", 0, "North Harold", 0, "Ergonomic Rubber Gloves", 2007 },
                    { 62, "Yadira Hamill", 0, "South Kathryn", 0, "Refined Wooden Table", 2000 },
                    { 63, "Josianne Gaylord", 0, "New Georgiana", 0, "Gorgeous Cotton Bacon", 2005 },
                    { 64, "Danyka Marvin", 3, "Connellyhaven", 0, "Handmade Plastic Keyboard", 2000 },
                    { 65, "Dangelo Bartoletti", 3, "West Claudineton", 0, "Licensed Metal Sausages", 2023 },
                    { 66, "Olin Schumm", 0, "Skyeport", 0, "Handmade Rubber Hat", 2019 },
                    { 67, "Bernie Fadel", 0, "Lake Kacietown", 0, "Unbranded Plastic Chips", 2008 },
                    { 68, "Karianne Anderson", 3, "Jackieland", 0, "Small Rubber Computer", 2017 },
                    { 69, "Cortez Wolf", 0, "Port Wilberberg", 0, "Sleek Fresh Cheese", 2016 },
                    { 70, "Anika Hermiston", 3, "Coleland", 0, "Incredible Rubber Table", 2012 },
                    { 71, "Sasha Aufderhar", 0, "West Lacey", 0, "Awesome Concrete Towels", 2019 },
                    { 72, "Jamir King", 3, "New Monserrat", 0, "Unbranded Fresh Computer", 2021 },
                    { 73, "Tia Buckridge", 0, "Katrinaville", 0, "Licensed Soft Fish", 2002 },
                    { 74, "Jaida Littel", 0, "South Angelaland", 0, "Small Fresh Shirt", 2003 },
                    { 75, "Mikel Gutkowski", 0, "Elizabethtown", 0, "Sleek Cotton Tuna", 2007 },
                    { 76, "Isaac Cruickshank", 0, "Lebsackstad", 0, "Rustic Granite Cheese", 2004 },
                    { 77, "Cedrick Jast", 2, "Kochshire", 0, "Awesome Wooden Chips", 2012 },
                    { 78, "Jadyn Prohaska", 0, "Bartholomefort", 0, "Small Wooden Soap", 2017 },
                    { 79, "Celestino Tillman", 3, "Tommiemouth", 0, "Tasty Granite Fish", 2017 },
                    { 80, "Misael Hayes", 2, "Windlerport", 0, "Handcrafted Plastic Gloves", 2016 },
                    { 81, "Kamron Rutherford", 0, "North Sylviafort", 0, "Handcrafted Metal Table", 2008 },
                    { 82, "Lera Blick", 2, "New Halfort", 0, "Licensed Cotton Table", 2006 },
                    { 83, "Faustino Steuber", 0, "Lorenafort", 0, "Refined Rubber Ball", 2005 },
                    { 84, "Augustine Marquardt", 3, "Port Zackport", 0, "Refined Steel Mouse", 2002 },
                    { 85, "Charlotte Reinger", 1, "Gulgowskiville", 0, "Ergonomic Granite Car", 2013 },
                    { 86, "Citlalli Dare", 1, "East Rosetta", 0, "Handmade Fresh Bike", 2004 },
                    { 87, "Bailey Zulauf", 1, "Port Duane", 0, "Unbranded Rubber Fish", 2011 },
                    { 88, "Estevan Konopelski", 3, "Trentonville", 0, "Intelligent Wooden Pants", 2023 },
                    { 89, "Tomasa Haag", 1, "Stromanmouth", 0, "Sleek Frozen Chips", 2020 },
                    { 90, "Aliza Oberbrunner", 2, "Feeneymouth", 0, "Rustic Frozen Salad", 2001 },
                    { 91, "Erna Brakus", 0, "Corwinville", 0, "Intelligent Soft Car", 2014 },
                    { 92, "Tina Schumm", 2, "Deronstad", 0, "Rustic Wooden Bike", 2005 },
                    { 93, "Derick Pollich", 2, "West Danikaborough", 0, "Awesome Wooden Keyboard", 2020 },
                    { 94, "Chase Rath", 2, "New Jaydon", 0, "Fantastic Concrete Ball", 2000 },
                    { 95, "Wilburn Fahey", 3, "Lindfort", 0, "Practical Fresh Computer", 2019 },
                    { 96, "Horace Daniel", 0, "Veronahaven", 0, "Unbranded Rubber Tuna", 2005 },
                    { 97, "Donato Mueller", 0, "New Vallieland", 0, "Tasty Rubber Salad", 2020 },
                    { 98, "Dashawn Wunsch", 3, "Lake Matildaton", 0, "Sleek Concrete Car", 2006 },
                    { 99, "Brice Abbott", 1, "Friesenbury", 0, "Ergonomic Rubber Shoes", 2011 },
                    { 100, "Justina Reinger", 3, "Port Bert", 0, "Intelligent Fresh Ball", 2008 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Lake Roderick" },
                    { 2, "Wizaberg" },
                    { 3, "Casperbury" },
                    { 4, "Samanthaview" },
                    { 5, "Fayborough" },
                    { 6, "Reubenfurt" },
                    { 7, "East Clementina" },
                    { 8, "Gottliebborough" },
                    { 9, "Vandervortborough" },
                    { 10, "Vivianefurt" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 19, new DateTime(2023, 3, 9, 21, 34, 7, 693, DateTimeKind.Local).AddTicks(1380), 7 },
                    { 2, 79, new DateTime(2023, 5, 18, 13, 9, 2, 45, DateTimeKind.Local).AddTicks(6482), 8 },
                    { 3, 75, new DateTime(2022, 6, 13, 3, 12, 59, 943, DateTimeKind.Local).AddTicks(7372), 4 },
                    { 4, 20, new DateTime(2022, 7, 6, 2, 45, 50, 615, DateTimeKind.Local).AddTicks(2228), 9 },
                    { 5, 95, new DateTime(2022, 12, 24, 5, 12, 16, 356, DateTimeKind.Local).AddTicks(6743), 4 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 55, new DateTime(2022, 12, 4, 11, 54, 43, 224, DateTimeKind.Local).AddTicks(6542), 1, new DateTime(2024, 1, 21, 4, 52, 47, 606, DateTimeKind.Local).AddTicks(6138), 1 },
                    { 2, 21, new DateTime(2022, 9, 24, 11, 19, 14, 143, DateTimeKind.Local).AddTicks(464), 2, new DateTime(2024, 3, 30, 10, 4, 38, 914, DateTimeKind.Local).AddTicks(3103), 2 },
                    { 3, 40, new DateTime(2022, 7, 6, 18, 15, 43, 766, DateTimeKind.Local).AddTicks(2793), 5, new DateTime(2024, 6, 9, 17, 13, 17, 759, DateTimeKind.Local).AddTicks(4823), 8 },
                    { 4, 30, new DateTime(2022, 7, 29, 15, 38, 9, 142, DateTimeKind.Local).AddTicks(80), 2, new DateTime(2024, 1, 10, 21, 2, 23, 685, DateTimeKind.Local).AddTicks(5769), 8 },
                    { 5, 93, new DateTime(2022, 10, 21, 8, 9, 33, 374, DateTimeKind.Local).AddTicks(6187), 1, new DateTime(2023, 7, 2, 10, 16, 30, 75, DateTimeKind.Local).AddTicks(6034), 5 }
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
