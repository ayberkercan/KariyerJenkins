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
                  RouterIcon = "la la-home",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['dashboard']\" routerLinkActive=\"router-link-active\"> <i class=\"la la-home\"></i> Admin Kariyer Giriş</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yeni İlan Oluştur",
                  RouterLink= "new-advert-create",
                  RouterIcon = "la la-user-tie",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['new-adwert-create']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-tie\"></i>Yeni İlan Oluştur</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlanlar",
                  RouterLink = "adwerts",
                  RouterIcon = "la la-paper-plane",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwerts']\" routerLinkActive=\"router-link-active\"><i class=\"la la-paper-plane\"></i>İlanlar</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Öne Çıkan İlanlar",
                  RouterLink = "on-front-adwert",
                  RouterIcon = "la la-briefcase",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['on-front-adwert']\" routerLinkActive=\"router-link-active\"><i class=\"la la-briefcase\"></i> Öne Çıkan İlanlar </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Başvuran Aday Listeleri",
                  RouterLink = "application-candidate-lists",
                  RouterIcon = "la la-file-invoice",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['application-candidate-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-file-invoice\"></i> Başvuran Aday Listesi </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Soru | Cevap Listeleri",
                  RouterLink = "candidate-question-and-answer-lists",
                  RouterIcon = "la la-bookmark-o",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-question-and-answer-lists']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bookmark-o\"></i>Aday Soru/Cevap Listeleri</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Havuzu",
                  RouterLink = "candidate-pool",
                  RouterIcon = "la la-box",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-pool']\" routerLinkActive=\"router-link-active\"><i class=\"la la-box\"></i>Aday Havuzu</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Yönetimi",
                  RouterLink = "mail-message-manager",
                  RouterIcon = "la la-comment-o",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-comment-o\"></i>Mail/Mesaj Yönetimi</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Dosyaları",
                  RouterLink = "candidate-files",
                  RouterIcon = "la la-bell",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['candidate-files']\" routerLinkActive=\"router-link-active\"><i class=\"la la-bell\"></i>Aday Dosyaları</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Tanımlamalar",
                  RouterLink = "navlink dropdown-toggle",
                  RouterIcon = "la la-lock",
                  HtmlTag = ""
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetenek ve Uzmanlıklar",
                  RouterLink = "skills-and-experties",
                  RouterIcon = "la la-user-alt",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['skills-and-experties']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-alt\"></i>Yetenek ve Uzmanlıklar</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Şablonu ",
                  RouterLink = "mail-message-template ",
                  RouterIcon = "la la-sign-out",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['mail-message-template']\" routerLinkActive=\"router-link-active\"><i class=\"la la-sign-out\"></i>Mail/Mesaj Şablonu</a>   </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Logo Yükleme Ekranı",
                  RouterLink = "logo-import-screen",
                  RouterIcon = "la la-cloud-upload-alt",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['logo-import-screen']\" routerLinkActive=\"router-link-active\"><i class=\"la la-cloud-upload-alt\"></i>Logo Yükleme Ekranı</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlan Soru Tanımlama",
                  RouterLink = "adwert-question-defination",
                  RouterIcon = "la la-question",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['adwert-question-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-question\"></i> İlan Soru Tanımlama</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Talep Edilen Pozisyon Adı Aktar",
                  RouterLink = "transfer-requested-posination-name",
                  RouterIcon = "la la-exchange-alt",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['transfer-requested-posination-name']\" routerLinkActive=\"router-link-active\"><i class=\"la la-exchange-alt\"></i> Talep Edilen Pozisyon Adı Aktar</a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Portal | Ana Sayfa İçerik Yönetimi",
                  RouterLink = "",
                  RouterIcon = "",
                  HtmlTag = ""
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Blog Manşet Yönetimi",
                  RouterLink = "blog-headline-manager",
                  RouterIcon = "la la-newspaper",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['blog-headline-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-newspaper\"></i> Blog Manşet Yönetimi </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Adımları Yönetimi",
                  RouterLink = "work-step-manager",
                  RouterIcon = "la la-list",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-step-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-list\"></i>İş Adımları Yönetimi </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Kategorileri Yönetimi",
                  RouterLink = "work-category-manager",
                  RouterIcon = "la la-boxes",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['work-category-manager']\" routerLinkActive=\"router-link-active\"><i class=\"la la-boxes\"></i>İş Kategori Yönetimi </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Raporlar",
                  RouterLink = "report",
                  RouterIcon = "la la-file-alt",
                  HtmlTag = ""
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Kullanıcı Ayarları",
                  RouterLink = " ",
                  RouterIcon = " ",
                  HtmlTag = ""
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetki Tanımlama",
                  RouterLink = "auth-defination",
                  RouterIcon = "la la-user-plus",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['auth-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-user-plus\"></i>Yetki Tanımlama </a>  </li></ul>"
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Rol Tanımlama",
                  RouterLink = "role-defination",
                  RouterIcon = "la la-plus-circle",
                  HtmlTag = "<ul class=\"navigation\" ><li><a [routerLink]=\"['role-defination']\" routerLinkActive=\"router-link-active\"><i class=\"la la-plus-circle\"></i>Rol Tanımlama</a>  </li></ul>"
              }
              );
        }
    }
}
