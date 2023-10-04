using System.Security.Claims;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Persistence.Context;
using EKSystemApp.Persistence.DbInitiliazers;
using IdentityModel;
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
                Registry="12345",
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
            await context.SaveChangesAsync();

        }
    }
}
