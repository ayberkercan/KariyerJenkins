using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EKSystemApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Yusuf002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvertCreates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkDefination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logo = table.Column<int>(type: "int", nullable: false),
                    PeriotNumberId = table.Column<int>(type: "int", nullable: false),
                    AdwertNumberId = table.Column<int>(type: "int", nullable: false)
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
                name: "AdPublishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdPublishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdPublishers_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdQuestions_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdStatuses_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EbaCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EbaCompanies_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EbaDepartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EbaDepartments_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EbaGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EbaGroups_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EbaUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitName = table.Column<int>(type: "int", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EbaUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EbaUnits_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationLevels_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExperiencePeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperiencePeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperiencePeriods_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForignLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForignLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForignLanguages_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobCategories_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locaitons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocaitonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locaitons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locaitons_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MillitaryStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillitaryStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MillitaryStatuses_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PositionTypes_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SkillAndExpertises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillAndExpertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillAndExpertises_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTypes_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkModels_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTypes_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
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
<<<<<<< HEAD:Infrastructure/EKSystemApp.Persistence/Migrations/20231025123814_Yusuf002.cs
                    { new Guid("18d02464-0fcf-4022-988b-e79f6db7d3b8"), "D&R Market" },
                    { new Guid("7a57a43b-3768-44bd-ab7b-dbdff21be46b"), "Holding" },
                    { new Guid("7d419c8d-cc97-4c1c-818a-7ae526ac40b2"), "D&R" }
=======
                    { new Guid("81543cd8-ef38-4138-bea8-2b56949691cd"), "D&R" },
                    { new Guid("d43e6c1d-56dc-40ca-8647-6add7c8cbb96"), "Holding" },
                    { new Guid("f8f9ee6c-f357-42a1-9e2c-33ad9b56859f"), "D&R Market" }
>>>>>>> MenuToUser v1.:Infrastructure/EKSystemApp.Persistence/Migrations/20231025083307_MigEmre001.cs
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "HtmlTag", "Name", "RouterIcon", "RouterLink" },
                values: new object[,]
                {
<<<<<<< HEAD:Infrastructure/EKSystemApp.Persistence/Migrations/20231025123814_Yusuf002.cs
                    { new Guid("0257d982-a0fa-46cd-8d2a-ffa4634f0b4c"), "İlanlar", "la la-paper-plane", "adwerts" },
                    { new Guid("1567a8cb-95cf-47ba-bae4-ff0c5710894e"), "İlan Soru Tanımlama", "la la-question", "adwert-question-defination" },
                    { new Guid("1de1ac2b-437b-446a-8ec3-8b11af26a35e"), "Yeni İlan Oluştur", "la la-user-tie", "new-adwert-create" },
                    { new Guid("1e1b9368-5b14-4564-a2ab-a45c528fe14f"), "Tanımlamalar", "la la-lock", "navlink dropdown-toggle" },
                    { new Guid("21b2d021-9087-4970-a77a-997b4e3a60c4"), "Blog Manşet Yönetimi", "la la-newspaper", "blog-headline-manager" },
                    { new Guid("4636d33c-9f2c-4f84-86fa-58e8ab768973"), "Mail | Mesaj Şablonu ", "la la-sign-out", "mail-message-template " },
                    { new Guid("483e67b1-9f7b-4fce-b232-4c7c4c6f5e89"), "Kullanıcı Ayarları", " ", " " },
                    { new Guid("5561789d-a145-418d-874e-3469fe149e11"), "Aday Havuzu", "la la-box", "candidate-pool" },
                    { new Guid("5f4eec29-5e84-496b-a527-ce1f930fc6f0"), "Raporlar", "la la-file-alt", "report" },
                    { new Guid("6e62262c-aa84-49ba-b282-93a74809a279"), "İş Kategorileri Yönetimi", "la la-boxes", "work-category-manager" },
                    { new Guid("70f5400b-7632-4a97-9d6b-5c74a931b693"), "Portal | Ana Sayfa İçerik Yönetimi", "", "" },
                    { new Guid("7b5abd77-f9b7-484d-95d2-3d9f7b26cf88"), "Aday Soru | Cevap Listeleri", "la la-bookmark-o", "candidate-question-and-answer-lists" },
                    { new Guid("83538e8a-b881-47b5-89ab-f353312e8b5c"), "Yetenek ve Uzmanlıklar", "la la-user-alt", "skills-and-experties" },
                    { new Guid("84040291-1f37-4c5a-b0fe-e6f0ed0e5e66"), "Başvuran Aday Listeleri", "la la-file-invoice", "application-candidate-lists" },
                    { new Guid("8bc45f85-bb45-4fc3-8fb2-6acbb3ba2b7d"), "Öne Çıkan İlanlar", "la la-briefcase", "on-front-adwert" },
                    { new Guid("a5262b4a-af7f-49c6-bdc7-e2e9cea6a261"), "Aday Dosyaları", "la la-bell", "candidate-files" },
                    { new Guid("ab36b788-455e-41cc-abd0-ea11b49ad2e8"), "Logo Yükleme Ekranı", "la la-cloud-upload-alt", "logo-import-screen" },
                    { new Guid("ad54b78a-3326-4b3e-a7d9-efbbfb4ad452"), "İş Adımları Yönetimi", "la la-list", "work-step-manager" },
                    { new Guid("af7db1a5-4dcf-4a51-9976-cedb2bf87ed0"), "Talep Edilen Pozisyon Adı Aktar", "la la-exchange-alt", "transfer-requested-posination-name" },
                    { new Guid("c08273b1-6cb3-4635-bbec-0e1b4b34f446"), "Yetki Tanımlama", "la la-user-plus", "auth-defination" },
                    { new Guid("c0b1a4f7-5b4a-472b-95f2-b50c28a57252"), "Mail | Mesaj Yönetimi", "la la-comment-o", "mail-message-manager" },
                    { new Guid("c693784e-9f46-4f92-b7e2-e102d8873881"), "Admin Kariyer | Giriş", "la la-home", "dashboard" },
                    { new Guid("f4ec320a-71f3-49bb-834e-63b8472b70e5"), "Rol Tanımlama", "la la-plus-circle", "role-defination" }
=======
                    { new Guid("08197f59-24e8-4888-9fb0-7df9af5f264b"), "", "Kullanıcı Ayarları", " ", " " },
                    { new Guid("167425bd-19ef-4ccb-85e3-8ed985c48de6"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwerts']\" routerLinkActive=\"router-link-active\"><i class=\"la la-paper-plane\"></i>İlanlar</a>  </li></ul>", "İlanlar", "la la-paper-plane", "adwerts" },
                    { new Guid("172d451f-9c65-48ed-912c-dde8a8d19355"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['skills-and-experties']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-alt\"></i>Yetenek ve Uzmanlıklar</a>  </li></ul>", "Yetenek ve Uzmanlıklar", "la la-user-alt", "skills-and-experties" },
                    { new Guid("2465a759-dc8d-47f9-9a92-488e9cc133d0"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-files']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bell\"></i>Aday Dosyaları</a>  </li></ul>", "Aday Dosyaları", "la la-bell", "candidate-files" },
                    { new Guid("378fe5cb-be1e-452f-84b3-55ecb4d39369"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['on-front-adwert']\" routerLinkActive=\"router-link-active\"><i class=\"la la-briefcase\"></i> Öne Çıkan İlanlar </a>  </li></ul>", "Öne Çıkan İlanlar", "la la-briefcase", "on-front-adwert" },
                    { new Guid("3d26ed25-7eaa-40fa-97be-c49f8608a3c7"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['application-candidate-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-file-invoice\"></i> Başvuran Aday Listesi </a>  </li></ul>", "Başvuran Aday Listeleri", "la la-file-invoice", "application-candidate-lists" },
                    { new Guid("40924e89-02ae-410f-a2ab-f955abc9c8d0"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-template']\" routerLinkActive=\"router-link-active\"><i class=\"la la-sign-out\"></i>Mail/Mesaj Şablonu</a>   </li></ul>", "Mail | Mesaj Şablonu ", "la la-sign-out", "mail-message-template " },
                    { new Guid("45bc86f5-62d5-489f-8fc7-740d7b90ca94"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-comment-o\"></i>Mail/Mesaj Yönetimi</a>  </li></ul>", "Mail | Mesaj Yönetimi", "la la-comment-o", "mail-message-manager" },
                    { new Guid("5ffb140a-5cf4-4353-a41c-7853bbb9b831"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['dashboard']\" routerLinkActive=\"router-link-active\"> <i class=\"la la-home\"></i> Admin Kariyer Giriş</a>  </li></ul>", "Admin Kariyer | Giriş", "la la-home", "dashboard" },
                    { new Guid("615c7b97-53e2-4ea9-ac12-af90ca4ae188"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-category-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-boxes\"></i>İş Kategori Yönetimi </a>  </li></ul>", "İş Kategorileri Yönetimi", "la la-boxes", "work-category-manager" },
                    { new Guid("669084bd-937b-4466-8d09-f0c9e4b4ea77"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['logo-import-screen']\" routerLinkActive=\"router-link-active\"><i class=\"la la-cloud-upload-alt\"></i>Logo Yükleme Ekranı</a>  </li></ul>", "Logo Yükleme Ekranı", "la la-cloud-upload-alt", "logo-import-screen" },
                    { new Guid("696a7b0d-dac0-4e78-b8db-4773c8f49378"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-step-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-list\"></i>İş Adımları Yönetimi </a>  </li></ul>", "İş Adımları Yönetimi", "la la-list", "work-step-manager" },
                    { new Guid("76c37253-5266-44b1-b67d-ae0548a1638c"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwert-question-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-question\"></i> İlan Soru Tanımlama</a>  </li></ul>", "İlan Soru Tanımlama", "la la-question", "adwert-question-defination" },
                    { new Guid("7d89d449-817d-49b6-9146-a22fd5ed8b89"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['auth-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-plus\"></i>Yetki Tanımlama </a>  </li></ul>", "Yetki Tanımlama", "la la-user-plus", "auth-defination" },
                    { new Guid("9249cc80-6c97-4d1b-8715-bfcac364501c"), "", "Raporlar", "la la-file-alt", "report" },
                    { new Guid("96ae8876-3873-4188-ba07-cc98b4e57f95"), "", "Portal | Ana Sayfa İçerik Yönetimi", "", "" },
                    { new Guid("a5b4bc4c-7f2d-4831-b11b-578247a3c3c2"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['blog-headline-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-newspaper\"></i> Blog Manşet Yönetimi </a>  </li></ul>", "Blog Manşet Yönetimi", "la la-newspaper", "blog-headline-manager" },
                    { new Guid("b76fbfa2-14ee-4562-abef-06ad26f55b55"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-question-and-answer-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bookmark-o\"></i>Aday Soru/Cevap Listeleri</a>  </li></ul>", "Aday Soru | Cevap Listeleri", "la la-bookmark-o", "candidate-question-and-answer-lists" },
                    { new Guid("be60616b-b777-4186-914e-a2fbb5c7d0bf"), "", "Tanımlamalar", "la la-lock", "navlink dropdown-toggle" },
                    { new Guid("c2473b11-2d73-45e0-ae74-273163514dcc"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['transfer-requested-posination-name']\" routerLinkActive=\"router-link-active\"><i class=\"la la-exchange-alt\"></i> Talep Edilen Pozisyon Adı Aktar</a>  </li></ul>", "Talep Edilen Pozisyon Adı Aktar", "la la-exchange-alt", "transfer-requested-posination-name" },
                    { new Guid("cca5034e-2df6-4742-a5e6-b883879607ab"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['role-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-plus-circle\"></i>Rol Tanımlama</a>  </li></ul>", "Rol Tanımlama", "la la-plus-circle", "role-defination" },
                    { new Guid("da5adbb2-a176-42a1-8f46-25f1b80218ab"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-pool']\" routerLinkActive=\"router-link-active\"><i class=\"la la-box\"></i>Aday Havuzu</a>  </li></ul>", "Aday Havuzu", "la la-box", "candidate-pool" },
                    { new Guid("f1e78bc1-ea39-4819-9909-224fa97d7576"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['new-adwert-create']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-tie\"></i>Yeni İlan Oluştur</a>  </li></ul>", "Yeni İlan Oluştur", "la la-user-tie", "new-adwert-create" }
>>>>>>> MenuToUser v1.:Infrastructure/EKSystemApp.Persistence/Migrations/20231025083307_MigEmre001.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdPublishers_AdvertCreateId",
                table: "AdPublishers",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdQuestions_AdvertCreateId",
                table: "AdQuestions",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdStatuses_AdvertCreateId",
                table: "AdStatuses",
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
                name: "IX_EbaCompanies_AdvertCreateId",
                table: "EbaCompanies",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_EbaDepartments_AdvertCreateId",
                table: "EbaDepartments",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_EbaGroups_AdvertCreateId",
                table: "EbaGroups",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_EbaUnits_AdvertCreateId",
                table: "EbaUnits",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevels_AdvertCreateId",
                table: "EducationLevels",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperiencePeriods_AdvertCreateId",
                table: "ExperiencePeriods",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_ForignLanguages_AdvertCreateId",
                table: "ForignLanguages",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_AdvertCreateId",
                table: "JobCategories",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Locaitons_AdvertCreateId",
                table: "Locaitons",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_MillitaryStatuses_AdvertCreateId",
                table: "MillitaryStatuses",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AdvertCreateId",
                table: "Organizations",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_AdvertCreateId",
                table: "Positions",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionTypes_AdvertCreateId",
                table: "PositionTypes",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillAndExpertises_AdvertCreateId",
                table: "SkillAndExpertises",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTypes_AdvertCreateId",
                table: "TaskTypes",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkModels_AdvertCreateId",
                table: "WorkModels",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTypes_AdvertCreateId",
                table: "WorkTypes",
                column: "AdvertCreateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdPublishers");

            migrationBuilder.DropTable(
                name: "AdQuestions");

            migrationBuilder.DropTable(
                name: "AdStatuses");

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
                name: "ForignLanguages");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Locaitons");

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
                name: "SkillAndExpertises");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "WorkModels");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AdvertCreates");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
