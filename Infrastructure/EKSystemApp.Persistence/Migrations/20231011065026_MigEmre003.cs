using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EKSystemApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigEmre003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Logo",
                table: "AdvertCreates",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName" },
                values: new object[,]
                {
                    { new Guid("06efa92f-41cb-469a-983a-582d7abef858"), "D&R Market" },
                    { new Guid("5a4d05a4-a357-417b-abba-0b7948d7ece3"), "Holding" },
                    { new Guid("66b1e9ce-cc87-4711-a661-02fd2b6025a9"), "D&R" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bb1fcfa-3e4a-48ec-9619-2a91980c5035"), "Mail | Mesaj Şablonu " },
                    { new Guid("2f71624e-e967-4bd4-a97f-1a0e6efc58eb"), "Blog Manşet Yönetimi" },
                    { new Guid("34777ed8-fbec-45ce-9927-9a2193a827fa"), "Rol Tanımlama" },
                    { new Guid("4a09644d-7709-44f8-9cb6-6aa118e632de"), "İş Adımları Yönetimi" },
                    { new Guid("4dcde5f3-2616-4c21-9075-f4a19a923af0"), "Aday Havuzu" },
                    { new Guid("7b4f9e11-f4ae-45a0-90ce-fdf21505beab"), "İlan Soru Tanımlama" },
                    { new Guid("7b515d9c-72db-42b5-a08d-1a22c3d31bb8"), "Aday Dosyaları" },
                    { new Guid("80718712-49b5-4fb1-bb74-98446b9f243d"), "Yetki Tanımlama" },
                    { new Guid("82d85766-9184-4c5b-b05d-46ae72bbe3a8"), "Logo Yükleme Ekranı" },
                    { new Guid("8b247b65-5352-475a-9e99-19a0891ce26d"), "Başvuran Aday Listeleri" },
                    { new Guid("9af1e7cd-d585-47e0-9611-4041eccdb17a"), "Tanımlamalar" },
                    { new Guid("ad738fec-3215-462b-a7b4-d189e5f016c5"), "Yetenek ve Uzmanlıklar" },
                    { new Guid("aea078e4-a426-4e49-a50d-c85168132ddd"), "Raporlar" },
                    { new Guid("b0cb7a69-3b3e-4d5e-b0bf-cd00217fe343"), "Talep Edilen Pozisyon Adı Aktar" },
                    { new Guid("b28c2b90-45e0-4c5e-9e6c-6a2c062a1a7c"), "Aday Soru | Cevap Listeleri" },
                    { new Guid("b3351a39-3ba3-4972-b469-b961e8ed28d7"), "Admin Kariyer | Giriş" },
                    { new Guid("b7575648-0673-46ec-af38-488fd0440266"), "Öne Çıkan İlanlar" },
                    { new Guid("b959ea2b-ad61-47e5-ba9b-e536e41983f9"), "Kullanıcı Ayarları" },
                    { new Guid("b9e9b750-ba0a-4d7b-87c3-0e27d7255a14"), "Mail | Mesaj Yönetimi" },
                    { new Guid("cd366272-b515-4358-aed8-ed4b3953cc4d"), "İlanlar" },
                    { new Guid("f9862a97-5f8c-4cad-99e7-cc5aef0756d2"), "Portal | Ana Sayfa İçerik Yönetimi" },
                    { new Guid("fb9d0df7-2ace-43c4-92d8-123ee4e897cf"), "İş Kategorileri Yönetimi" },
                    { new Guid("fda69419-8c5f-4fd1-83d2-3c3cd35eb444"), "Yeni İlan Oluştur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("06efa92f-41cb-469a-983a-582d7abef858"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5a4d05a4-a357-417b-abba-0b7948d7ece3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("66b1e9ce-cc87-4711-a661-02fd2b6025a9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0bb1fcfa-3e4a-48ec-9619-2a91980c5035"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("2f71624e-e967-4bd4-a97f-1a0e6efc58eb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("34777ed8-fbec-45ce-9927-9a2193a827fa"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4a09644d-7709-44f8-9cb6-6aa118e632de"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4dcde5f3-2616-4c21-9075-f4a19a923af0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7b4f9e11-f4ae-45a0-90ce-fdf21505beab"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("7b515d9c-72db-42b5-a08d-1a22c3d31bb8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("80718712-49b5-4fb1-bb74-98446b9f243d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("82d85766-9184-4c5b-b05d-46ae72bbe3a8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("8b247b65-5352-475a-9e99-19a0891ce26d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9af1e7cd-d585-47e0-9611-4041eccdb17a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ad738fec-3215-462b-a7b4-d189e5f016c5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("aea078e4-a426-4e49-a50d-c85168132ddd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b0cb7a69-3b3e-4d5e-b0bf-cd00217fe343"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b28c2b90-45e0-4c5e-9e6c-6a2c062a1a7c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b3351a39-3ba3-4972-b469-b961e8ed28d7"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b7575648-0673-46ec-af38-488fd0440266"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b959ea2b-ad61-47e5-ba9b-e536e41983f9"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b9e9b750-ba0a-4d7b-87c3-0e27d7255a14"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cd366272-b515-4358-aed8-ed4b3953cc4d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f9862a97-5f8c-4cad-99e7-cc5aef0756d2"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fb9d0df7-2ace-43c4-92d8-123ee4e897cf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fda69419-8c5f-4fd1-83d2-3c3cd35eb444"));

            migrationBuilder.AlterColumn<byte>(
                name: "Logo",
                table: "AdvertCreates",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }
    }
}
