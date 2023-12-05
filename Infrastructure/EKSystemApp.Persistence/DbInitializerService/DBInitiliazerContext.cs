using System.Security.Claims;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Persistence.Context;
using EKSystemApp.Persistence.DbInitiliazers;
using IdentityModel;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace EKSystemApp.Persistence.DbInitializerService
{
    public class DBInitiliazerContext : IDbInitiliazerContext
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly ApplicationDbContext context;

        public DBInitiliazerContext(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.context = context;
        }
        public async Task Initialize(ApplicationDbContext context, IConfiguration configurations)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            await this.roleManager.CreateAsync(new AppRole { Name = "SystemAdministrators" });
            await this.roleManager.CreateAsync(new AppRole { Name = "Administrators" });
            await this.roleManager.CreateAsync(new AppRole { Name = "HumanResources" });

            var roleId = this.roleManager.Roles.Where(p => p.Name == "SystemAdministrators").Select(p => p.Id).FirstOrDefault();
            var user = new AppUser
            {
                AccessFailedCount = 0,
                Registry = "12345",
                Email = configurations.GetSection("Application:defaultSystemAdministratorEmail").Value!,
                EmailConfirmed = false,
                LockoutEnabled = true,
                NormalizedEmail = "ismailemre.karaloglu@turkuvazyayin.com.tr",
                NormalizedUserName = configurations.GetSection("Application:defaultSystemAdministratorUserName").Value,
                TwoFactorEnabled = false,
                UserName = configurations.GetSection("Application:defaultSystemAdministratorUserName").Value!,
                FirstName = configurations.GetSection("Application:defaultSystemAdministratorFirstName").Value!,
                LastName = configurations.GetSection("Application:defaultSystemAdministratorLastName").Value!,
                AppRoleId = roleId,
            };
            IdentityResult result = this.userManager.CreateAsync(user, (configurations.GetSection("Application:defaultSystemAdministratorPassword").Value)!).Result;
            if (result.Succeeded)
            {
                var adminUser = (await this.userManager.FindByNameAsync(user!.UserName!))!;
                var data = await this.userManager.AddToRoleAsync(adminUser, "SystemAdministrators");
                var claims = new List<Claim> {
                    new Claim(type: JwtClaimTypes.Name, value: "SystemAdministrators"),
                };
                await this.userManager.AddClaimsAsync(adminUser, claims);
            }
            await context.AppUserCompany.AddAsync(new AppUserCompany
            {
                AppUserId = user.Id,
                CompanyId = context.Companies.Where(x => x.CompanyName == "Holding").First().Id
            });
            await context.AppUserCompany.AddAsync(new AppUserCompany
            {
                AppUserId = user.Id,
                CompanyId = context.Companies.Where(x => x.CompanyName == "D&R").First().Id
            });
            await context.AppUserCompany.AddAsync(new AppUserCompany
            {
                AppUserId = user.Id,
                CompanyId = context.Companies.Where(x => x.CompanyName == "D&R Market").First().Id
            });

            #region Organizations Keys
            var holdingId = this.context.Companies.Where(p => p.CompanyName == "Holding").First().Id;
            var drId = this.context.Companies.Where(p => p.CompanyName == "D&R").First().Id;
            var drMarketId = this.context.Companies.Where(p => p.CompanyName == "D&R Market").First().Id;

            #region Company - Key

            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50006"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50005"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50004"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50003"
            });

            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50002"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "50001"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "44000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "34000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "33010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "33000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "32000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "30010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "30000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "29001"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "28010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "28000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "26000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "24010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "24000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "21000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "20020"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "20010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "20000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "18001"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "18000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "17020"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "17010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "17000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "16000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "15000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14210"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14200"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14100"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14022"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14021"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14016"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14014"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14011"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14008"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14007"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14006"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14005"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14004"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14003"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14002"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14001"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "14000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13200"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13120"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13110"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13100"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13020"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "13000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12320"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12310"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12300"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12200"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12100"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "12000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "11020"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "11010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "11000"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10050"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10040"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10030"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10020"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10010"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = holdingId,
                CompaniesKey = "10000"
            });

            #endregion

            #region D&R - Key
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = drId,
                CompaniesKey = "40000"
            });
            #endregion

            #region D&R Mağaza - Key
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = drMarketId,
                CompaniesKey = "40002"
            });
            await context.CompanyKeys.AddAsync(new CompanyKey
            {
                Id = Guid.NewGuid(),
                CompanyId = drMarketId,
                CompaniesKey = "40001"
            });
            #endregion

            #endregion

            await context.Menus.AddAsync(new Menu
            {
                KeyId = 1,
                Label = "Admin Kariyer | Giriş",
                Icon = "la la-home",
                RouterLink= "dashboard"
            });

            var newAdvert = new Menu
            {
                KeyId = 2,
                Label = "Yeni İlan Oluştur",
                Icon = "la la-user-tie",
                RouterLink = "new-advert-create"
            };
            await context.Menus.AddAsync(newAdvert);
            await context.Items.AddAsync(new Items
            {
                KeyId = 1,
                MenuId = newAdvert.Id, 
                Menu = newAdvert,
                Label = "İlanlar",
                Icon= "la la-paper-plane",
                RouterLink = "adverts"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 2,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Öne Çıkan İlanlar",
                Icon = "la la-briefcase",
                RouterLink = "featured-advert"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 3,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Başvuran Aday Listeleri",
                Icon = "la la-file-invoice",
                RouterLink = "application-candidate-lists"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 4,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Aday Soru | Cevap Listeleri",
                Icon = "la la-bookmark-o",
                RouterLink = "candidate-question-and-answer-lists"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 5,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Aday Havuzu",
                Icon = "la la-box",
                RouterLink = "candidate-pool"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 6,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Mail | Mesaj Yönetimi",
                Icon = "la la-comment-o",
                RouterLink = "mail-message-manager"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 7,
                MenuId = newAdvert.Id,
                Menu = newAdvert,
                Label = "Aday Dosyaları",
                Icon = "la la-bell",
                RouterLink = "candidate-files"
            });
            var defination = new Menu
            {
                KeyId = 3,
                Label = "Tanımlamalar",
                Icon = "la la-lock",
                RouterLink = ""
            };
            await context.Menus.AddAsync(defination);
           
            await context.Items.AddAsync(new Items
            {
                KeyId = 1,
                MenuId = defination.Id,
                Menu = defination,
                Label = "Yetenek ve Uzmanlıklar",
                Icon = "la la-user-alt",
                RouterLink = "skills-and-experties"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 2,
                MenuId = defination.Id,
                Menu = defination,
                Label = "Mail | Mesaj Şablonu",
                Icon = "la la-sign-out",
                RouterLink = "mail-message-template"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 3,
                MenuId = defination.Id,
                Menu = defination,
                Label = "Logo Yükleme Ekranı",
                Icon = "la la-cloud-upload-alt",
                RouterLink = "logo-import-screen"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 4,
                MenuId = defination.Id,
                Menu = defination,
                Label = "İlan Soru Tanımlama",
                Icon = "la la-question",
                RouterLink = "advert-question-defination"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 5,
                MenuId = defination.Id,
                Menu = defination,
                Label = "Talep Edilen Pozisyon Adı Aktar",
                Icon = "la la-exchange-alt",
                RouterLink = "transfer-requested-posination-name"
            });

            var positions = new Menu
            {
                KeyId = 4,
                Label = "Portal | Ana Sayfa İçerik Yönetimi",
                Icon = "",
                RouterLink = ""
            };
            await context.Menus.AddAsync(positions);
            await context.Items.AddAsync(new Items
            {
                KeyId = 1,
                MenuId = positions.Id,
                Menu = positions,
                Label = "Blog Manşet Yönetimi",
                Icon = "la la-newspaper",
                RouterLink = "blog-headline-manager"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 2,
                MenuId = positions.Id,
                Menu = positions,
                Label = "İş Adımları Yönetimi",
                Icon = "la la-list",
                RouterLink = "work-step-manager"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 3,
                MenuId = positions.Id,
                Menu = positions,
                Label = "İş Kategorileri Yönetimi",
                Icon = "la la-boxes",
                RouterLink = "work-category-manager"
            });
            var reports = new Menu
            {
                KeyId = 5,
                Label = "Raporlar",
                Icon = "la la-file-alt",
                RouterLink = "report"
            };
            await context.Menus.AddAsync(reports);
            var userOptions = new Menu
            {
                KeyId = 6,
                Label = "Kullanıcı Ayarları",
                Icon = "",
                RouterLink = ""
            };
            await context.Menus.AddAsync(userOptions);
            await context.Items.AddAsync(new Items
            {
                KeyId = 1,
                MenuId = userOptions.Id,
                Menu = userOptions,
                Label = "Yetki Tanımlama",
                Icon = "la la-user-plus",
                RouterLink = "auth-defination"
            });
            await context.Items.AddAsync(new Items
            {
                KeyId = 2,
                MenuId = userOptions.Id,
                Menu = userOptions,
                Label = "Rol Tanımlama",
                Icon = "la la-plus-circle",
                RouterLink = "role-defination"
            });
            await context.SaveChangesAsync();

        }
    }
}
