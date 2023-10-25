using EKSystemApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EKSystemApp.Persistence.Configurations.AppMenus
{
    public class MenuConfigurations : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {


            builder.HasData(
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Admin Kariyer | Giriş",
                  RouterLink = "dashboard",
                  RouterIcon = "la la-home"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yeni İlan Oluştur",
                  RouterLink= "new-adwert-create",
                  RouterIcon = "la la-user-tie"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlanlar",
                  RouterLink = "adwerts",
                  RouterIcon = "la la-paper-plane"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Öne Çıkan İlanlar",
                  RouterLink = "on-front-adwert",
                  RouterIcon = "la la-briefcase"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Başvuran Aday Listeleri",
                  RouterLink = "application-candidate-lists",
                  RouterIcon = "la la-file-invoice"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Soru | Cevap Listeleri",
                  RouterLink = "candidate-question-and-answer-lists",
                  RouterIcon = "la la-bookmark-o"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Havuzu",
                  RouterLink = "candidate-pool",
                  RouterIcon = "la la-box"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Yönetimi",
                  RouterLink = "mail-message-manager",
                  RouterIcon = "la la-comment-o"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Dosyaları",
                  RouterLink = "candidate-files",
                  RouterIcon = "la la-bell"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Tanımlamalar",
                  RouterLink = "navlink dropdown-toggle",
                  RouterIcon = "la la-lock"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetenek ve Uzmanlıklar",
                  RouterLink = "skills-and-experties",
                  RouterIcon = "la la-user-alt"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Şablonu ",
                  RouterLink = "mail-message-template ",
                  RouterIcon = "la la-sign-out"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Logo Yükleme Ekranı",
                  RouterLink = "logo-import-screen",
                  RouterIcon = "la la-cloud-upload-alt"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlan Soru Tanımlama",
                  RouterLink = "adwert-question-defination",
                  RouterIcon = "la la-question"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Talep Edilen Pozisyon Adı Aktar",
                  RouterLink = "transfer-requested-posination-name",
                  RouterIcon = "la la-exchange-alt"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Portal | Ana Sayfa İçerik Yönetimi",
                  RouterLink = "",
                  RouterIcon = ""
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Blog Manşet Yönetimi",
                  RouterLink = "blog-headline-manager",
                  RouterIcon = "la la-newspaper"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Adımları Yönetimi",
                  RouterLink = "work-step-manager",
                  RouterIcon = "la la-list"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Kategorileri Yönetimi",
                  RouterLink = "work-category-manager",
                  RouterIcon = "la la-boxes"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Raporlar",
                  RouterLink = "report",
                  RouterIcon = "la la-file-alt"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Kullanıcı Ayarları",
                  RouterLink = " ",
                  RouterIcon = " "
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetki Tanımlama",
                  RouterLink = "auth-defination",
                  RouterIcon = "la la-user-plus"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Rol Tanımlama",
                  RouterLink = "role-defination",
                  RouterIcon = "la la-plus-circle"
              }
              );
        }
    }
}
