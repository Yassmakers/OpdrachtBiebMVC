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
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_UserId",
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
                    { 1, 0, "cee4b8bb-68e0-4c7e-a1bd-78fce199d780", "admin@example.com", true, false, false, true, null, 0, "Administrator", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGm82CMHMO+6+Sv0OqCo4D7QvhqUSVgcdjPmQecalfdmyLxyNt2mWIjQ/iE4jiV6Fg==", null, false, "d590ee4d-ee56-4e0a-b22f-f07fbdf69523", "4", false, 2, "admin@example.com" },
                    { 2, 0, "006272ea-2d3f-403d-8677-173e6022e314", "librarian@example.com", true, false, false, true, null, 0, "Librarian", "LIBRARIAN@EXAMPLE.COM", "LIBRARIAN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBiNB2wcetoWKvVytkF3dl1FXln6i9xd/qtIN4eFe3u7XIU4nZw4AXyid0BLtAWfCw==", null, false, "61e2f9e3-85fe-4aa3-99a6-20cad0eae310", "3", false, 1, "librarian@example.com" },
                    { 3, 0, "b40f9c8f-3bce-4bfc-9572-61343d626bed", "member@example.com", true, false, false, true, null, 0, "Member", "MEMBER@EXAMPLE.COM", "MEMBER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGoVkaaeYhRofKHXw3jViTqpjRo3DLBWp5BisP6oKyZ288HO/tB7T/kY++cf/l3x6A==", null, false, "e0fedec2-33ef-402a-b765-7aa08d3e5510", "2", false, 0, "member@example.com" },
                    { 4, 0, "0c566db5-2951-4a0d-ae17-35255b2c9429", "June89@hotmail.com", true, false, false, true, null, 0, "Loma Rippin", "MUSTAFA96@HOTMAIL.COM", "GREGG.HEANEY@GMAIL.COM", "AQAAAAEAACcQAAAAEDSqk6WgewFYkKRtfOwsBy4YBu0E1N0qZQRB0ti1nUWacF7P3eKK+Ay6AUACMjPSAw==", null, false, "3a2fe1fc-d803-47be-8f7f-c26e4afbe5e3", "1", false, 0, "Elmore.Cronin@hotmail.com" },
                    { 5, 0, "12bab587-5f34-4296-a504-3d390df3c3fe", "Soledad_Mayer6@gmail.com", true, false, false, true, null, 0, "Willis Kuphal", "THERESIA24@YAHOO.COM", "LEATHA.HUDSON73@YAHOO.COM", "AQAAAAEAACcQAAAAEIBkXD7yeWTLxB67ohb5PHFKiO5fgC5PqwsCWpHc8TeoxK2esiRCzsAky9h63Dntvw==", null, false, "3ae2e3da-072c-49b4-aa35-a518065e14e7", "3", false, 0, "Chance.Haag@gmail.com" },
                    { 6, 0, "2c0eb5e0-ddc0-4727-8305-88c48c97f4a9", "Annette.Purdy61@yahoo.com", true, false, false, true, null, 0, "Jaunita Thiel", "KRISTOFFER_DAMORE@YAHOO.COM", "MOZELLE.KOCH@GMAIL.COM", "AQAAAAEAACcQAAAAEF0io6o0Yhk002g2QEyc25b2xhQ0pO4q+H+GZFZSPDOcs3V5uC8rtYVgNM4prTENPw==", null, false, "2c5f4a5e-1e26-4825-9bdd-b7ba32a3e17f", "4", false, 0, "Gertrude_Keeling@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Author", "ItemType", "Location", "Status", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Darren Morar", 2, "Gwendolynland", 0, "Handcrafted Plastic Ball", 2022 },
                    { 2, "Malika Barrows", 3, "Carmellaville", 0, "Sleek Plastic Chair", 2018 },
                    { 3, "Tania Daniel", 1, "Lake Eulafurt", 0, "Small Rubber Salad", 2018 },
                    { 4, "Mario Rolfson", 3, "West Edythshire", 0, "Practical Wooden Ball", 2003 },
                    { 5, "Tatyana Gottlieb", 3, "Richieville", 0, "Unbranded Fresh Pizza", 2018 },
                    { 6, "Urban Price", 1, "North Dion", 0, "Ergonomic Rubber Pizza", 2023 },
                    { 7, "Alphonso Robel", 1, "Bauchton", 0, "Refined Granite Pizza", 2000 },
                    { 8, "Santino Raynor", 1, "Bauchland", 0, "Sleek Granite Cheese", 2013 },
                    { 9, "Hailie Herman", 1, "Bayerport", 0, "Handcrafted Granite Towels", 2006 },
                    { 10, "Kendra Volkman", 1, "Lake Velmaland", 0, "Intelligent Granite Towels", 2012 },
                    { 11, "Bell Goodwin", 3, "North Dawsonchester", 0, "Refined Cotton Bike", 2023 },
                    { 12, "Paris Bailey", 0, "East Jessy", 0, "Incredible Rubber Fish", 2023 },
                    { 13, "Miles Satterfield", 1, "Ramonton", 0, "Awesome Granite Shirt", 2017 },
                    { 14, "Milton Crist", 2, "North Connor", 0, "Refined Plastic Table", 2005 },
                    { 15, "Dalton Pagac", 0, "Hartmannland", 0, "Refined Steel Chicken", 2017 },
                    { 16, "Kara Cummerata", 1, "Gibsonmouth", 0, "Intelligent Wooden Ball", 2021 },
                    { 17, "Jaydon Erdman", 2, "Sadyeberg", 0, "Licensed Cotton Table", 2009 },
                    { 18, "Chelsie Wolf", 3, "Ednachester", 0, "Handcrafted Wooden Pants", 2012 },
                    { 19, "Bessie Koelpin", 0, "Adamsville", 0, "Ergonomic Plastic Table", 2009 },
                    { 20, "Addison Douglas", 1, "South Gordon", 0, "Handcrafted Plastic Keyboard", 2007 },
                    { 21, "Keara Dibbert", 1, "New Macie", 0, "Incredible Plastic Pizza", 2021 },
                    { 22, "Ernest Jones", 2, "West Kadeview", 0, "Generic Granite Chicken", 2001 },
                    { 23, "Eddie Streich", 3, "East Mario", 0, "Tasty Wooden Gloves", 2020 },
                    { 24, "Dillon Brekke", 0, "Pagacburgh", 0, "Tasty Cotton Chips", 2020 },
                    { 25, "Rodger Tillman", 0, "New Clemens", 0, "Licensed Granite Soap", 2005 },
                    { 26, "Chester Lebsack", 2, "Prosaccoview", 0, "Handcrafted Soft Fish", 2006 },
                    { 27, "Chris Marvin", 0, "Lake Darianview", 0, "Tasty Plastic Fish", 2008 },
                    { 28, "Kristian Mohr", 1, "Port Abdullah", 0, "Handmade Metal Gloves", 2016 },
                    { 29, "Ruthie Yundt", 0, "Fisherbury", 0, "Ergonomic Steel Table", 2002 },
                    { 30, "Alessandra Schulist", 1, "New Jadonside", 0, "Tasty Soft Fish", 2017 },
                    { 31, "Trevion Batz", 1, "South Narciso", 0, "Incredible Concrete Car", 2005 },
                    { 32, "Ocie Baumbach", 1, "Gilbertobury", 0, "Sleek Fresh Ball", 2012 },
                    { 33, "Lenora Lebsack", 2, "Port Sheridan", 0, "Licensed Rubber Towels", 2006 },
                    { 34, "Evalyn Gibson", 1, "Port Shayna", 0, "Unbranded Rubber Soap", 2000 },
                    { 35, "Sophie Rolfson", 2, "New Brandonland", 0, "Licensed Fresh Chicken", 2017 },
                    { 36, "Maynard Bradtke", 1, "East Francoport", 0, "Licensed Plastic Soap", 2006 },
                    { 37, "Abagail Block", 0, "Gonzalohaven", 0, "Gorgeous Wooden Sausages", 2006 },
                    { 38, "Ida Cruickshank", 0, "Port Nolan", 0, "Awesome Metal Towels", 2007 },
                    { 39, "Jadon Swaniawski", 2, "New Mallorybury", 0, "Tasty Plastic Table", 2009 },
                    { 40, "Kaya Gusikowski", 2, "Lake Gonzaloland", 0, "Practical Cotton Towels", 2016 },
                    { 41, "Alvera Walter", 1, "West Darylhaven", 0, "Handcrafted Concrete Pants", 2005 },
                    { 42, "Hildegard Gottlieb", 3, "McClureville", 0, "Intelligent Fresh Pants", 2006 },
                    { 43, "Cathrine Farrell", 3, "Jacquesville", 0, "Licensed Concrete Chair", 2006 },
                    { 44, "Anita Von", 1, "East Dulcetown", 0, "Practical Metal Soap", 2009 },
                    { 45, "Stan Greenholt", 0, "Port Elisabethberg", 0, "Fantastic Fresh Cheese", 2005 },
                    { 46, "Ernestine Bradtke", 1, "Josianneborough", 0, "Sleek Wooden Towels", 2016 },
                    { 47, "Rylee Cartwright", 0, "Alenaport", 0, "Sleek Frozen Soap", 2005 },
                    { 48, "Otho Emmerich", 3, "Mayershire", 0, "Licensed Wooden Computer", 2022 },
                    { 49, "Emilia Cummings", 2, "Kailynport", 0, "Ergonomic Plastic Shoes", 2004 },
                    { 50, "Daija Bartoletti", 0, "New Adrienburgh", 0, "Licensed Metal Pants", 2004 },
                    { 51, "Adrianna Moen", 3, "Hillsstad", 0, "Licensed Concrete Computer", 2002 },
                    { 52, "Reid Robel", 3, "Aminaview", 0, "Rustic Wooden Cheese", 2002 },
                    { 53, "Joannie Johnson", 0, "Henrybury", 0, "Rustic Frozen Shirt", 2006 },
                    { 54, "Micheal Simonis", 2, "Raynorland", 0, "Intelligent Wooden Chicken", 2012 },
                    { 55, "Andreane Borer", 0, "Lake Hesterfort", 0, "Ergonomic Plastic Shirt", 2004 },
                    { 56, "Helen Davis", 2, "East Mitchellview", 0, "Licensed Rubber Shirt", 2015 },
                    { 57, "Imani Barton", 1, "East Noemistad", 0, "Small Soft Ball", 2010 },
                    { 58, "Gustave Balistreri", 3, "Ericview", 0, "Refined Wooden Shoes", 2000 },
                    { 59, "Leon Emmerich", 0, "Baumbachfurt", 0, "Rustic Steel Pants", 2023 },
                    { 60, "Pamela Carroll", 1, "North Jevon", 0, "Gorgeous Soft Mouse", 2011 },
                    { 61, "Celestino Krajcik", 0, "Eusebiochester", 0, "Sleek Granite Soap", 2007 },
                    { 62, "Jamarcus Yundt", 1, "Lake Narciso", 0, "Fantastic Steel Chicken", 2005 },
                    { 63, "Beverly Macejkovic", 0, "Batzchester", 0, "Gorgeous Concrete Salad", 2018 },
                    { 64, "Zachary Graham", 0, "Boyerside", 0, "Sleek Cotton Shirt", 2015 },
                    { 65, "Vern O'Keefe", 1, "Dickinsonland", 0, "Licensed Plastic Tuna", 2010 },
                    { 66, "Kara Jones", 1, "Malcolmfort", 0, "Small Wooden Chair", 2018 },
                    { 67, "Demetris Welch", 3, "Port Floton", 0, "Small Granite Table", 2020 },
                    { 68, "Aimee Wiza", 0, "New Oswaldoborough", 0, "Sleek Frozen Soap", 2015 },
                    { 69, "Antonette Olson", 0, "East Bridgettechester", 0, "Ergonomic Granite Sausages", 2015 },
                    { 70, "Kristy MacGyver", 0, "Emmieside", 0, "Intelligent Plastic Gloves", 2015 },
                    { 71, "Porter Kulas", 3, "Hammesburgh", 0, "Sleek Granite Soap", 2005 },
                    { 72, "Carson Conn", 3, "Macland", 0, "Licensed Rubber Sausages", 2009 },
                    { 73, "Einar Satterfield", 2, "Alvahside", 0, "Tasty Plastic Keyboard", 2015 },
                    { 74, "Dalton Schinner", 2, "Lake Annamarie", 0, "Handmade Wooden Bike", 2003 },
                    { 75, "Norval Reinger", 2, "Shanonfort", 0, "Refined Frozen Computer", 2001 },
                    { 76, "Taylor Adams", 0, "South Laceyfurt", 0, "Small Fresh Pizza", 2019 },
                    { 77, "Sigurd Gleichner", 1, "Lesleyfort", 0, "Handmade Rubber Cheese", 2017 },
                    { 78, "Jordi Oberbrunner", 1, "Port Kenyatta", 0, "Incredible Steel Cheese", 2004 },
                    { 79, "Maryse Lehner", 0, "South Bridgettemouth", 0, "Sleek Wooden Pizza", 2020 },
                    { 80, "Zita Feest", 1, "Larsonburgh", 0, "Gorgeous Wooden Salad", 2008 },
                    { 81, "Viva Windler", 1, "West Garrick", 0, "Sleek Frozen Bacon", 2023 },
                    { 82, "Loy Ryan", 2, "Alexisstad", 0, "Ergonomic Cotton Ball", 2005 },
                    { 83, "Steve Ortiz", 0, "New Manuel", 0, "Handmade Granite Bike", 2003 },
                    { 84, "River Parker", 1, "Lake Israel", 0, "Gorgeous Metal Shirt", 2009 },
                    { 85, "Rhoda Moore", 1, "North Jalynborough", 0, "Sleek Fresh Tuna", 2007 },
                    { 86, "Antonette Feeney", 1, "Feeneyfort", 0, "Gorgeous Plastic Soap", 2005 },
                    { 87, "Gavin Kunze", 1, "Hudsonview", 0, "Licensed Concrete Tuna", 2021 },
                    { 88, "Glen Nicolas", 0, "Port Elton", 0, "Practical Plastic Chair", 2003 },
                    { 89, "Hollis Kuphal", 0, "West Duncanmouth", 0, "Rustic Concrete Computer", 2002 },
                    { 90, "Carolyne Koss", 0, "West Adelineside", 0, "Intelligent Concrete Towels", 2001 },
                    { 91, "Alexie Green", 2, "Daytonville", 0, "Tasty Rubber Keyboard", 2014 },
                    { 92, "Josue Mertz", 3, "Owenview", 0, "Incredible Frozen Chicken", 2014 },
                    { 93, "Catalina Oberbrunner", 2, "Lake Kyle", 0, "Unbranded Soft Chair", 2021 },
                    { 94, "Micah Dietrich", 1, "Lake Dayana", 0, "Handmade Wooden Mouse", 2023 },
                    { 95, "Buford Brakus", 0, "Kenyaberg", 0, "Ergonomic Granite Chicken", 2013 },
                    { 96, "Jamarcus Cremin", 2, "North Ardella", 0, "Unbranded Wooden Bike", 2016 },
                    { 97, "Marge Hilpert", 2, "Lake Lulu", 0, "Generic Concrete Fish", 2022 },
                    { 98, "Nicole McClure", 3, "South Elian", 0, "Incredible Frozen Fish", 2004 },
                    { 99, "Aglae Mann", 0, "McCulloughfort", 0, "Generic Plastic Pizza", 2006 },
                    { 100, "Bethany Maggio", 1, "Daretown", 0, "Intelligent Soft Salad", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Port Cory" },
                    { 2, "Lake Hadleyfurt" },
                    { 3, "Emmymouth" },
                    { 4, "Lake Annabelleland" },
                    { 5, "Laviniafort" },
                    { 6, "New Xzavier" },
                    { 7, "Laurenceberg" },
                    { 8, "Port Catharine" },
                    { 9, "Lavadatown" },
                    { 10, "Armstrongmouth" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "DueDate", "InvoiceDate", "InvoiceType", "UserId" },
                values: new object[,]
                {
                    { 1, 87.10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 2, 52.33m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 3, 48.71m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 4, 74.75m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 5, 31.70m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 6, 48.80m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 7, 39.49m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 8, 17.08m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 9, 40.29m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 10, 96.29m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 11, 71.48m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 12, 19.18m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 13, 22.66m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 14, 91.98m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 15, 88.09m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 16, 66.12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 17, 82.83m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 18, 88.13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 19, 52.18m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 20, 96.14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 21, 89.36m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 22, 55.03m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 23, 68.13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 24, 10.31m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 25, 85.75m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 26, 44.99m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 27, 63.91m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 28, 29.48m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 29, 95.40m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 30, 89.79m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 31, 83.37m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 32, 55.16m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 33, 61.11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 34, 83.20m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 35, 48.17m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 36, 83.36m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 37, 72.69m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 38, 32.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 39, 92.68m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 40, 36.45m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 41, 99.17m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 42, 48.11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 43, 60.63m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 44, 12.11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 45, 72.92m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 46, 87.02m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 47, 49.69m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 48, 33.56m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 49, 37.38m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 50, 38.00m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 22, new DateTime(2022, 8, 11, 11, 28, 31, 998, DateTimeKind.Local).AddTicks(1804), 3 },
                    { 2, 80, new DateTime(2023, 5, 1, 19, 2, 27, 476, DateTimeKind.Local).AddTicks(2883), 2 },
                    { 3, 38, new DateTime(2023, 4, 27, 9, 21, 47, 63, DateTimeKind.Local).AddTicks(3522), 1 },
                    { 4, 97, new DateTime(2022, 11, 26, 12, 21, 46, 17, DateTimeKind.Local).AddTicks(5619), 1 },
                    { 5, 64, new DateTime(2023, 1, 27, 23, 16, 23, 27, DateTimeKind.Local).AddTicks(6568), 2 }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "ItemId", "LoanDate", "ReservationId", "ReturnDate", "UserId" },
                values: new object[,]
                {
                    { 1, 97, new DateTime(2022, 6, 28, 2, 43, 25, 166, DateTimeKind.Local).AddTicks(9300), 2, new DateTime(2024, 6, 5, 6, 30, 25, 776, DateTimeKind.Local).AddTicks(4959), 1 },
                    { 2, 9, new DateTime(2023, 5, 11, 6, 46, 16, 605, DateTimeKind.Local).AddTicks(7808), 4, new DateTime(2023, 12, 26, 18, 20, 20, 855, DateTimeKind.Local).AddTicks(4426), 2 },
                    { 3, 49, new DateTime(2023, 4, 24, 2, 43, 58, 901, DateTimeKind.Local).AddTicks(3397), 5, new DateTime(2024, 4, 27, 12, 37, 51, 142, DateTimeKind.Local).AddTicks(5954), 3 },
                    { 4, 10, new DateTime(2022, 10, 24, 10, 12, 5, 680, DateTimeKind.Local).AddTicks(3243), 5, new DateTime(2024, 5, 2, 17, 38, 16, 445, DateTimeKind.Local).AddTicks(5403), 3 },
                    { 5, 5, new DateTime(2023, 5, 29, 8, 59, 35, 418, DateTimeKind.Local).AddTicks(9762), 4, new DateTime(2023, 8, 7, 3, 51, 28, 391, DateTimeKind.Local).AddTicks(75), 2 }
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
                name: "IX_Payments_UserId",
                table: "Payments",
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
                name: "Payments");

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
