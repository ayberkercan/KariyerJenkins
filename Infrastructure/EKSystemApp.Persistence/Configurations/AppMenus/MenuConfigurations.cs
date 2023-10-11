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
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yeni İlan Oluştur",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlanlar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Öne Çıkan İlanlar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Başvuran Aday Listeleri",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Soru | Cevap Listeleri",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Havuzu",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Yönetimi",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Aday Dosyaları",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Tanımlamalar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetenek ve Uzmanlıklar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Mail | Mesaj Şablonu ",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Logo Yükleme Ekranı",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İlan Soru Tanımlama",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Talep Edilen Pozisyon Adı Aktar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Portal | Ana Sayfa İçerik Yönetimi",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Blog Manşet Yönetimi",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Adımları Yönetimi",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "İş Kategorileri Yönetimi",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Raporlar",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Kullanıcı Ayarları",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Yetki Tanımlama",
              },
              new Menu
              {
                  Id = Guid.NewGuid(),
                  Name = "Rol Tanımlama",
              }
              );
        }
    }
}
