using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EKSystemApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigEmre002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdPublisher_AdvertCreates_AdvertCreateId",
                table: "AdPublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_AdQuestion_AdvertCreates_AdvertCreateId",
                table: "AdQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AdStatus_AdvertCreates_AdvertCreateId",
                table: "AdStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_AdvertCreates_AdvertCreateId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLevel_AdvertCreates_AdvertCreateId",
                table: "EducationLevel");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperiencePeriod_AdvertCreates_AdvertCreateId",
                table: "ExperiencePeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_ForignLanguage_AdvertCreates_AdvertCreateId",
                table: "ForignLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategory_AdvertCreates_AdvertCreateId",
                table: "JobCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Locaiton_AdvertCreates_AdvertCreateId",
                table: "Locaiton");

            migrationBuilder.DropForeignKey(
                name: "FK_MillitaryStatus_AdvertCreates_AdvertCreateId",
                table: "MillitaryStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionType_AdvertCreates_AdvertCreateId",
                table: "PositionType");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkModel_AdvertCreates_AdvertCreateId",
                table: "WorkModel");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkType_AdvertCreates_AdvertCreateId",
                table: "WorkType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkType",
                table: "WorkType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkModel",
                table: "WorkModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionType",
                table: "PositionType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MillitaryStatus",
                table: "MillitaryStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaiton",
                table: "Locaiton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategory",
                table: "JobCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForignLanguage",
                table: "ForignLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperiencePeriod",
                table: "ExperiencePeriod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationLevel",
                table: "EducationLevel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdStatus",
                table: "AdStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdQuestion",
                table: "AdQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdPublisher",
                table: "AdPublisher");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("856a3fb4-922e-4f4d-92d7-f965b0c4342a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bac46ec2-11a6-484c-805f-9cdf9900c358"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("eac378b9-312a-4974-8e8c-fa140314160f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("117f7500-e367-4eec-a55c-28134d5fa49d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2095beef-9d77-47bd-8718-c363acfdf7d2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("25d90f0d-ea04-4a47-88cd-9b52fca2958f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3cd66111-8c25-4275-896f-2a2f596405c4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3d24b7f7-3188-42f0-af1c-a3a0ef0734ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3e1660c5-058f-4e7f-b1e4-499348f9abbe"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("3ff8a19c-6303-447e-a185-9fe53811c153"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4cf2a632-7b45-47d3-ade1-e6a19946f202"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5b0d4e40-6cc5-4c7f-9e93-dac8adce6504"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6636ef45-c411-4e74-ab01-b8f724cc3d05"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("79f64bf6-692f-4d15-8fb5-38039dce0966"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7fc137da-adf9-4e2b-b377-804d374138ec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("89b7a8e1-3f57-438c-b77f-d35706ac92fb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("915b3b75-a1f9-44df-ae33-2cf6b0d4faec"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("962755f3-b71a-4a5e-aba7-486a8eb16949"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a68691f6-eb80-4b3c-b92e-eff52ebad9a3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ad579a30-8c82-4de9-89b4-6beaa1509339"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cec6cc5e-75c7-4ce6-8bfb-6e496322cfe3"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d198f429-4d0b-4dcd-8cad-f6f9c61b6b2a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("de98edee-a1eb-4303-ac5c-2d44bd286b83"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f84b5c08-2f67-4e89-86d6-36761ffa339e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fae7ddd4-c868-4e98-bf23-d5ea0ffd2422"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fb1d5121-3280-4a81-8cfd-59462e6d6611"));

            migrationBuilder.RenameTable(
                name: "WorkType",
                newName: "WorkTypes");

            migrationBuilder.RenameTable(
                name: "WorkModel",
                newName: "WorkModels");

            migrationBuilder.RenameTable(
                name: "PositionType",
                newName: "PositionTypes");

            migrationBuilder.RenameTable(
                name: "MillitaryStatus",
                newName: "MillitaryStatuses");

            migrationBuilder.RenameTable(
                name: "Locaiton",
                newName: "Locaitons");

            migrationBuilder.RenameTable(
                name: "JobCategory",
                newName: "JobCategories");

            migrationBuilder.RenameTable(
                name: "ForignLanguage",
                newName: "ForignLanguages");

            migrationBuilder.RenameTable(
                name: "ExperiencePeriod",
                newName: "ExperiencePeriods");

            migrationBuilder.RenameTable(
                name: "EducationLevel",
                newName: "EducationLevels");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "AdStatus",
                newName: "AdStatuses");

            migrationBuilder.RenameTable(
                name: "AdQuestion",
                newName: "AdQuestions");

            migrationBuilder.RenameTable(
                name: "AdPublisher",
                newName: "AdPublishers");

            migrationBuilder.RenameIndex(
                name: "IX_WorkType_AdvertCreateId",
                table: "WorkTypes",
                newName: "IX_WorkTypes_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkModel_AdvertCreateId",
                table: "WorkModels",
                newName: "IX_WorkModels_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_PositionType_AdvertCreateId",
                table: "PositionTypes",
                newName: "IX_PositionTypes_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_MillitaryStatus_AdvertCreateId",
                table: "MillitaryStatuses",
                newName: "IX_MillitaryStatuses_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_Locaiton_AdvertCreateId",
                table: "Locaitons",
                newName: "IX_Locaitons_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategory_AdvertCreateId",
                table: "JobCategories",
                newName: "IX_JobCategories_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_ForignLanguage_AdvertCreateId",
                table: "ForignLanguages",
                newName: "IX_ForignLanguages_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperiencePeriod_AdvertCreateId",
                table: "ExperiencePeriods",
                newName: "IX_ExperiencePeriods_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLevel_AdvertCreateId",
                table: "EducationLevels",
                newName: "IX_EducationLevels_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_AdvertCreateId",
                table: "Departments",
                newName: "IX_Departments_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdStatus_AdvertCreateId",
                table: "AdStatuses",
                newName: "IX_AdStatuses_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdQuestion_AdvertCreateId",
                table: "AdQuestions",
                newName: "IX_AdQuestions_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdPublisher_AdvertCreateId",
                table: "AdPublishers",
                newName: "IX_AdPublishers_AdvertCreateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkTypes",
                table: "WorkTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkModels",
                table: "WorkModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionTypes",
                table: "PositionTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MillitaryStatuses",
                table: "MillitaryStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaitons",
                table: "Locaitons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategories",
                table: "JobCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForignLanguages",
                table: "ForignLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperiencePeriods",
                table: "ExperiencePeriods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdStatuses",
                table: "AdStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdQuestions",
                table: "AdQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdPublishers",
                table: "AdPublishers",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName" },
                values: new object[,]
                {
                    { new Guid("4e3ce612-5149-49c3-a5de-b88c62c2d78e"), "D&R" },
                    { new Guid("7daea36b-e4e2-4e24-8380-889e73f8198e"), "D&R Market" },
                    { new Guid("dbf0ca33-e2ed-45d7-ba57-a8d534ae2808"), "Holding" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0594faab-3eaf-4aa0-829d-00aa4dde1208"), "Admin Kariyer | Giriş" },
                    { new Guid("083a7db0-aa69-4dc3-86e1-6c4f3d1ca78a"), "Öne Çıkan İlanlar" },
                    { new Guid("22328637-8d5f-4792-b36e-56ddfad2246a"), "Logo Yükleme Ekranı" },
                    { new Guid("26a5f97a-adec-4f88-bf13-f4ce3e64a4e2"), "İlanlar" },
                    { new Guid("27dc78e8-2fcf-4730-a89e-6a0fee5420ef"), "Talep Edilen Pozisyon Adı Aktar" },
                    { new Guid("35d33471-f196-4928-88bf-83d80f4c154d"), "İş Kategorileri Yönetimi" },
                    { new Guid("421c73b2-d3cf-4528-a1ca-9c3d7c66ae84"), "Blog Manşet Yönetimi" },
                    { new Guid("5cc06eea-8194-44bb-a974-5f20f79da705"), "İş Adımları Yönetimi" },
                    { new Guid("71062471-7451-43e6-ab6f-7c0b8663cb75"), "Yeni İlan Oluştur" },
                    { new Guid("7b2bc0bb-969b-429c-85fc-87c363311b3e"), "Portal | Ana Sayfa İçerik Yönetimi" },
                    { new Guid("8201eaa1-c4b5-42dd-bb62-f67033aa2e00"), "Aday Havuzu" },
                    { new Guid("89e9f841-f194-4784-bde8-640fa053835b"), "Kullanıcı Ayarları" },
                    { new Guid("9339b004-b6c3-4780-960c-2aad02907fee"), "Mail | Mesaj Yönetimi" },
                    { new Guid("93bf44ea-6c88-419a-bc7f-47474a8b5f1e"), "Mail | Mesaj Şablonu " },
                    { new Guid("99adc244-e4ed-4bc3-900a-f4d68f494a97"), "Aday Dosyaları" },
                    { new Guid("a21398f4-1439-4e2d-8434-9162bb5e7b77"), "Tanımlamalar" },
                    { new Guid("afbfcb4a-17e5-4c39-bf37-c90f870afaad"), "Raporlar" },
                    { new Guid("ba4c5bfb-7660-41cf-bd82-3bdced04b7ef"), "Yetenek ve Uzmanlıklar" },
                    { new Guid("bc98c383-13b1-41f7-a5dc-af32583cbb5b"), "İlan Soru Tanımlama" },
                    { new Guid("c48c235b-29b5-46e4-8eb4-d52f389f8a39"), "Aday Soru | Cevap Listeleri" },
                    { new Guid("ccd9142d-5541-4abe-b0c1-959c1f4d3802"), "Rol Tanımlama" },
                    { new Guid("d2d2ac16-2bb5-41d4-a3cc-6d50dfc10247"), "Yetki Tanımlama" },
                    { new Guid("d78413dc-a51f-44e5-a144-9b6e2b41984a"), "Başvuran Aday Listeleri" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillAndExpertises_AdvertCreateId",
                table: "SkillAndExpertises",
                column: "AdvertCreateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdPublishers_AdvertCreates_AdvertCreateId",
                table: "AdPublishers",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdQuestions_AdvertCreates_AdvertCreateId",
                table: "AdQuestions",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdStatuses_AdvertCreates_AdvertCreateId",
                table: "AdStatuses",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AdvertCreates_AdvertCreateId",
                table: "Departments",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLevels_AdvertCreates_AdvertCreateId",
                table: "EducationLevels",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperiencePeriods_AdvertCreates_AdvertCreateId",
                table: "ExperiencePeriods",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForignLanguages_AdvertCreates_AdvertCreateId",
                table: "ForignLanguages",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategories_AdvertCreates_AdvertCreateId",
                table: "JobCategories",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locaitons_AdvertCreates_AdvertCreateId",
                table: "Locaitons",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MillitaryStatuses_AdvertCreates_AdvertCreateId",
                table: "MillitaryStatuses",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionTypes_AdvertCreates_AdvertCreateId",
                table: "PositionTypes",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkModels_AdvertCreates_AdvertCreateId",
                table: "WorkModels",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTypes_AdvertCreates_AdvertCreateId",
                table: "WorkTypes",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdPublishers_AdvertCreates_AdvertCreateId",
                table: "AdPublishers");

            migrationBuilder.DropForeignKey(
                name: "FK_AdQuestions_AdvertCreates_AdvertCreateId",
                table: "AdQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_AdStatuses_AdvertCreates_AdvertCreateId",
                table: "AdStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AdvertCreates_AdvertCreateId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationLevels_AdvertCreates_AdvertCreateId",
                table: "EducationLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_ExperiencePeriods_AdvertCreates_AdvertCreateId",
                table: "ExperiencePeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_ForignLanguages_AdvertCreates_AdvertCreateId",
                table: "ForignLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategories_AdvertCreates_AdvertCreateId",
                table: "JobCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Locaitons_AdvertCreates_AdvertCreateId",
                table: "Locaitons");

            migrationBuilder.DropForeignKey(
                name: "FK_MillitaryStatuses_AdvertCreates_AdvertCreateId",
                table: "MillitaryStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionTypes_AdvertCreates_AdvertCreateId",
                table: "PositionTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkModels_AdvertCreates_AdvertCreateId",
                table: "WorkModels");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkTypes_AdvertCreates_AdvertCreateId",
                table: "WorkTypes");

            migrationBuilder.DropTable(
                name: "Ebas");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "SkillAndExpertises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkTypes",
                table: "WorkTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkModels",
                table: "WorkModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PositionTypes",
                table: "PositionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MillitaryStatuses",
                table: "MillitaryStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locaitons",
                table: "Locaitons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategories",
                table: "JobCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForignLanguages",
                table: "ForignLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExperiencePeriods",
                table: "ExperiencePeriods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdStatuses",
                table: "AdStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdQuestions",
                table: "AdQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdPublishers",
                table: "AdPublishers");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4e3ce612-5149-49c3-a5de-b88c62c2d78e"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7daea36b-e4e2-4e24-8380-889e73f8198e"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("dbf0ca33-e2ed-45d7-ba57-a8d534ae2808"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0594faab-3eaf-4aa0-829d-00aa4dde1208"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("083a7db0-aa69-4dc3-86e1-6c4f3d1ca78a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("22328637-8d5f-4792-b36e-56ddfad2246a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("26a5f97a-adec-4f88-bf13-f4ce3e64a4e2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("27dc78e8-2fcf-4730-a89e-6a0fee5420ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("35d33471-f196-4928-88bf-83d80f4c154d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("421c73b2-d3cf-4528-a1ca-9c3d7c66ae84"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5cc06eea-8194-44bb-a974-5f20f79da705"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("71062471-7451-43e6-ab6f-7c0b8663cb75"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7b2bc0bb-969b-429c-85fc-87c363311b3e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8201eaa1-c4b5-42dd-bb62-f67033aa2e00"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("89e9f841-f194-4784-bde8-640fa053835b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9339b004-b6c3-4780-960c-2aad02907fee"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("93bf44ea-6c88-419a-bc7f-47474a8b5f1e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("99adc244-e4ed-4bc3-900a-f4d68f494a97"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("a21398f4-1439-4e2d-8434-9162bb5e7b77"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("afbfcb4a-17e5-4c39-bf37-c90f870afaad"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ba4c5bfb-7660-41cf-bd82-3bdced04b7ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bc98c383-13b1-41f7-a5dc-af32583cbb5b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c48c235b-29b5-46e4-8eb4-d52f389f8a39"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ccd9142d-5541-4abe-b0c1-959c1f4d3802"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d2d2ac16-2bb5-41d4-a3cc-6d50dfc10247"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d78413dc-a51f-44e5-a144-9b6e2b41984a"));

            migrationBuilder.RenameTable(
                name: "WorkTypes",
                newName: "WorkType");

            migrationBuilder.RenameTable(
                name: "WorkModels",
                newName: "WorkModel");

            migrationBuilder.RenameTable(
                name: "PositionTypes",
                newName: "PositionType");

            migrationBuilder.RenameTable(
                name: "MillitaryStatuses",
                newName: "MillitaryStatus");

            migrationBuilder.RenameTable(
                name: "Locaitons",
                newName: "Locaiton");

            migrationBuilder.RenameTable(
                name: "JobCategories",
                newName: "JobCategory");

            migrationBuilder.RenameTable(
                name: "ForignLanguages",
                newName: "ForignLanguage");

            migrationBuilder.RenameTable(
                name: "ExperiencePeriods",
                newName: "ExperiencePeriod");

            migrationBuilder.RenameTable(
                name: "EducationLevels",
                newName: "EducationLevel");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "AdStatuses",
                newName: "AdStatus");

            migrationBuilder.RenameTable(
                name: "AdQuestions",
                newName: "AdQuestion");

            migrationBuilder.RenameTable(
                name: "AdPublishers",
                newName: "AdPublisher");

            migrationBuilder.RenameIndex(
                name: "IX_WorkTypes_AdvertCreateId",
                table: "WorkType",
                newName: "IX_WorkType_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkModels_AdvertCreateId",
                table: "WorkModel",
                newName: "IX_WorkModel_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_PositionTypes_AdvertCreateId",
                table: "PositionType",
                newName: "IX_PositionType_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_MillitaryStatuses_AdvertCreateId",
                table: "MillitaryStatus",
                newName: "IX_MillitaryStatus_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_Locaitons_AdvertCreateId",
                table: "Locaiton",
                newName: "IX_Locaiton_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategories_AdvertCreateId",
                table: "JobCategory",
                newName: "IX_JobCategory_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_ForignLanguages_AdvertCreateId",
                table: "ForignLanguage",
                newName: "IX_ForignLanguage_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_ExperiencePeriods_AdvertCreateId",
                table: "ExperiencePeriod",
                newName: "IX_ExperiencePeriod_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationLevels_AdvertCreateId",
                table: "EducationLevel",
                newName: "IX_EducationLevel_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_AdvertCreateId",
                table: "Department",
                newName: "IX_Department_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdStatuses_AdvertCreateId",
                table: "AdStatus",
                newName: "IX_AdStatus_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdQuestions_AdvertCreateId",
                table: "AdQuestion",
                newName: "IX_AdQuestion_AdvertCreateId");

            migrationBuilder.RenameIndex(
                name: "IX_AdPublishers_AdvertCreateId",
                table: "AdPublisher",
                newName: "IX_AdPublisher_AdvertCreateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkType",
                table: "WorkType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkModel",
                table: "WorkModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PositionType",
                table: "PositionType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MillitaryStatus",
                table: "MillitaryStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locaiton",
                table: "Locaiton",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategory",
                table: "JobCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForignLanguage",
                table: "ForignLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExperiencePeriod",
                table: "ExperiencePeriod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationLevel",
                table: "EducationLevel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdStatus",
                table: "AdStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdQuestion",
                table: "AdQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdPublisher",
                table: "AdPublisher",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName" },
                values: new object[,]
                {
                    { new Guid("856a3fb4-922e-4f4d-92d7-f965b0c4342a"), "Holding" },
                    { new Guid("bac46ec2-11a6-484c-805f-9cdf9900c358"), "D&R Market" },
                    { new Guid("eac378b9-312a-4974-8e8c-fa140314160f"), "D&R" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("117f7500-e367-4eec-a55c-28134d5fa49d"), "Rol Tanımlama" },
                    { new Guid("2095beef-9d77-47bd-8718-c363acfdf7d2"), "Kullanıcı Ayarları" },
                    { new Guid("25d90f0d-ea04-4a47-88cd-9b52fca2958f"), "Tanımlamalar" },
                    { new Guid("3cd66111-8c25-4275-896f-2a2f596405c4"), "Mail | Mesaj Şablonu " },
                    { new Guid("3d24b7f7-3188-42f0-af1c-a3a0ef0734ef"), "İş Adımları Yönetimi" },
                    { new Guid("3e1660c5-058f-4e7f-b1e4-499348f9abbe"), "Raporlar" },
                    { new Guid("3ff8a19c-6303-447e-a185-9fe53811c153"), "Talep Edilen Pozisyon Adı Aktar" },
                    { new Guid("4cf2a632-7b45-47d3-ade1-e6a19946f202"), "Mail | Mesaj Yönetimi" },
                    { new Guid("5b0d4e40-6cc5-4c7f-9e93-dac8adce6504"), "Aday Soru | Cevap Listeleri" },
                    { new Guid("6636ef45-c411-4e74-ab01-b8f724cc3d05"), "Blog Manşet Yönetimi" },
                    { new Guid("79f64bf6-692f-4d15-8fb5-38039dce0966"), "Admin Kariyer | Giriş" },
                    { new Guid("7fc137da-adf9-4e2b-b377-804d374138ec"), "Aday Dosyaları" },
                    { new Guid("89b7a8e1-3f57-438c-b77f-d35706ac92fb"), "Aday Havuzu" },
                    { new Guid("915b3b75-a1f9-44df-ae33-2cf6b0d4faec"), "İlan Soru Tanımlama" },
                    { new Guid("962755f3-b71a-4a5e-aba7-486a8eb16949"), "Yeni İlan Oluştur" },
                    { new Guid("a68691f6-eb80-4b3c-b92e-eff52ebad9a3"), "Portal | Ana Sayfa İçerik Yönetimi" },
                    { new Guid("ad579a30-8c82-4de9-89b4-6beaa1509339"), "Yetki Tanımlama" },
                    { new Guid("cec6cc5e-75c7-4ce6-8bfb-6e496322cfe3"), "İş Kategorileri Yönetimi" },
                    { new Guid("d198f429-4d0b-4dcd-8cad-f6f9c61b6b2a"), "Logo Yükleme Ekranı" },
                    { new Guid("de98edee-a1eb-4303-ac5c-2d44bd286b83"), "Başvuran Aday Listeleri" },
                    { new Guid("f84b5c08-2f67-4e89-86d6-36761ffa339e"), "İlanlar" },
                    { new Guid("fae7ddd4-c868-4e98-bf23-d5ea0ffd2422"), "Öne Çıkan İlanlar" },
                    { new Guid("fb1d5121-3280-4a81-8cfd-59462e6d6611"), "Yetenek ve Uzmanlıklar" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AdPublisher_AdvertCreates_AdvertCreateId",
                table: "AdPublisher",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdQuestion_AdvertCreates_AdvertCreateId",
                table: "AdQuestion",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdStatus_AdvertCreates_AdvertCreateId",
                table: "AdStatus",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_AdvertCreates_AdvertCreateId",
                table: "Department",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLevel_AdvertCreates_AdvertCreateId",
                table: "EducationLevel",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExperiencePeriod_AdvertCreates_AdvertCreateId",
                table: "ExperiencePeriod",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ForignLanguage_AdvertCreates_AdvertCreateId",
                table: "ForignLanguage",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategory_AdvertCreates_AdvertCreateId",
                table: "JobCategory",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locaiton_AdvertCreates_AdvertCreateId",
                table: "Locaiton",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MillitaryStatus_AdvertCreates_AdvertCreateId",
                table: "MillitaryStatus",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionType_AdvertCreates_AdvertCreateId",
                table: "PositionType",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkModel_AdvertCreates_AdvertCreateId",
                table: "WorkModel",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkType_AdvertCreates_AdvertCreateId",
                table: "WorkType",
                column: "AdvertCreateId",
                principalTable: "AdvertCreates",
                principalColumn: "Id");
        }
    }
}
