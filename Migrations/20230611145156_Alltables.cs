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
                    { 1, 0, "0f79eed1-a813-49ad-ad03-83ebfe19ea74", "admin@example.com", true, false, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEObfd9dSL9phSQu9nkaRTR2N2tclh4DjHJeRzfd099RbbhIQTQhhkibVfpp9c58HMA==", null, false, "7077da15-7492-473a-b961-cdeb8238d5d5", "4", false, 2, "admin@example.com" },
                    { 2, 0, "b4a519fb-6a1b-472b-82ab-ad3e87822584", "librarian@example.com", true, false, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAsvlS7R/qqCaV0agMz8tr0gMlvAbBLY8ITfiDAgXNI/KxW37p+b146VMnf5PK1G9w==", null, false, "e196c0f3-bbf0-42cc-afae-0b043c9f5483", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "85ac6048-d05e-4ed8-99e6-808f91414050", "member@example.com", true, false, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEDU8p+v5pbJK+WpPR4MUJboWx1Lb/FPWiz5gyXKkzsNfAZv87vxfMQVkftcYvsNCw==", null, false, "1141eb64-3be6-4384-9dcd-2cb2b6f52b44", "2", false, 0, "member@example.com" },
                    { 4, 0, "7306a2b2-54ac-45c4-be75-b810ec12c839", "Reed_Haag@gmail.com", true, false, false, false, true, null, 0, "Khalid Haag", "ROSEMARY.TREUTEL@HOTMAIL.COM", "NAKIA2@GMAIL.COM", "AQAAAAEAACcQAAAAEADFpV4HOoi6amedRdoP2GrrjWAcLqwG798eksknYCS9RjxhEk4EpKNaz9NZ+c1yjg==", null, false, "b9894f90-7297-4b9c-a55a-1f28cf182350", "1", false, 0, "Brennan_Jenkins33@hotmail.com" },
                    { 5, 0, "5ae08ef5-8d8c-4325-a491-6cb90dc33965", "Mabelle.Wolf65@hotmail.com", true, false, false, false, true, null, 0, "Marcos Bartoletti", "LEILA_CARROLL@GMAIL.COM", "VIRGINIA.KING@YAHOO.COM", "AQAAAAEAACcQAAAAEN1XiPKRBFgs/q2dFtNq/ECRZTplchqS+0nUrOm9iQ44VuMe8S0AagXmlTlrPEvh7Q==", null, false, "84c1a6fc-9898-4374-b8d4-b666cf16069a", "3", false, 0, "Tony.Boehm@gmail.com" },
                    { 6, 0, "be44e84d-1c52-42aa-a586-16b2bee828d3", "Marietta_Boehm@yahoo.com", true, false, false, false, true, null, 0, "Jaclyn Schoen", "CHRISTOP.KING@GMAIL.COM", "LUELLA_COLLIER@YAHOO.COM", "AQAAAAEAACcQAAAAENUdHlt87VoWaxcgFAihqUCYfW51ZtFzScQFcowJ3sPgvukXccl7TvA1bUVJ71HN/w==", null, false, "4a40cb92-87a4-4672-b26d-f1a39d85032c", "4", false, 0, "Jackie_Moen31@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Rylan Bergstrom", 3, "Gislasonberg", 0, "Licensed Metal Pizza", 2023 },
                    { 2, "Keyon Lebsack", 0, "South Alberttown", 0, "Ergonomic Concrete Table", 2022 },
                    { 3, "Lea Lehner", 1, "Lake Laverneville", 0, "Intelligent Plastic Chair", 2003 },
                    { 4, "Jayce Flatley", 2, "Schimmelview", 0, "Practical Cotton Keyboard", 2017 },
                    { 5, "Luz Herman", 1, "Strosinmouth", 0, "Incredible Granite Bacon", 2011 },
                    { 6, "Stephanie Abernathy", 0, "Aglaeberg", 0, "Practical Cotton Chips", 2016 },
                    { 7, "Ford Stiedemann", 1, "East Antoniabury", 0, "Fantastic Steel Hat", 2008 },
                    { 8, "Charity Bogan", 2, "Mosciskimouth", 0, "Small Soft Car", 2019 },
                    { 9, "Elody Glover", 1, "Bradyfurt", 0, "Generic Frozen Soap", 2023 },
                    { 10, "Brent Fay", 2, "South Lacy", 0, "Intelligent Granite Bike", 2001 },
                    { 11, "Arch Lockman", 2, "New Janis", 0, "Licensed Granite Salad", 2023 },
                    { 12, "Phoebe Hoeger", 2, "East Estefaniatown", 0, "Awesome Wooden Bacon", 2010 },
                    { 13, "Guiseppe Cruickshank", 0, "Bergnaumburgh", 0, "Awesome Rubber Hat", 2015 },
                    { 14, "Brayan Halvorson", 2, "Johnsonfurt", 0, "Handcrafted Metal Salad", 2015 },
                    { 15, "Madilyn Shanahan", 2, "Donnellychester", 0, "Incredible Plastic Chicken", 2011 },
                    { 16, "Jimmie Emard", 1, "North Lexiechester", 0, "Fantastic Plastic Salad", 2000 },
                    { 17, "Merl Runolfsson", 0, "Bechtelarfort", 0, "Practical Wooden Mouse", 2006 },
                    { 18, "Archibald Kutch", 2, "Veronaton", 0, "Handmade Soft Soap", 2016 },
                    { 19, "Domenica Leannon", 2, "Leonorland", 0, "Refined Metal Shirt", 2000 },
                    { 20, "Mathilde Hegmann", 2, "New Kaylie", 0, "Handmade Fresh Mouse", 2019 },
                    { 21, "Augustine Schaefer", 1, "Lake Fredy", 0, "Incredible Concrete Bike", 2022 },
                    { 22, "Nathaniel Botsford", 0, "Lake Domingochester", 0, "Fantastic Cotton Pants", 2015 },
                    { 23, "Audreanne Lynch", 0, "Americoborough", 0, "Handcrafted Granite Mouse", 2010 },
                    { 24, "Oma Graham", 0, "Nikolausmouth", 0, "Gorgeous Steel Chicken", 2016 },
                    { 25, "Caitlyn Kautzer", 0, "New Felicity", 0, "Tasty Wooden Ball", 2004 },
                    { 26, "Kaylee O'Keefe", 3, "Felipeside", 0, "Fantastic Steel Gloves", 2007 },
                    { 27, "Erna Hartmann", 0, "Lake Alenetown", 0, "Licensed Soft Salad", 2008 },
                    { 28, "Don Lueilwitz", 2, "Fabiolatown", 0, "Fantastic Rubber Mouse", 2017 },
                    { 29, "Naomie Gottlieb", 1, "Joaquintown", 0, "Practical Soft Salad", 2005 },
                    { 30, "Juana Herzog", 1, "Greenland", 0, "Practical Steel Pants", 2005 },
                    { 31, "Benjamin Goodwin", 1, "Kertzmannside", 0, "Sleek Steel Pizza", 2020 },
                    { 32, "Alessandro Goodwin", 3, "Kaliburgh", 0, "Unbranded Metal Pizza", 2000 },
                    { 33, "Ross Leffler", 0, "Larissaborough", 0, "Small Cotton Cheese", 2017 },
                    { 34, "Eleanore McLaughlin", 1, "Rogahnstad", 0, "Gorgeous Steel Table", 2011 },
                    { 35, "Mark Herzog", 3, "Davionville", 0, "Intelligent Concrete Gloves", 2006 },
                    { 36, "Jayda Jacobs", 3, "Janiemouth", 0, "Generic Concrete Chicken", 2000 },
                    { 37, "Bradly Renner", 0, "Abeland", 0, "Unbranded Granite Chicken", 2016 },
                    { 38, "Helen Brakus", 0, "Russelchester", 0, "Incredible Plastic Shoes", 2000 },
                    { 39, "Madonna Lemke", 2, "Klockoborough", 0, "Refined Rubber Tuna", 2003 },
                    { 40, "Tara Upton", 2, "New Kearaville", 0, "Refined Cotton Soap", 2001 },
                    { 41, "Leonard Stamm", 2, "Parkerbury", 0, "Ergonomic Soft Bike", 2019 },
                    { 42, "Ross Reinger", 0, "Heidenreichfurt", 0, "Gorgeous Wooden Shoes", 2010 },
                    { 43, "Pamela Jakubowski", 2, "Port Maci", 0, "Incredible Fresh Pizza", 2005 },
                    { 44, "Kianna Schuster", 2, "East Cassiefort", 0, "Refined Plastic Tuna", 2006 },
                    { 45, "Casimer Leuschke", 2, "Konopelskimouth", 0, "Unbranded Wooden Chair", 2019 },
                    { 46, "Keith Streich", 1, "Wildermanfurt", 0, "Intelligent Fresh Pants", 2011 },
                    { 47, "Ruthe Bode", 3, "Emardborough", 0, "Small Granite Pizza", 2012 },
                    { 48, "Monty Bradtke", 0, "Aristad", 0, "Incredible Fresh Salad", 2007 },
                    { 49, "Richmond Price", 3, "Nicolasberg", 0, "Generic Metal Pants", 2019 },
                    { 50, "Wade Wilderman", 3, "Dudleymouth", 0, "Generic Wooden Table", 2013 },
                    { 51, "Tressie Kuphal", 2, "West Autumn", 0, "Sleek Wooden Keyboard", 2014 },
                    { 52, "Lamar Douglas", 0, "North Carroll", 0, "Practical Rubber Sausages", 2000 },
                    { 53, "Roderick Yost", 1, "Meaghanfurt", 0, "Awesome Frozen Shoes", 2008 },
                    { 54, "Ramona Gislason", 0, "East Kacistad", 0, "Licensed Plastic Soap", 2022 },
                    { 55, "Darion Swaniawski", 3, "Jenningsland", 0, "Ergonomic Wooden Keyboard", 2005 },
                    { 56, "Mathias Considine", 0, "North Ruby", 0, "Incredible Plastic Shoes", 2020 },
                    { 57, "Libbie Predovic", 2, "New Christellebury", 0, "Unbranded Metal Car", 2023 },
                    { 58, "Isobel Pagac", 0, "South Darbymouth", 0, "Unbranded Metal Chicken", 2005 },
                    { 59, "Margie Gislason", 3, "West Rahulport", 0, "Refined Cotton Pizza", 2023 },
                    { 60, "Janick Pfeffer", 0, "East Elroy", 0, "Gorgeous Concrete Gloves", 2000 },
                    { 61, "Nannie Lebsack", 0, "Crooksmouth", 0, "Tasty Cotton Pants", 2016 },
                    { 62, "Evan Green", 1, "Stehrland", 0, "Ergonomic Soft Towels", 2022 },
                    { 63, "Herminio Reynolds", 0, "West Caesarfort", 0, "Unbranded Concrete Chair", 2004 },
                    { 64, "Naomi Zulauf", 2, "West Kaci", 0, "Small Metal Gloves", 2008 },
                    { 65, "Shayna Schoen", 1, "South Lavernmouth", 0, "Tasty Concrete Chicken", 2016 },
                    { 66, "Emmanuelle Boyle", 0, "Kuvalismouth", 0, "Fantastic Cotton Bacon", 2012 },
                    { 67, "Tyrique Volkman", 1, "South Shad", 0, "Small Concrete Cheese", 2004 },
                    { 68, "Brant Keeling", 2, "South Marisaville", 0, "Awesome Granite Soap", 2007 },
                    { 69, "Stephen Bergnaum", 2, "West Tamara", 0, "Practical Rubber Computer", 2005 },
                    { 70, "Julien Kihn", 3, "Bryonton", 0, "Practical Wooden Bike", 2001 },
                    { 71, "Chandler Sporer", 2, "East Karine", 0, "Handcrafted Metal Chicken", 2001 },
                    { 72, "Dale Barrows", 1, "Eugeniaborough", 0, "Awesome Wooden Chicken", 2011 },
                    { 73, "Marianna Roob", 2, "Handburgh", 0, "Practical Metal Chicken", 2012 },
                    { 74, "Rico Beer", 3, "Lake Malika", 0, "Practical Rubber Bacon", 2007 },
                    { 75, "Alize O'Kon", 2, "Russelmouth", 0, "Handmade Fresh Table", 2015 },
                    { 76, "Madelyn Hickle", 0, "Coleton", 0, "Generic Soft Chair", 2014 },
                    { 77, "Godfrey Mayer", 1, "Mertzchester", 0, "Small Frozen Sausages", 2015 },
                    { 78, "Otilia Quigley", 1, "New Maya", 0, "Tasty Plastic Fish", 2008 },
                    { 79, "Verlie Jacobi", 2, "Kameronfort", 0, "Fantastic Concrete Chicken", 2004 },
                    { 80, "Louie Hintz", 1, "Schaeferhaven", 0, "Incredible Soft Hat", 2015 },
                    { 81, "Kole Volkman", 1, "East Ettie", 0, "Gorgeous Concrete Gloves", 2006 },
                    { 82, "Bettie Cremin", 1, "North Maximuston", 0, "Practical Concrete Keyboard", 2016 },
                    { 83, "Christophe Gutmann", 1, "Abernathyberg", 0, "Sleek Cotton Car", 2009 },
                    { 84, "Darby Casper", 0, "Lake Prudence", 0, "Practical Granite Chair", 2008 },
                    { 85, "Otilia Feest", 1, "Kulasbury", 0, "Rustic Steel Soap", 2009 },
                    { 86, "Elda Morissette", 0, "Kassandraside", 0, "Generic Cotton Tuna", 2003 },
                    { 87, "Curtis Wyman", 2, "Raymondmouth", 0, "Fantastic Cotton Salad", 2002 },
                    { 88, "Maudie Morissette", 1, "Lake Brandy", 0, "Sleek Granite Chicken", 2016 },
                    { 89, "Haylee Berge", 3, "Brennafurt", 0, "Handmade Cotton Towels", 2008 },
                    { 90, "Gloria Smith", 3, "Jedediahfort", 0, "Ergonomic Fresh Bike", 2022 },
                    { 91, "Joy Fahey", 3, "North Rhea", 0, "Unbranded Frozen Computer", 2020 },
                    { 92, "Naomie Conroy", 3, "North Jaeden", 0, "Unbranded Plastic Sausages", 2017 },
                    { 93, "Maximo Kutch", 0, "East Raheemton", 0, "Awesome Rubber Keyboard", 2001 },
                    { 94, "Howard Collins", 1, "Londonville", 0, "Incredible Cotton Fish", 2008 },
                    { 95, "London Greenholt", 2, "Aidanview", 0, "Practical Steel Towels", 2003 },
                    { 96, "Tom Haag", 1, "Joyville", 0, "Incredible Wooden Salad", 2006 },
                    { 97, "Kale Paucek", 3, "East Piper", 0, "Ergonomic Metal Shirt", 2017 },
                    { 98, "Marty MacGyver", 1, "Abelshire", 0, "Ergonomic Soft Ball", 2001 },
                    { 99, "Frederik Hodkiewicz", 3, "East Ginastad", 0, "Incredible Cotton Car", 2007 },
                    { 100, "Chet Nolan", 3, "Legrosfurt", 0, "Tasty Metal Soap", 2008 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "New Joel" },
                    { 2, "Lake Erickachester" },
                    { 3, "West Aliciafort" },
                    { 4, "Rodrigohaven" },
                    { 5, "Chanelmouth" },
                    { 6, "Huelsville" },
                    { 7, "Ortizberg" },
                    { 8, "West Gust" },
                    { 9, "South Fernandostad" },
                    { 10, "Omerburgh" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 54, new DateTime(2022, 10, 25, 11, 26, 48, 162, DateTimeKind.Local).AddTicks(5382), 3 },
                    { 2, 94, new DateTime(2023, 2, 8, 17, 39, 40, 148, DateTimeKind.Local).AddTicks(4876), 3 },
                    { 3, 35, new DateTime(2022, 10, 21, 13, 41, 10, 122, DateTimeKind.Local).AddTicks(4618), 1 },
                    { 4, 91, new DateTime(2022, 10, 16, 16, 28, 39, 29, DateTimeKind.Local).AddTicks(4539), 2 },
                    { 5, 75, new DateTime(2022, 10, 2, 7, 40, 17, 393, DateTimeKind.Local).AddTicks(1649), 2 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 81, new DateTime(2022, 12, 11, 21, 19, 36, 472, DateTimeKind.Local).AddTicks(4822), 1, new DateTime(2023, 10, 29, 17, 19, 16, 176, DateTimeKind.Local).AddTicks(4639), 1 },
                    { 2, 47, new DateTime(2022, 12, 12, 17, 23, 36, 107, DateTimeKind.Local).AddTicks(8373), 2, new DateTime(2023, 11, 13, 5, 32, 39, 270, DateTimeKind.Local).AddTicks(855), 2 },
                    { 3, 62, new DateTime(2022, 9, 2, 3, 38, 2, 87, DateTimeKind.Local).AddTicks(3180), 3, new DateTime(2024, 4, 25, 15, 24, 43, 146, DateTimeKind.Local).AddTicks(3582), 2 },
                    { 4, 87, new DateTime(2023, 1, 11, 22, 27, 9, 620, DateTimeKind.Local).AddTicks(8087), 5, new DateTime(2024, 3, 18, 8, 12, 8, 287, DateTimeKind.Local).AddTicks(5148), 3 },
                    { 5, 69, new DateTime(2023, 2, 12, 1, 29, 51, 780, DateTimeKind.Local).AddTicks(6533), 3, new DateTime(2024, 5, 5, 22, 6, 20, 43, DateTimeKind.Local).AddTicks(1864), 1 }
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
