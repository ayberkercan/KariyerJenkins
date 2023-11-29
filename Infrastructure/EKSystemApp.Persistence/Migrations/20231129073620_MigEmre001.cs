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
                    AdPublisherKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdPublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdPublishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertCreates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkDefination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriotNumberId = table.Column<int>(type: "int", nullable: true),
                    AdvertNumberId = table.Column<int>(type: "int", nullable: true),
                    AdvertPublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EbaProcessId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Defination = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
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
                name: "SavedFiltersOfApprovedCandidateList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BackedUpCaption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CandidateStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicenseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguageLevelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencedProfessionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencedDepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceTotalRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertNumberId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedFiltersOfApprovedCandidateList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvertAdQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdQuestionKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdQuestionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerContentDefination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertAdQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertAdQuestions_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvertForeignLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForeignLanguageKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForeignLanguageLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertForeignLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertForeignLanguages_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvertSkillAndExpertises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillAndExpertiseKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillAndExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertSkillAndExpertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertSkillAndExpertises_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvertStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdvertStatusKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertStatuses_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EducationLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationLevelKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ExperiencePeriodKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperiencePeriodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logos_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MillitaryStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MillitaryStatusKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MillitaryStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    OrganizationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    PositionKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    PositionTypeKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkCategoryKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertCreateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkCategories_AdvertCreates_AdvertCreateId",
                        column: x => x.AdvertCreateId,
                        principalTable: "AdvertCreates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkModelKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    WorkTypeKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Product",
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
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyKey",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompaniesKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyKey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyKey_Companies_Id",
                        column: x => x.Id,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvertAdQuestionAnswerContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdvertAdQuestionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AnswerContentKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerContentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertAdQuestionAnswerContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvertAdQuestionAnswerContent_AdvertAdQuestions_AdvertAdQuestionsId",
                        column: x => x.AdvertAdQuestionsId,
                        principalTable: "AdvertAdQuestions",
                        principalColumn: "Id");
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
                    { new Guid("0eaef156-399c-454f-96a3-a06803f957e9"), "Holding" },
                    { new Guid("1f2090c8-4fac-4af2-94c7-08e3f4b96ead"), "D&R" },
                    { new Guid("561ded5b-e45f-492f-8426-ee630930b920"), "D&R Market" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "HtmlTag", "Name", "RouterIcon", "RouterLink" },
                values: new object[,]
                {
                    { new Guid("051744b7-1d70-4127-ab55-fcd8b161fc1e"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['blog-headline-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-newspaper\"></i> Blog Manşet Yönetimi </a>  </li></ul>", "Blog Manşet Yönetimi", "la la-newspaper", "blog-headline-manager" },
                    { new Guid("0b321748-0483-4e6c-b80e-f1c16fff61e1"), "", "Portal | Ana Sayfa İçerik Yönetimi", "", "" },
                    { new Guid("0e794dbf-c765-46db-9b42-acd0ef38faff"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['role-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-plus-circle\"></i>Rol Tanımlama</a>  </li></ul>", "Rol Tanımlama", "la la-plus-circle", "role-defination" },
                    { new Guid("21027404-76a6-4900-bf8f-340e75d6c653"), "", "Raporlar", "la la-file-alt", "report" },
                    { new Guid("25459172-4497-40f5-b7b4-a96b38cab584"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwert-question-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-question\"></i> İlan Soru Tanımlama</a>  </li></ul>", "İlan Soru Tanımlama", "la la-question", "adwert-question-defination" },
                    { new Guid("369b5eaa-0e48-4245-a0e7-5c0231e982cc"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['logo-import-screen']\" routerLinkActive=\"router-link-active\"><i class=\"la la-cloud-upload-alt\"></i>Logo Yükleme Ekranı</a>  </li></ul>", "Logo Yükleme Ekranı", "la la-cloud-upload-alt", "logo-import-screen" },
                    { new Guid("390569c0-e07b-4232-96ac-7e383c0e64dc"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['dashboard']\" routerLinkActive=\"router-link-active\"> <i class=\"la la-home\"></i> Admin Kariyer Giriş</a>  </li></ul>", "Admin Kariyer | Giriş", "la la-home", "dashboard" },
                    { new Guid("4229b758-b2cb-4758-8ee1-cdef8ca6dcb1"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-step-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-list\"></i>İş Adımları Yönetimi </a>  </li></ul>", "İş Adımları Yönetimi", "la la-list", "work-step-manager" },
                    { new Guid("5337afce-696c-4afb-a4d7-b589de23dc75"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-comment-o\"></i>Mail/Mesaj Yönetimi</a>  </li></ul>", "Mail | Mesaj Yönetimi", "la la-comment-o", "mail-message-manager" },
                    { new Guid("54d1031d-0b9e-49c3-9add-240b3b280c4f"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['auth-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-plus\"></i>Yetki Tanımlama </a>  </li></ul>", "Yetki Tanımlama", "la la-user-plus", "auth-defination" },
                    { new Guid("6122a6bf-fa2b-4a83-b95e-768ceeb9a613"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-category-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-boxes\"></i>İş Kategori Yönetimi </a>  </li></ul>", "İş Kategorileri Yönetimi", "la la-boxes", "work-category-manager" },
                    { new Guid("74410b9a-f7e9-4e20-8daf-3f9e8f16127c"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['transfer-requested-posination-name']\" routerLinkActive=\"router-link-active\"><i class=\"la la-exchange-alt\"></i> Talep Edilen Pozisyon Adı Aktar</a>  </li></ul>", "Talep Edilen Pozisyon Adı Aktar", "la la-exchange-alt", "transfer-requested-posination-name" },
                    { new Guid("7c5cdc22-f023-422f-9991-30617ca146a3"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['new-adwert-create']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-tie\"></i>Yeni İlan Oluştur</a>  </li></ul>", "Yeni İlan Oluştur", "la la-user-tie", "new-adwert-create" },
                    { new Guid("8507bae5-2688-4e73-922a-f5e0721ef0a9"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwerts']\" routerLinkActive=\"router-link-active\"><i class=\"la la-paper-plane\"></i>İlanlar</a>  </li></ul>", "İlanlar", "la la-paper-plane", "adwerts" },
                    { new Guid("8ed3bdcd-4b6f-4a42-8854-2b881334ad30"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-template']\" routerLinkActive=\"router-link-active\"><i class=\"la la-sign-out\"></i>Mail/Mesaj Şablonu</a>   </li></ul>", "Mail | Mesaj Şablonu ", "la la-sign-out", "mail-message-template " },
                    { new Guid("a07ca50d-e837-4135-ade1-e6b9f8ea7039"), "", "Kullanıcı Ayarları", " ", " " },
                    { new Guid("d9e3601b-a70b-4a4d-8eeb-5e7c3d68c596"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['on-front-adwert']\" routerLinkActive=\"router-link-active\"><i class=\"la la-briefcase\"></i> Öne Çıkan İlanlar </a>  </li></ul>", "Öne Çıkan İlanlar", "la la-briefcase", "on-front-adwert" },
                    { new Guid("de27b679-ea10-4047-82d8-2a71dc325662"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-pool']\" routerLinkActive=\"router-link-active\"><i class=\"la la-box\"></i>Aday Havuzu</a>  </li></ul>", "Aday Havuzu", "la la-box", "candidate-pool" },
                    { new Guid("e1a6a84a-6dc9-486b-9ba5-212954c81c5f"), "", "Tanımlamalar", "la la-lock", "navlink dropdown-toggle" },
                    { new Guid("e37364df-9102-49b0-9e00-aa555461ff4f"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-files']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bell\"></i>Aday Dosyaları</a>  </li></ul>", "Aday Dosyaları", "la la-bell", "candidate-files" },
                    { new Guid("e891949c-1fb2-471d-9db7-a315b74ec358"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['skills-and-experties']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-alt\"></i>Yetenek ve Uzmanlıklar</a>  </li></ul>", "Yetenek ve Uzmanlıklar", "la la-user-alt", "skills-and-experties" },
                    { new Guid("edccfe05-06a4-4136-97ca-38838e3a4105"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-question-and-answer-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bookmark-o\"></i>Aday Soru/Cevap Listeleri</a>  </li></ul>", "Aday Soru | Cevap Listeleri", "la la-bookmark-o", "candidate-question-and-answer-lists" },
                    { new Guid("f40c13fb-d05b-4bb8-8618-ef4793298544"), "<ul class=\"navigation\" ><li><a [routerLink]=\"['application-candidate-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-file-invoice\"></i> Başvuran Aday Listesi </a>  </li></ul>", "Başvuran Aday Listeleri", "la la-file-invoice", "application-candidate-lists" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertAdQuestionAnswerContent_AdvertAdQuestionsId",
                table: "AdvertAdQuestionAnswerContent",
                column: "AdvertAdQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertAdQuestions_AdvertCreateId",
                table: "AdvertAdQuestions",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertForeignLanguages_AdvertCreateId",
                table: "AdvertForeignLanguages",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertSkillAndExpertises_AdvertCreateId",
                table: "AdvertSkillAndExpertises",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatuses_AdvertCreateId",
                table: "AdvertStatuses",
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
                name: "IX_Brands_AdvertCreateId",
                table: "Brands",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AdvertCreateId",
                table: "Departments",
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
                name: "IX_Groups_AdvertCreateId",
                table: "Groups",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_AdvertCreateId",
                table: "Locations",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Logos_AdvertCreateId",
                table: "Logos",
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
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_AdvertCreateId",
                table: "Units",
                column: "AdvertCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCategories_AdvertCreateId",
                table: "WorkCategories",
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
                name: "AdvertAdQuestionAnswerContent");

            migrationBuilder.DropTable(
                name: "AdvertForeignLanguages");

            migrationBuilder.DropTable(
                name: "AdvertSkillAndExpertises");

            migrationBuilder.DropTable(
                name: "AdvertStatuses");

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
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CompanyKey");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EducationLevels");

            migrationBuilder.DropTable(
                name: "ExperiencePeriods");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Logos");

            migrationBuilder.DropTable(
                name: "MillitaryStatuses");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "PositionTypes");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "SavedFiltersOfApprovedCandidateList");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "WorkCategories");

            migrationBuilder.DropTable(
                name: "WorkModels");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropTable(
                name: "AdvertAdQuestions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "AdvertCreates");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
