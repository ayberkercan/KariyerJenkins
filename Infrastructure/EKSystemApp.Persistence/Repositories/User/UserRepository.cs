using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Persistence.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuListById(string role)
        {
            List<UsersDetailsDto> userDetail = new List<UsersDetailsDto>();
            switch (role)
            {

                case "SystemAdministrators":
                    var data = await _context.AppUsers
                         .Include(p => p.AppRoles)
                         .Include(p => p.AppUserCompanies)
                         .ThenInclude(p => p.Company)
                         .Include(p => p.AppUserMenus)
                         .ThenInclude(p => p.Menu)
                         .OrderByDescending(d => d)
                         .AsNoTracking()
                         .Distinct()
                         .ToListAsync();

                    var s = data.Select(
                     p => (
                         p.Id,
                         p.Registry,
                         p.FirstName,
                         p.LastName,
                         p.UserName,
                         p.AppRoleId,
                         p.AppRoles.Name,
                         p.AppUserCompanies.Select(p => p.Company.CompanyName),
                         p.AppUserMenus.Select(p => p.Menu.Name),
                         p.Email
                         ));
                    foreach (var item in s)
                    {
                        var users = new UsersDetailsDto
                        {
                            Id = item.Id,
                            Registry = item.Registry,
                            UserName = item.UserName,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            RoleId = item.Item6,
                            RoleName = item.Item7,
                            Companies = item.Item8,
                            Menus = item.Item9,
                            Email = item.Email
                        };
                        userDetail.Add(users);
                    }
                    return userDetail;
                case "Administrators":
                    var administrator = await _context.AppUsers
                      .Include(p => p.AppRoles)
                        .Where(p => p.AppRoles.Name == role || p.AppRoles.Name == "HumanResources")
                      .Include(p => p.AppUserCompanies)
                      .ThenInclude(p => p.Company)
                      .Include(p => p.AppUserMenus)
                      .ThenInclude(p => p.Menu)
                      .OrderByDescending(d => d)
                      .AsNoTracking()
                      .Distinct()
                      .ToListAsync();

                    var adminHuman = administrator.Select(
                     p => (
                         p.Id,
                         p.Registry,
                         p.FirstName,
                         p.LastName,
                         p.UserName,
                         p.AppRoleId,
                         p.AppRoles.Name,
                         p.AppUserCompanies.Select(p => p.Company.CompanyName),
                         p.AppUserMenus.Select(p => p.Menu.Name),
                         p.Email
                         ));
                    foreach (var item in adminHuman)
                    {
                        var users = new UsersDetailsDto
                        {
                            Id = item.Id,
                            Registry = item.Registry,
                            UserName = item.UserName,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            RoleId = item.Item6,
                            RoleName = item.Item7,
                            Companies = item.Item8,
                            Menus = item.Item9,
                            Email = item.Email
                        };
                        userDetail.Add(users);
                    }
                    return userDetail;
                case "HumanResources":
                    var humanResource = await _context.AppUsers
                    .Include(p => p.AppRoles)
                      .Where(p => p.AppRoles.Name == role)
                    .Include(p => p.AppUserCompanies)
                    .ThenInclude(p => p.Company)
                    .Include(p => p.AppUserMenus)
                    .ThenInclude(p => p.Menu)
                    .OrderByDescending(d => d)
                    .AsNoTracking()
                    .Distinct()
                    .ToListAsync();

                    var human = humanResource.Select(
                     p => (
                         p.Id,
                         p.Registry,
                         p.FirstName,
                         p.LastName,
                         p.UserName,
                         p.AppRoleId,
                         p.AppRoles.Name,
                         p.AppUserCompanies.Select(p => p.Company.CompanyName),
                         p.AppUserMenus.Select(p => p.Menu.Name),
                         p.Email
                         ));
                    foreach (var item in human)
                    {
                        var users = new UsersDetailsDto
                        {
                            Id = item.Id,
                            Registry = item.Registry,
                            UserName = item.UserName,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            RoleId = item.Item6,
                            RoleName = item.Item7,
                            Companies = item.Item8,
                            Menus = item.Item9,
                            Email = item.Email
                        };
                        userDetail.Add(users);
                    }
                    return userDetail;
            }
            return userDetail;
        }
        public async Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuList()
        {
            var data = await _context.AppUsers
              .Include(p => p.AppRoles)
              .Include(p => p.AppUserCompanies)
              .ThenInclude(p => p.Company)
              .Include(p => p.AppUserMenus)
              .ThenInclude(p => p.Menu)
              .OrderByDescending(d => d)
              .AsNoTracking()
              .Distinct()
              .ToListAsync();
            var s = data.Select(
             p => (
               p.Id,
               p.Registry,
                 p.FirstName,
                 p.LastName,
                 p.UserName,
                 p.AppRoleId,
                 p.AppRoles.Name,
                 p.AppUserCompanies.Select(p => p.Company.CompanyName),
                 p.AppUserMenus.Select(p => p.Menu.Name),
                 p.Email
                 ));

            List<UsersDetailsDto> userDetail = new List<UsersDetailsDto>();
            foreach (var item in s)
            {

                var users = new UsersDetailsDto
                {
                    Id = item.Id,
                    Registry = item.Registry,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    RoleId = item.Item6,
                    RoleName = item.Item7,
                    Companies = item.Item8,
                    Menus = item.Item9,
                    Email = item.Email
                };
                userDetail.Add(users);
            }
            return userDetail;
        }

        public async Task<ICollection<MenuListDto>> GetUserToMenu(Guid id)
        {
            var userMenu = await _context.AppUserMenus
                                        .Include(p => p.Menu)
                                        .Where(p => p.AppUserId == id)
                                        .ToListAsync();
            List<MenuListDto> menuToUser = new List<MenuListDto>();
            foreach (var item in userMenu)
            {
                var dto = new MenuListDto
                {
                    Name = item.Menu.Name,
                    RouterLink = item.Menu.RouterLink,
                    RouterIcon = item.Menu.RouterIcon,
                };
                menuToUser.Add(dto);
            }
            return menuToUser;
        }
    }
}