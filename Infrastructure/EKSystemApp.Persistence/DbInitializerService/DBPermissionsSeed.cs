using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.PermissonList;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EKSystemApp.Persistence.DbInitializerService
{
    public static class DBPermissionsSeed
    {
        public static async Task Seed(RoleManager<AppRole> roleManager)
        {
            var superAdmin = await roleManager.RoleExistsAsync("SystemAdministrators");
            var administrators = await roleManager.RoleExistsAsync("Administrators");
            var humanResources = await roleManager.RoleExistsAsync("HumanResources");

            if (!humanResources)
            {
                //await roleManager.CreateAsync(new AppRole() { Name = "HumanResources" });
                var basicRole = (await roleManager.FindByNameAsync("HumanResources"))!;
                await AddReadPermission(basicRole, roleManager);
            }

            if (!administrators)
            {
                //await roleManager.CreateAsync(new AppRole() { Name = "Administrators" });
                var basicRole = (await roleManager.FindByNameAsync("Administrators"))!;
                await AddReadPermission(basicRole, roleManager);
                await AddUpdateAndCreatePermission(basicRole, roleManager);
            }

            if (!superAdmin)
            {
               // await roleManager.CreateAsync(new AppRole() { Name = "SystemAdministrators" });
                var basicRole = (await roleManager.FindByNameAsync("SystemAdministrators"))!;
                await AddReadPermission(basicRole, roleManager);
                await AddUpdateAndCreatePermission(basicRole, roleManager);
                await AddDeletePermission(basicRole, roleManager);
            }
        }
        public static async Task AddReadPermission(AppRole role, RoleManager<AppRole> roleManager)
        {
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Product.Read));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Category.Read));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.AuthDefination.Read));
        }

        public static async Task AddUpdateAndCreatePermission(AppRole role, RoleManager<AppRole> roleManager)
        {
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Product.Create));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Category.Create));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.AuthDefination.Create));

            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Product.Update));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Category.Update));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.AuthDefination.Update));
        }
        public static async Task AddDeletePermission(AppRole role, RoleManager<AppRole> roleManager)
        {
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Product.Delete));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.Category.Delete));
            await roleManager.AddClaimAsync(role, new Claim("Permission", Permissions.AuthDefination.Delete));
        }

        public static async Task AddPermissionClaim(this RoleManager<AppRole> roleManager, AppRole role, string module)
        {
            var allClaims = await roleManager.GetClaimsAsync(role);
            var allPermissions = Permissions.GeneratePermissionsForModule(module);
            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))
                {
                    await roleManager.AddClaimAsync(role, new Claim("Permission", permission));
                }
            }
        }
    }
}
