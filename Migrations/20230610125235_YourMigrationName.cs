using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BiebWebApp.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
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
                    { 1, 0, "486ff1fa-3e33-44ea-8155-e555170fdf61", "admin@example.com", true, false, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMLA2nLaDCgtBrPktB+lQtEwzrPpBg579Ow2P/Mxcb5wR6Gz78/FhJ2OpuX4H3jxlg==", null, false, "d35b2475-d904-4282-abba-5f242db7edcb", "4", false, 2, "admin@example.com" },
                    { 2, 0, "107dfe4c-8dc7-4826-a54e-3627e9aece80", "librarian@example.com", true, false, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI1mJDY7R1mDmT1VSXqpdAy1KopLrzoRNROF1fcmRdXATaZM36CGoh0BsrCqf8fI2g==", null, false, "236ae7d5-b3ef-427e-8591-38c829a8357d", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "83106efa-84ee-4076-9e1d-f03228c9e622", "member@example.com", true, false, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEF0MxRCmpPFhKn1IYvHTsvwMgFYq5K/2fmLNYwH9rEPqxoUkcQiJgb/5XJlkyjewBw==", null, false, "7cf5296a-feb7-4bee-a8e6-6d07ac514825", "2", false, 0, "member@example.com" },
                    { 4, 0, "0fcf5948-7d36-4eb1-aedd-fe384d035817", "Breanna89@gmail.com", true, false, false, false, true, null, 0, "Maci Hauck", "NICK_DAUGHERTY@HOTMAIL.COM", "MYLES.GLOVER@YAHOO.COM", "AQAAAAEAACcQAAAAENkHGYfw7CrzCY+cUJvNk3VKBtHjskbaWK0mHNwrNI46A+37A9JYQdNnqXakRrm36g==", null, false, "e9bfa93e-15e2-461c-824e-ac20e401d16a", "1", false, 0, "Alexanne16@gmail.com" },
                    { 5, 0, "85db415b-5132-40ce-a4e7-1fddfdad12ee", "Polly.Bernhard@gmail.com", true, false, false, false, true, null, 0, "Penelope Medhurst", "KADEN15@YAHOO.COM", "MARIANE22@HOTMAIL.COM", "AQAAAAEAACcQAAAAEPxUtyw3bU7LlgSa++R2BFuh18HbpAeSSWubFoWaW0NJ/oinyN8ITujdilY4dq6U6Q==", null, false, "675c73d5-9d69-481f-bc6a-f33922659143", "3", false, 0, "Haylee.Pouros@gmail.com" },
                    { 6, 0, "871fda28-b47c-46b9-ae5f-92e1f9833a58", "Flavie_Cummings70@yahoo.com", true, false, false, false, true, null, 0, "Juliana Mayer", "ALENE.COLE@HOTMAIL.COM", "GIOVANNI.ROGAHN@GMAIL.COM", "AQAAAAEAACcQAAAAEBfUdzZ5f1PL5hAXdIFb/zoGE406nsXODDR2N0ZYzbP4YpmBV7oSJWKbu7rt60/lhQ==", null, false, "06d7d4a6-eeb2-4588-ad7b-350275b6ecc6", "4", false, 0, "Gustave79@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Abigayle Moore", 3, "Kilbackfort", 0, "Small Cotton Fish", 2016 },
                    { 2, "Clay Toy", 2, "Port Aaliyahshire", 0, "Generic Cotton Soap", 2011 },
                    { 3, "Aglae Effertz", 2, "East Jayda", 0, "Ergonomic Rubber Bacon", 2011 },
                    { 4, "Margot Johns", 0, "Keelingburgh", 0, "Intelligent Wooden Shoes", 2006 },
                    { 5, "Alba Rowe", 3, "Harryfort", 0, "Handmade Concrete Chair", 2011 },
                    { 6, "Talon Hackett", 1, "West Katarina", 0, "Unbranded Fresh Ball", 2017 },
                    { 7, "Quinten Stracke", 0, "Ashtonmouth", 0, "Small Granite Hat", 2006 },
                    { 8, "Pearl Corwin", 3, "Evalynport", 0, "Unbranded Plastic Car", 2010 },
                    { 9, "Eldred Heller", 1, "Nicolachester", 0, "Licensed Plastic Mouse", 2023 },
                    { 10, "Dariana Lind", 3, "East Enid", 0, "Unbranded Rubber Bike", 2015 },
                    { 11, "Dorian Jacobi", 3, "Boehmbury", 0, "Tasty Frozen Pants", 2008 },
                    { 12, "Birdie Flatley", 1, "New June", 0, "Incredible Rubber Bacon", 2016 },
                    { 13, "Christiana Hegmann", 3, "New Diamondborough", 0, "Handmade Frozen Chicken", 2010 },
                    { 14, "Irma Becker", 2, "Hoegermouth", 0, "Ergonomic Rubber Pants", 2007 },
                    { 15, "Jalen Stanton", 2, "New Mckenziefort", 0, "Refined Steel Chips", 2020 },
                    { 16, "Llewellyn Dickinson", 2, "Gleasonville", 0, "Generic Granite Table", 2013 },
                    { 17, "Doris Dare", 0, "Abrahamfort", 0, "Tasty Granite Shirt", 2015 },
                    { 18, "Emmitt Stiedemann", 3, "North Maci", 0, "Licensed Rubber Chicken", 2006 },
                    { 19, "Sharon Oberbrunner", 2, "Port Haylie", 0, "Incredible Rubber Fish", 2023 },
                    { 20, "Dakota Mante", 0, "South Marisolside", 0, "Awesome Fresh Bacon", 2018 },
                    { 21, "Anita Reichel", 2, "Port Lucytown", 0, "Gorgeous Cotton Bike", 2022 },
                    { 22, "Garnett Torp", 1, "Nathanaelburgh", 0, "Rustic Plastic Pants", 2017 },
                    { 23, "Lessie Beier", 0, "North Abbey", 0, "Gorgeous Fresh Fish", 2013 },
                    { 24, "Paul Windler", 1, "Ziemefurt", 0, "Small Granite Car", 2015 },
                    { 25, "Tina O'Reilly", 2, "New Katelinchester", 0, "Sleek Wooden Chips", 2020 },
                    { 26, "Harold Moore", 0, "West Deven", 0, "Sleek Wooden Tuna", 2000 },
                    { 27, "Beau Douglas", 1, "Jacintotown", 0, "Awesome Steel Pizza", 2023 },
                    { 28, "Hillary Satterfield", 3, "Ovashire", 0, "Handcrafted Plastic Hat", 2012 },
                    { 29, "Teresa Hoppe", 0, "East Adriel", 0, "Unbranded Granite Ball", 2006 },
                    { 30, "Humberto Kertzmann", 2, "Parisianton", 0, "Awesome Steel Tuna", 2014 },
                    { 31, "Gaston Harris", 1, "Bethelton", 0, "Handmade Rubber Bacon", 2011 },
                    { 32, "Conner Hagenes", 1, "Yundtfort", 0, "Handmade Plastic Salad", 2015 },
                    { 33, "Flossie Carter", 0, "Sethfort", 0, "Refined Rubber Soap", 2007 },
                    { 34, "Cathy Bashirian", 1, "Kennedishire", 0, "Intelligent Metal Bacon", 2001 },
                    { 35, "Glennie Schumm", 2, "Bergeville", 0, "Fantastic Metal Pants", 2019 },
                    { 36, "Wilton Spinka", 0, "New Cordelia", 0, "Practical Metal Shirt", 2019 },
                    { 37, "Lily Erdman", 0, "Port Lydia", 0, "Sleek Fresh Keyboard", 2012 },
                    { 38, "Maybell Wolf", 2, "Prosaccoborough", 0, "Intelligent Wooden Car", 2005 },
                    { 39, "Gonzalo Cronin", 2, "Dedricburgh", 0, "Incredible Steel Soap", 2023 },
                    { 40, "Rosie Breitenberg", 3, "Shyannview", 0, "Tasty Soft Chicken", 2020 },
                    { 41, "Alice Kirlin", 3, "Gleichnerville", 0, "Rustic Granite Chicken", 2002 },
                    { 42, "Shyann Monahan", 2, "New Berthafurt", 0, "Unbranded Concrete Salad", 2007 },
                    { 43, "Jayden Leffler", 0, "Lake Garth", 0, "Intelligent Plastic Shirt", 2014 },
                    { 44, "Karen Cormier", 0, "New Greysonstad", 0, "Awesome Wooden Cheese", 2014 },
                    { 45, "Mason Hayes", 0, "East Jakayla", 0, "Handcrafted Cotton Ball", 2000 },
                    { 46, "Barbara VonRueden", 1, "Macview", 0, "Unbranded Concrete Ball", 2006 },
                    { 47, "Maci Kertzmann", 2, "New Ewaldmouth", 0, "Generic Soft Soap", 2012 },
                    { 48, "Nia Romaguera", 3, "East Reinhold", 0, "Licensed Rubber Mouse", 2002 },
                    { 49, "Elisha Rolfson", 0, "West Daron", 0, "Unbranded Concrete Car", 2002 },
                    { 50, "Taurean Konopelski", 2, "Kiehnview", 0, "Gorgeous Soft Salad", 2016 },
                    { 51, "Amely Hills", 1, "North Kennith", 0, "Incredible Soft Fish", 2011 },
                    { 52, "Akeem Wolf", 0, "Kobyshire", 0, "Ergonomic Cotton Cheese", 2015 },
                    { 53, "Akeem Collier", 0, "East Jermainstad", 0, "Unbranded Concrete Gloves", 2017 },
                    { 54, "Mabel Keebler", 2, "Jakubowskitown", 0, "Generic Soft Towels", 2021 },
                    { 55, "Andre Homenick", 2, "Wisozktown", 0, "Fantastic Concrete Keyboard", 2017 },
                    { 56, "Adolfo Welch", 0, "Jenningsmouth", 0, "Handmade Steel Sausages", 2022 },
                    { 57, "Aditya Orn", 3, "Alecstad", 0, "Generic Fresh Salad", 2007 },
                    { 58, "Reid Hansen", 3, "Douglastown", 0, "Refined Cotton Table", 2008 },
                    { 59, "Rhianna Gislason", 3, "East Lura", 0, "Fantastic Soft Car", 2002 },
                    { 60, "Brad Gislason", 3, "Predovicburgh", 0, "Awesome Frozen Towels", 2017 },
                    { 61, "Wiley Stark", 2, "Malachistad", 0, "Unbranded Steel Hat", 2022 },
                    { 62, "Richard Larson", 1, "East Gregoryview", 0, "Awesome Cotton Table", 2023 },
                    { 63, "Eleanore Mitchell", 0, "North Gabe", 0, "Small Wooden Fish", 2008 },
                    { 64, "Anna Torphy", 0, "Ziemeland", 0, "Intelligent Frozen Computer", 2002 },
                    { 65, "Damien Bahringer", 1, "Runolfssonborough", 0, "Small Fresh Sausages", 2000 },
                    { 66, "Rebeka Roberts", 3, "West Mauricioberg", 0, "Fantastic Cotton Fish", 2005 },
                    { 67, "Corine Fisher", 1, "West Victoria", 0, "Licensed Plastic Computer", 2022 },
                    { 68, "Raphaelle Schimmel", 2, "Holliehaven", 0, "Handcrafted Concrete Computer", 2004 },
                    { 69, "Rebeca Tremblay", 2, "Deloresside", 0, "Sleek Rubber Hat", 2013 },
                    { 70, "Barney Walter", 2, "West Aurelio", 0, "Fantastic Frozen Sausages", 2000 },
                    { 71, "Mose Breitenberg", 3, "Port Sage", 0, "Tasty Plastic Soap", 2012 },
                    { 72, "Gabe Haag", 2, "Karistad", 0, "Intelligent Steel Ball", 2021 },
                    { 73, "Burley Ziemann", 0, "East Granville", 0, "Ergonomic Plastic Towels", 2009 },
                    { 74, "Buck Larkin", 1, "Gradyfort", 0, "Refined Metal Pizza", 2015 },
                    { 75, "Unique Schimmel", 0, "Anabelchester", 0, "Incredible Plastic Ball", 2013 },
                    { 76, "Ladarius Aufderhar", 3, "North Jordibury", 0, "Incredible Cotton Shirt", 2011 },
                    { 77, "Lonie Considine", 3, "Daughertyton", 0, "Generic Rubber Pizza", 2004 },
                    { 78, "Kassandra Ortiz", 0, "Leonardville", 0, "Fantastic Cotton Bike", 2008 },
                    { 79, "Keagan Bednar", 0, "Shanonbury", 0, "Unbranded Concrete Mouse", 2000 },
                    { 80, "Lorenza Prosacco", 2, "Lake Carolyne", 0, "Handcrafted Cotton Chair", 2013 },
                    { 81, "Ellsworth Bruen", 1, "Edwinaton", 0, "Sleek Metal Chips", 2022 },
                    { 82, "Cleo Langosh", 3, "Port Trevionburgh", 0, "Licensed Fresh Cheese", 2014 },
                    { 83, "Dustin Leffler", 0, "Cedrickmouth", 0, "Gorgeous Fresh Hat", 2018 },
                    { 84, "Eryn Herman", 1, "West Julie", 0, "Handmade Cotton Soap", 2011 },
                    { 85, "Newton Jerde", 2, "West Israel", 0, "Small Soft Pizza", 2002 },
                    { 86, "Darrick McClure", 0, "New Gloria", 0, "Gorgeous Granite Pants", 2023 },
                    { 87, "Doyle Dach", 3, "West Gaylord", 0, "Practical Rubber Pants", 2005 },
                    { 88, "Elenor Pfannerstill", 0, "Sydneyside", 0, "Intelligent Frozen Towels", 2006 },
                    { 89, "Makenzie Maggio", 1, "Homenickfort", 0, "Gorgeous Steel Sausages", 2017 },
                    { 90, "Davon Monahan", 1, "North Lessie", 0, "Awesome Granite Shirt", 2009 },
                    { 91, "Kailey Jaskolski", 2, "New Brookfort", 0, "Intelligent Plastic Soap", 2005 },
                    { 92, "Dameon Wisozk", 0, "East Vito", 0, "Ergonomic Cotton Soap", 2014 },
                    { 93, "Gloria Kerluke", 3, "Schroederport", 0, "Fantastic Plastic Table", 2020 },
                    { 94, "Bailey Mann", 1, "New Duncanstad", 0, "Tasty Concrete Computer", 2003 },
                    { 95, "Cleta Bins", 1, "Wehnerfort", 0, "Small Rubber Bacon", 2010 },
                    { 96, "Elisa Lind", 0, "Araceliview", 0, "Gorgeous Wooden Car", 2017 },
                    { 97, "Annabel Moore", 0, "Macejkovicchester", 0, "Handcrafted Steel Chair", 2017 },
                    { 98, "Jade Pfannerstill", 3, "Muellershire", 0, "Practical Rubber Chips", 2014 },
                    { 99, "Earline Buckridge", 1, "Goldaberg", 0, "Gorgeous Plastic Towels", 2022 },
                    { 100, "Trey Swift", 2, "South Evan", 0, "Sleek Soft Towels", 2005 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "East Samanthaberg" },
                    { 2, "Stehrport" },
                    { 3, "Wiltonport" },
                    { 4, "West Kendra" },
                    { 5, "Nikostad" },
                    { 6, "Freemanhaven" },
                    { 7, "West Charles" },
                    { 8, "North Murphy" },
                    { 9, "Parisborough" },
                    { 10, "Aronfort" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 79, new DateTime(2022, 7, 16, 6, 20, 19, 46, DateTimeKind.Local).AddTicks(5182), 3 },
                    { 2, 95, new DateTime(2022, 7, 11, 4, 57, 31, 224, DateTimeKind.Local).AddTicks(8223), 1 },
                    { 3, 92, new DateTime(2022, 10, 3, 13, 28, 54, 594, DateTimeKind.Local).AddTicks(9831), 3 },
                    { 4, 11, new DateTime(2023, 3, 29, 23, 34, 4, 688, DateTimeKind.Local).AddTicks(3174), 3 },
                    { 5, 94, new DateTime(2023, 4, 27, 9, 16, 59, 765, DateTimeKind.Local).AddTicks(7929), 3 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 90, new DateTime(2022, 8, 14, 4, 56, 35, 467, DateTimeKind.Local).AddTicks(8336), 3, new DateTime(2024, 2, 7, 15, 11, 19, 461, DateTimeKind.Local).AddTicks(5621), 2 },
                    { 2, 75, new DateTime(2022, 11, 22, 10, 16, 29, 148, DateTimeKind.Local).AddTicks(5492), 1, new DateTime(2023, 9, 13, 19, 19, 53, 870, DateTimeKind.Local).AddTicks(4378), 2 },
                    { 3, 57, new DateTime(2022, 7, 13, 23, 54, 36, 649, DateTimeKind.Local).AddTicks(7332), 3, new DateTime(2023, 6, 13, 9, 15, 5, 982, DateTimeKind.Local).AddTicks(7668), 2 },
                    { 4, 20, new DateTime(2022, 8, 31, 0, 46, 3, 7, DateTimeKind.Local).AddTicks(7831), 5, new DateTime(2023, 7, 9, 2, 19, 30, 450, DateTimeKind.Local).AddTicks(9159), 3 },
                    { 5, 5, new DateTime(2023, 2, 11, 18, 16, 41, 154, DateTimeKind.Local).AddTicks(1975), 2, new DateTime(2023, 12, 23, 6, 55, 55, 54, DateTimeKind.Local).AddTicks(9289), 1 }
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
