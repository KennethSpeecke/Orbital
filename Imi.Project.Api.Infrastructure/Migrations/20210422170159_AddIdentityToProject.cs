using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddIdentityToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Astronauts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Age = table.Column<byte>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ObitDate = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    IsCurrentlyActiveInSpace = table.Column<bool>(nullable: false),
                    TimeInSpace = table.Column<DateTime>(nullable: false),
                    TimeServedForMilitary = table.Column<DateTime>(nullable: false),
                    TotalMissions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Astronauts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Astronomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Age = table.Column<byte>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ObitDate = table.Column<DateTime>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    TotalActiveWorkingYears = table.Column<byte>(nullable: false),
                    TotalDiscoveriesMade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Astronomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "NotableWorks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AstronomerId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotableWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotableWorks_Astronomers_AstronomerId",
                        column: x => x.AstronomerId,
                        principalTable: "Astronomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpaceEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApogeeInKm = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longtitude = table.Column<double>(nullable: false),
                    Mass = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PerigeeInKm = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(nullable: true),
                    Size = table.Column<double>(nullable: false),
                    SpaceObjectType = table.Column<int>(nullable: false),
                    ThumbnailImage = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    MissionInformation = table.Column<string>(nullable: true),
                    IsOnCollisionCourse = table.Column<bool>(nullable: true),
                    AstronomerId = table.Column<Guid>(nullable: true),
                    Shape = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpaceEntities_Astronomers_AstronomerId",
                        column: x => x.AstronomerId,
                        principalTable: "Astronomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteUserObjects",
                columns: table => new
                {
                    SpaceObjectId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteUserObjects", x => new { x.UserId, x.SpaceObjectId });
                    table.ForeignKey(
                        name: "FK_FavoriteUserObjects_SpaceEntities_SpaceObjectId",
                        column: x => x.SpaceObjectId,
                        principalTable: "SpaceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteUserObjects_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SpaceEntityId = table.Column<Guid>(nullable: false),
                    Uri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageEntities_SpaceEntities_SpaceEntityId",
                        column: x => x.SpaceEntityId,
                        principalTable: "SpaceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanetoidComposition",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TypeName = table.Column<int>(nullable: false),
                    PlanetoidId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetoidComposition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanetoidComposition_SpaceEntities_PlanetoidId",
                        column: x => x.PlanetoidId,
                        principalTable: "SpaceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpaceCraftCrews",
                columns: table => new
                {
                    AstronautId = table.Column<Guid>(nullable: false),
                    SpaceCraftId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceCraftCrews", x => new { x.AstronautId, x.SpaceCraftId });
                    table.ForeignKey(
                        name: "FK_SpaceCraftCrews_Astronauts_AstronautId",
                        column: x => x.AstronautId,
                        principalTable: "Astronauts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpaceCraftCrews_SpaceEntities_SpaceCraftId",
                        column: x => x.SpaceCraftId,
                        principalTable: "SpaceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApplicationUserId1 = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SpaceEntityId = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComments_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserComments_SpaceEntities_SpaceEntityId",
                        column: x => x.SpaceEntityId,
                        principalTable: "SpaceEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", 0, "61ba11b9-f620-4c59-aa77-b6fc99862af5", "ApplicationUser", "AdmiralChunky@mailinator.com", false, false, null, null, null, "4D3C54A22A97802627566A24F2DC7C1B", null, false, "2a4185ee-af97-429f-b90f-323d0f41ab6a", false, "Admiral Chuncky" },
                    { "34d82894-cd34-40a6-a19e-881ca98451f7", 0, "1a49bbc4-e24b-43e2-b924-d937c8696b42", "ApplicationUser", "ColonelChunky@mailinator.com", false, false, null, null, null, "CE071784473D4E694D397DA4ECB5219E", null, false, "2ca9cd8c-c603-45bb-8e38-4c3a33c1db21", false, "Colonel Chuncky" },
                    { "86b9ff3d-5188-43e5-9c8d-f7f46823ce73", 0, "e0fcb6ee-c14e-4f60-a524-a409667f50fe", "ApplicationUser", "SergeantChunky@mailinator.com", false, false, null, null, null, "6074E512F4F844BD415C5941A41BE25F", null, false, "7c23f9e3-29f9-4ade-bc64-146822bf187b", false, "Sergeant Chuncky" },
                    { "8d5213cb-1abc-43e3-a4d6-35b92e829f6f", 0, "8af86ff3-d769-4ff4-a3b7-774139882bbc", "ApplicationUser", "CorporalChunky@mailinator.com", false, false, null, null, null, "27CFC5E4E4AF55E4A67D22B5C080F750", null, false, "9379cd17-a781-4dcb-aa9c-ceb87ac8b20f", false, "Corporal Chuncky" },
                    { "ced8f1e3-fbab-4db1-99a1-fa45b1428c21", 0, "5f2e17f9-bcb9-4090-beff-fc4e7c23df34", "ApplicationUser", "RecruitChunky@mailinator.com", false, false, null, null, null, "9F3171B314D1869C68B0E9F82C087BF9", null, false, "e5ff9864-ae76-49f7-96e2-f6ad1f65d613", false, "Recruit Chuncky" }
                });

            migrationBuilder.InsertData(
                table: "Astronauts",
                columns: new[] { "Id", "Age", "BirthDate", "IsCurrentlyActiveInSpace", "Name", "ObitDate", "Surname", "TimeInSpace", "TimeServedForMilitary", "TotalMissions" },
                values: new object[,]
                {
                    { new Guid("0168ae99-7a93-49cd-8d96-832b5d8e5383"), (byte)56, new DateTime(1965, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunita", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", new DateTime(1, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { new Guid("6491a95e-872a-438c-8f0d-a0991e3f48bc"), (byte)36, new DateTime(1930, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Edward", new DateTime(1967, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "White", new DateTime(1, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(21, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("3ef70e4c-74a9-4f46-b017-005e95310401"), (byte)61, new DateTime(1960, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Peggy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whitson", new DateTime(2, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { new Guid("5fd739f5-fed9-4345-94db-c58e27790aff"), (byte)99, new DateTime(1930, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Buzz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aldrin", new DateTime(1, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("2198a48e-2f27-4d09-a264-08913c18d1db"), (byte)63, new DateTime(1958, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Susan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Helms", new DateTime(1, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(35, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.InsertData(
                table: "Astronomers",
                columns: new[] { "Id", "Age", "BirthDate", "Name", "ObitDate", "Surname", "TotalActiveWorkingYears", "TotalDiscoveriesMade" },
                values: new object[,]
                {
                    { new Guid("cb4e377d-f341-4c60-9efc-7cc02a8c1df9"), (byte)61, new DateTime(1959, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marcelo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gleiser", (byte)40, 6 },
                    { new Guid("6bf00c4f-c458-465a-9073-3c4531650133"), (byte)60, new DateTime(1848, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", new DateTime(1908, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cruls", (byte)39, 17 },
                    { new Guid("2cfd4710-3af2-421c-8ebb-262b5b092a92"), (byte)81, new DateTime(1846, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonio", new DateTime(1928, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abetti", (byte)41, 4 },
                    { new Guid("b3eab1b9-7806-4153-b3cd-6131bac6fea9"), (byte)75, new DateTime(1950, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norio", new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaifu", (byte)47, 3 },
                    { new Guid("87e606a8-8674-4442-bc23-a5893a4d8721"), (byte)36, new DateTime(1950, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marc", new DateTime(1987, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaronson", (byte)21, 11 }
                });

            migrationBuilder.InsertData(
                table: "SpaceEntities",
                columns: new[] { "Id", "ApogeeInKm", "Discriminator", "Latitude", "Longtitude", "Mass", "Name", "PerigeeInKm", "ShortName", "Size", "SpaceObjectType", "ThumbnailImage", "MissionInformation" },
                values: new object[,]
                {
                    { new Guid("e50a22c0-30e1-4d72-9f0b-ed259ee27514"), 550, "SpaceCraftEntity", 0.0, 0.0, 260.0, "Starlink V1", 550, "SlV1", 2.0, 3, "default.jpg", "Starlink is SpaceX's 12000-satellite low earth orbit constellation to provide broadband Internet access." },
                    { new Guid("f148f935-84ad-41c3-aebd-9d183d9e7e6a"), 0, "SpaceCraftEntity", 0.0, 0.0, 9616.0, "Crew Dragon", 0, "C-DA", 8.0, 2, "default.jpg", "Crew dragon created by spacex is designed to send humans to space and back to earth in a costeffective manner." },
                    { new Guid("d62bbcec-6e3a-416f-a5e3-d77fbee675d6"), 0, "SpaceCraftEntity", 0.0, 0.0, 7415.0, "Cargo Dragon", 0, "CA-DA", 8.0, 3, "default.jpg", "Dragon created by spacex is designed to send cargo to space and back to earth in a costeffective manner" },
                    { new Guid("0a612c41-d1e7-41c3-8a40-880e3beb0333"), 421, "SpaceCraftEntity", 0.0, 0.0, 419725.0, "International Space Station", 417, "ISS", 915.0, 2, "default.jpg", "he ISS was originally intended to be a laboratory, observatory, and factory while providing transportation, maintenance, and a low Earth orbit staging base for possible future missions to the Moon, Mars, and asteroids." },
                    { new Guid("4ef5c419-655a-440b-967c-65c79bf243d3"), 0, "SpaceCraftEntity", 0.0, 0.0, 531000.0, "Atlas V-541", 0, "AT-V-541", 58.0, 2, "default.jpg", "This launch vehicle provides the velocity needed by a spacecraft to escape Earth's gravity and set it on its course for Mars." }
                });

            migrationBuilder.InsertData(
                table: "SpaceEntities",
                columns: new[] { "Id", "ApogeeInKm", "Discriminator", "Latitude", "Longtitude", "Mass", "Name", "PerigeeInKm", "ShortName", "Size", "SpaceObjectType", "ThumbnailImage", "IsOnCollisionCourse" },
                values: new object[,]
                {
                    { new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f"), 760, "SpaceDebrisEntity", 0.0, 0.0, 15437.15, "Cosmos 2251", 736, "036BXZ", 12.0, 0, "ThnCosmos2251.jpg", false },
                    { new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), 899, "SpaceDebrisEntity", 0.0, 0.0, 241.0, "Iridium 33", 756, "051DG", 1.0, 0, "ThnIridium33.jpg", true },
                    { new Guid("99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d"), 848, "SpaceDebrisEntity", 0.0, 0.0, 9000.0, "SL-16RB", 837, "SL16", 7.0, 0, "ThnSL16.jpg", false },
                    { new Guid("4fd5e7e7-3516-425a-a8c7-28ee8b89596a"), 766, "SpaceDebrisEntity", 0.0, 0.0, 7800.0, "Envisat", 764, "Esat", 2.0, 0, "ThnEnvisat.jpg", true },
                    { new Guid("5552205c-ad29-4f80-adb1-c357b17373f8"), 794, "SpaceDebrisEntity", 0.0, 0.0, 3560.0, "Adeos", 793, "Adeos", 7.0, 0, "ThnAdeos.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "FavoriteUserObjects",
                columns: new[] { "UserId", "SpaceObjectId" },
                values: new object[,]
                {
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", new Guid("5552205c-ad29-4f80-adb1-c357b17373f8") },
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", new Guid("4fd5e7e7-3516-425a-a8c7-28ee8b89596a") },
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", new Guid("99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d") },
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968") },
                    { "b9f3599b-ba5d-4799-8fd4-77a7e4023be6", new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f") }
                });

            migrationBuilder.InsertData(
                table: "ImageEntities",
                columns: new[] { "Id", "SpaceEntityId", "Uri" },
                values: new object[,]
                {
                    { new Guid("ba76ce34-7eb0-4e28-92af-4b1701051785"), new Guid("4fd5e7e7-3516-425a-a8c7-28ee8b89596a"), "Envisat-ba76ce34-7eb0-4e28-92af-4b1701051785.jpg" },
                    { new Guid("1e5c583b-1211-479e-bb6f-83e744ea9562"), new Guid("99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d"), "SL16-1e5c583b-1211-479e-bb6f-83e744ea9562.jpg" },
                    { new Guid("6eb4a73b-95d5-4bf6-8ab1-92e597fa9909"), new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), "Iridium33-6eb4a73b-95d5-4bf6-8ab1-92e597fa9909.jpg" },
                    { new Guid("d89db8a6-6c61-4c6f-869e-f2dec992b89d"), new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), "Iridium33-d89db8a6-6c61-4c6f-869e-f2dec992b89d.jpg" },
                    { new Guid("f7396475-3304-4e27-b2bb-7fd557184199"), new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), "Iridium33-f7396475-3304-4e27-b2bb-7fd557184199.jpg" },
                    { new Guid("bcc47fac-1a42-41a1-9fa1-8b91d2c8b153"), new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f"), "Cosmos2251-bcc47fac-1a42-41a1-9fa1-8b91d2c8b153.jpg" },
                    { new Guid("6b28f5c2-12cd-46ff-a525-ddcdce16b0b4"), new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f"), "Cosmos2251-6b28f5c2-12cd-46ff-a525-ddcdce16b0b4.jpg" },
                    { new Guid("082f1641-cd03-46f3-a484-e2d4b0929849"), new Guid("5552205c-ad29-4f80-adb1-c357b17373f8"), "Adeos-082f1641-cd03-46f3-a484-e2d4b0929849.jpg" },
                    { new Guid("c068ab92-d240-49bb-a71b-0acdde861131"), new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f"), "Cosmos2251-c068ab92-d240-49bb-a71b-0acdde861131.jpg" }
                });

            migrationBuilder.InsertData(
                table: "NotableWorks",
                columns: new[] { "Id", "AstronomerId", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("03803688-5986-4cb4-a197-5758c7fa7a7c"), new Guid("6bf00c4f-c458-465a-9073-3c4531650133"), "Founded the Imperial Observatory now known as The National Observatory (Brazil).", "Imperial Observatory" },
                    { new Guid("a5a2f47f-97e0-4110-976b-41294db83111"), new Guid("b3eab1b9-7806-4153-b3cd-6131bac6fea9"), "The oldest and most prestigious physics award in Japan.", " Nishina Memorial Prize" },
                    { new Guid("511e4a30-8ef6-46e7-9852-b579c6e3d617"), new Guid("2cfd4710-3af2-421c-8ebb-262b5b092a92"), "Found 89 Planet systems.", "Planet Discoveries" },
                    { new Guid("e92e08ae-82af-4025-962b-1956934bd31a"), new Guid("cb4e377d-f341-4c60-9efc-7cc02a8c1df9"), "The Templeton Prize is an annual award granted to a living person, in the estimation of the judges, whose exemplary achievements advance Sir John Templeton's philanthropic vision: harnessing the power of the sciences to explore the deepest questions of the universe and humankind’s place and purpose within it.", "Templeton Prize" },
                    { new Guid("a8aa9aac-7a91-4f7d-8daf-5d31e0b756ff"), new Guid("87e606a8-8674-4442-bc23-a5893a4d8721"), "The BOOMERanG experiment (Balloon Observations Of Millimetric Extragalactic Radiation ANd Geophysics) was an experiment which measured the cosmic microwave background radiation of a part of the sky during three sub-orbital (high-altitude) balloon flights.", "BOOMERanG experiment" }
                });

            migrationBuilder.InsertData(
                table: "SpaceCraftCrews",
                columns: new[] { "AstronautId", "SpaceCraftId" },
                values: new object[,]
                {
                    { new Guid("0168ae99-7a93-49cd-8d96-832b5d8e5383"), new Guid("0a612c41-d1e7-41c3-8a40-880e3beb0333") },
                    { new Guid("5fd739f5-fed9-4345-94db-c58e27790aff"), new Guid("0a612c41-d1e7-41c3-8a40-880e3beb0333") },
                    { new Guid("6491a95e-872a-438c-8f0d-a0991e3f48bc"), new Guid("0a612c41-d1e7-41c3-8a40-880e3beb0333") },
                    { new Guid("3ef70e4c-74a9-4f46-b017-005e95310401"), new Guid("f148f935-84ad-41c3-aebd-9d183d9e7e6a") },
                    { new Guid("2198a48e-2f27-4d09-a264-08913c18d1db"), new Guid("0a612c41-d1e7-41c3-8a40-880e3beb0333") }
                });

            migrationBuilder.InsertData(
                table: "SpaceEntities",
                columns: new[] { "Id", "ApogeeInKm", "Discriminator", "Latitude", "Longtitude", "Mass", "Name", "PerigeeInKm", "ShortName", "Size", "SpaceObjectType", "ThumbnailImage", "AstronomerId", "Shape" },
                values: new object[,]
                {
                    { new Guid("d607b31e-7705-4cfe-b433-01c5ca7b2529"), 38, "SpacePlanetoidEntity", 0.0, 0.0, 4877.0, "Hydra", 38, "S/2005", 5752.0, 1, "default.jpg", new Guid("cb4e377d-f341-4c60-9efc-7cc02a8c1df9"), "Oval" },
                    { new Guid("e295c1f3-6f37-400a-b066-b99b06cb01c3"), 31, "SpacePlanetoidEntity", 22.826000000000001, 88.004999999999995, 147.0, "1566 Icarus", 47, "1566Ica", 671.0, 1, "default.jpg", new Guid("6bf00c4f-c458-465a-9073-3c4531650133"), "Oval" },
                    { new Guid("cb83c7e6-6c8c-4e38-8f1e-356ccfabcfc0"), 45, "SpacePlanetoidEntity", 0.0, 0.0, 3454.0, "1685 Toro", 47, "Tor", 2457.0, 1, "default.jpg", new Guid("2cfd4710-3af2-421c-8ebb-262b5b092a92"), "Egg" },
                    { new Guid("540ddc41-0631-409e-a09f-bae6d95cbe8b"), 32, "SpacePlanetoidEntity", 0.0, 0.0, 1676.0, "Kerberos", 31, "S/2011", 1710.0, 1, "default.jpg", new Guid("b3eab1b9-7806-4153-b3cd-6131bac6fea9"), "Sphere" },
                    { new Guid("f78cd23d-0ba6-4e64-86bb-d183a274f1f6"), 78, "SpacePlanetoidEntity", 0.0, 0.0, 2579.0, "1981 Midas", 68, "Midas", 5478.0, 1, "default.jpg", new Guid("87e606a8-8674-4442-bc23-a5893a4d8721"), "Sphere" }
                });

            migrationBuilder.InsertData(
                table: "UserComments",
                columns: new[] { "Id", "ApplicationUserId", "ApplicationUserId1", "IsDeleted", "SpaceEntityId", "Text" },
                values: new object[,]
                {
                    { new Guid("ece72624-77c6-4386-abbd-6f5aac6c2a5e"), new Guid("34d82894-cd34-40a6-a19e-881ca98451f7"), null, false, new Guid("ffebf84b-b0cd-4bab-91a6-dd3024f81968"), "What a beauty!" },
                    { new Guid("d63a5fad-ace9-46da-be26-3c955c5f8085"), new Guid("8d5213cb-1abc-43e3-a4d6-35b92e829f6f"), null, false, new Guid("99cbd4d0-c44a-4ef6-9fc3-835b7e11b26d"), "Im ronny pickering mate" },
                    { new Guid("fdd2f797-8f61-474f-bb30-05a373b19055"), new Guid("ced8f1e3-fbab-4db1-99a1-fa45b1428c21"), null, false, new Guid("4fd5e7e7-3516-425a-a8c7-28ee8b89596a"), "nasa is a hoaxcx" },
                    { new Guid("75e3838e-6228-40b4-9c60-e9fbc841290b"), new Guid("b9f3599b-ba5d-4799-8fd4-77a7e4023be6"), null, false, new Guid("46f23e53-093c-44ab-9427-9b03cd08dd8f"), "Such a shame that its gone!" },
                    { new Guid("00bcbe48-f5f3-4a01-b564-144af5ae332f"), new Guid("86b9ff3d-5188-43e5-9c8d-f7f46823ce73"), null, false, new Guid("5552205c-ad29-4f80-adb1-c357b17373f8"), "We are number one" }
                });

            migrationBuilder.InsertData(
                table: "PlanetoidComposition",
                columns: new[] { "Id", "PlanetoidId", "TypeName" },
                values: new object[,]
                {
                    { new Guid("3e7c9638-2ca6-413d-8e57-1e279645249d"), new Guid("f78cd23d-0ba6-4e64-86bb-d183a274f1f6"), 2 },
                    { new Guid("14915d9f-0b10-4589-9a17-f6baaa5c8d74"), new Guid("540ddc41-0631-409e-a09f-bae6d95cbe8b"), 2 },
                    { new Guid("72767dda-f6be-4cee-99ac-b4e627ba524a"), new Guid("540ddc41-0631-409e-a09f-bae6d95cbe8b"), 1 },
                    { new Guid("42ebc493-704d-4ff2-b296-c056faa894f5"), new Guid("cb83c7e6-6c8c-4e38-8f1e-356ccfabcfc0"), 1 },
                    { new Guid("3819da10-9c39-44de-87e4-d945fa8a0aee"), new Guid("e295c1f3-6f37-400a-b066-b99b06cb01c3"), 1 },
                    { new Guid("896bf05c-4ceb-4077-b3aa-b84eb7c63754"), new Guid("d607b31e-7705-4cfe-b433-01c5ca7b2529"), 1 },
                    { new Guid("7c217060-1ba2-42de-bfd1-e8120939b582"), new Guid("d607b31e-7705-4cfe-b433-01c5ca7b2529"), 2 }
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
                name: "IX_FavoriteUserObjects_SpaceObjectId",
                table: "FavoriteUserObjects",
                column: "SpaceObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageEntities_SpaceEntityId",
                table: "ImageEntities",
                column: "SpaceEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_NotableWorks_AstronomerId",
                table: "NotableWorks",
                column: "AstronomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetoidComposition_PlanetoidId",
                table: "PlanetoidComposition",
                column: "PlanetoidId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceCraftCrews_SpaceCraftId",
                table: "SpaceCraftCrews",
                column: "SpaceCraftId");

            migrationBuilder.CreateIndex(
                name: "IX_SpaceEntities_AstronomerId",
                table: "SpaceEntities",
                column: "AstronomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_ApplicationUserId1",
                table: "UserComments",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_SpaceEntityId",
                table: "UserComments",
                column: "SpaceEntityId");
        }

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
                name: "FavoriteUserObjects");

            migrationBuilder.DropTable(
                name: "ImageEntities");

            migrationBuilder.DropTable(
                name: "NotableWorks");

            migrationBuilder.DropTable(
                name: "PlanetoidComposition");

            migrationBuilder.DropTable(
                name: "SpaceCraftCrews");

            migrationBuilder.DropTable(
                name: "UserComments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Astronauts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SpaceEntities");

            migrationBuilder.DropTable(
                name: "Astronomers");
        }
    }
}
