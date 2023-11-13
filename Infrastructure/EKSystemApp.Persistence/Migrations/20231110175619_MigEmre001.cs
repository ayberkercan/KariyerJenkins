using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EKSystemApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigEmre001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdPublishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdPublishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertCreates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkDefination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriotNumberId = table.Column<int>(type: "int", nullable: false),
                    AdwertNumberId = table.Column<int>(type: "int", nullable: false),
                    TaskTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperiencePeriodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MillitaryStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddPublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillAndExpertises = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddQuestions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertCreates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Defination = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EbaCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EbaDepartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EbaGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ebas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ebas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EbaUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExperiencePeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperiencePeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RouterLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RouterIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlTag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillitaryStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfessionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertAdQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdQuestionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertAdQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertAdQuestions_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertForignLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForignLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertForignLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertForignLanguages_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertSkillAndExpertises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillAndExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertSkillAndExpertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertSkillAndExpertises_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Registry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserCompany",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserCompany", x => new { x.AppUserId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_AppUserCompany_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserCompany_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserMenus",
                columns: table => new
                {
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserMenus", x => new { x.AppUserId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_AppUserMenus_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName" },
                values: new object[,]
                {
                    { new Guid("3f9455e0-98f9-48e8-845d-ae4ecc08821a"), "D&R" },
                    { new Guid("5c2da11a-1d4c-423c-9747-4710d9d7a008"), "D&R Market" },
                    { new Guid("b7ef666d-b6f1-4e18-8c5f-9623a795f4d1"), "Holding" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "HtmlTag", "Name", "RouterIcon", "RouterLink" },
                values: new object[,]
                {
                    { new Guid("1760462d-147b-4360-8b7f-7d2c90439ad5"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-template']\" routerLinkActive=\"router-link-active\"><i class=\"la la-sign-out\"></i>Mail/Mesaj Şablonu</a>   </li></ul>", "Mail | Mesaj Şablonu ", "la la-sign-out", "mail-message-template " },
                    { new Guid("1fade775-3620-462c-9c43-1917e3b96d40"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['auth-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-plus\"></i>Yetki Tanımlama </a>  </li></ul>", "Yetki Tanımlama", "la la-user-plus", "auth-defination" },
                    { new Guid("344f8bc2-6089-4156-9264-fd4c93d5dfea"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwert-question-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-question\"></i> İlan Soru Tanımlama</a>  </li></ul>", "İlan Soru Tanımlama", "la la-question", "adwert-question-defination" },
                    { new Guid("41b89f6f-c7fa-4ac4-b510-9297b5cd609c"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-pool']\" routerLinkActive=\"router-link-active\"><i class=\"la la-box\"></i>Aday Havuzu</a>  </li></ul>", "Aday Havuzu", "la la-box", "candidate-pool" },
                    { new Guid("47967841-1f2e-4b05-99e7-39c75fe3a13d"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['blog-headline-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-newspaper\"></i> Blog Manşet Yönetimi </a>  </li></ul>", "Blog Manşet Yönetimi", "la la-newspaper", "blog-headline-manager" },
                    { new Guid("4d17fd68-21d1-4441-a323-bfa8b5fa5f34"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['logo-import-screen']\" routerLinkActive=\"router-link-active\"><i class=\"la la-cloud-upload-alt\"></i>Logo Yükleme Ekranı</a>  </li></ul>", "Logo Yükleme Ekranı", "la la-cloud-upload-alt", "logo-import-screen" },
                    { new Guid("4ea8b207-4654-46be-832f-3b0730caf021"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-question-and-answer-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bookmark-o\"></i>Aday Soru/Cevap Listeleri</a>  </li></ul>", "Aday Soru | Cevap Listeleri", "la la-bookmark-o", "candidate-question-and-answer-lists" },
                    { new Guid("5b2e25f7-4656-48ab-a07a-2aa9ae5f8ff6"), "", "Portal | Ana Sayfa İçerik Yönetimi", "", "" },
                    { new Guid("695fa292-b9ba-47ac-a432-6119b0720caf"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['on-front-adwert']\" routerLinkActive=\"router-link-active\"><i class=\"la la-briefcase\"></i> Öne Çıkan İlanlar </a>  </li></ul>", "Öne Çıkan İlanlar", "la la-briefcase", "on-front-adwert" },
                    { new Guid("78f94284-7888-40cc-8f49-08a661a6eb4c"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['new-adwert-create']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-tie\"></i>Yeni İlan Oluştur</a>  </li></ul>", "Yeni İlan Oluştur", "la la-user-tie", "new-adwert-create" },
                    { new Guid("8881ece7-0126-4b11-80f1-64d810329ef9"), "", "Kullanıcı Ayarları", " ", " " },
                    { new Guid("8bc95048-04a7-4bd1-b14f-3007da33520d"), "", "Tanımlamalar", "la la-lock", "navlink dropdown-toggle" },
                    { new Guid("97d7f083-80e6-4241-8cdf-57d3f3a7f067"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['skills-and-experties']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-alt\"></i>Yetenek ve Uzmanlıklar</a>  </li></ul>", "Yetenek ve Uzmanlıklar", "la la-user-alt", "skills-and-experties" },
                    { new Guid("9ef6a4bf-9b77-4133-8949-e217b1c49f49"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-step-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-list\"></i>İş Adımları Yönetimi </a>  </li></ul>", "İş Adımları Yönetimi", "la la-list", "work-step-manager" },
                    { new Guid("ab60bde9-8120-4f25-b714-93f65a4afe61"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-files']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bell\"></i>Aday Dosyaları</a>  </li></ul>", "Aday Dosyaları", "la la-bell", "candidate-files" },
                    { new Guid("ad5ec88c-0b08-41a3-a060-112bdaf5d920"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['dashboard']\" routerLinkActive=\"router-link-active\"> <i class=\"la la-home\"></i> Admin Kariyer Giriş</a>  </li></ul>", "Admin Kariyer | Giriş", "la la-home", "dashboard" },
                    { new Guid("addc5558-67a2-4dca-a8a1-ddd971614b89"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-category-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-boxes\"></i>İş Kategori Yönetimi </a>  </li></ul>", "İş Kategorileri Yönetimi", "la la-boxes", "work-category-manager" },
                    { new Guid("b5308e58-6d77-4d52-bd9b-8ffb3b77f72c"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-comment-o\"></i>Mail/Mesaj Yönetimi</a>  </li></ul>", "Mail | Mesaj Yönetimi", "la la-comment-o", "mail-message-manager" },
                    { new Guid("b7370cbf-d290-4c84-ae3c-1c72eb73d752"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['application-candidate-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-file-invoice\"></i> Başvuran Aday Listesi </a>  </li></ul>", "Başvuran Aday Listeleri", "la la-file-invoice", "application-candidate-lists" },
                    { new Guid("bd384bb0-c170-4254-9446-5270c59fce43"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['transfer-requested-posination-name']\" routerLinkActive=\"router-link-active\"><i class=\"la la-exchange-alt\"></i> Talep Edilen Pozisyon Adı Aktar</a>  </li></ul>", "Talep Edilen Pozisyon Adı Aktar", "la la-exchange-alt", "transfer-requested-posination-name" },
                    { new Guid("c6e6b243-d6a8-4d4b-952a-676941362302"), "", "Raporlar", "la la-file-alt", "report" },
                    { new Guid("d71873a7-b6f3-424e-a53f-cf28d61e2991"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwerts']\" routerLinkActive=\"router-link-active\"><i class=\"la la-paper-plane\"></i>İlanlar</a>  </li></ul>", "İlanlar", "la la-paper-plane", "adwerts" },
                    { new Guid("f2953afe-c6d4-47fa-9ea0-d13ea73d5bdf"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['role-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-plus-circle\"></i>Rol Tanımlama</a>  </li></ul>", "Rol Tanımlama", "la la-plus-circle", "role-defination" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertAdQuestions_AdvertCreateId",
                table: "AdvertAdQuestions",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertForignLanguages_AdvertCreateId",
                table: "AdvertForignLanguages",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertSkillAndExpertises_AdvertCreateId",
                table: "AdvertSkillAndExpertises",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserCompany_CompanyId",
                table: "AppUserCompany",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserMenus_MenuId",
                table: "AppUserMenus",
                column: "MenuId");

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
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdPublishers");

            migrationBuilder.DropTable(
                name: "AdStatuses");

            migrationBuilder.DropTable(
                name: "AdvertAdQuestions");

            migrationBuilder.DropTable(
                name: "AdvertForignLanguages");

            migrationBuilder.DropTable(
                name: "AdvertSkillAndExpertises");

            migrationBuilder.DropTable(
                name: "AppUserCompany");

            migrationBuilder.DropTable(
                name: "AppUserMenus");

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
                name: "EbaCompanies");

            migrationBuilder.DropTable(
                name: "EbaDepartments");

            migrationBuilder.DropTable(
                name: "EbaGroups");

            migrationBuilder.DropTable(
                name: "Ebas");

            migrationBuilder.DropTable(
                name: "EbaUnits");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "ExperiencePeriods");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MillitaryStatuses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "PositionTypes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "WorkModels");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "AdvertCreates");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
