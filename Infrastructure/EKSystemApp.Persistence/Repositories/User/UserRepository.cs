using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EKSystemApp.Persistence.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private IElasticSearchService<UsersDetailsDto> userDetailelasticSearch;
        private IElasticSearchService<MenuListDto> menuToListElasticSearch;
        public UserRepository(ApplicationDbContext context, IElasticSearchService<UsersDetailsDto> userDetailelasticSearch, IElasticSearchService<MenuListDto> menuToListElasticSearch)
        {
            _context = context;
            this.userDetailelasticSearch = userDetailelasticSearch;
            this.menuToListElasticSearch = menuToListElasticSearch;
        }
        public async Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuListById(string role, string organization)
        {
            List<string> companies = new List<string>();
            var userCompany = organization.Split(",")[0];
            companies.Add(userCompany);
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
                    foreach (var companyUser in companies)
                    {
                        var administrator = await _context.AppUsers
                     .Include(p => p.AppRoles)
                     .Include(p => p.AppUserCompanies
                     .Where(p => p.Company.CompanyName == companyUser)
                     .Where(p => p.AppUser.AppRoles.Name == role || p.AppUser.AppRoles.Name == "HumanResources"))
                     .ThenInclude(p => p.Company)
                     .Include(p => p.AppUserMenus)
                     .ThenInclude(p => p.Menu)
                     .OrderByDescending(d => d)
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
                            if (item.Item8.Count() > 0)
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
                        }
                    }
                   
                    return userDetail;

                case "HumanResources":
                    foreach (var companyUser in companies)
                    {
                        var administrator = await _context.AppUsers
                     .Include(p => p.AppRoles)
                     .Include(p => p.AppUserCompanies
                     .Where(p => p.Company.CompanyName == companyUser)
                     .Where(p => p.AppUser.AppRoles.Name == role))
                     .ThenInclude(p => p.Company)
                     .Include(p => p.AppUserMenus)
                     .ThenInclude(p => p.Menu)
                     .OrderByDescending(d => d)
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
                            if (item.Item8.Count() > 0)
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
                        }
                    }
                    return userDetail;
            }
            return userDetail;
        }
        public async Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuList()
        {
            await this.menuToListElasticSearch.ChekIndex("Users");
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
            await this.userDetailelasticSearch.InsertBulkDocuments("Users", userDetail);
            return userDetail;
        }
        public async Task<ICollection<MenuListDto>> GetUserToMenu(Guid id)
        {
            await this.menuToListElasticSearch.ChekIndex("MenuList");
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
            await this.menuToListElasticSearch.InsertBulkDocuments("MenuList", menuToUser);
            return menuToUser;
        }
        public async Task<ICollection<CompaniesListDto>> GetUserToCompaniesList(Guid id)
        {
            var organization = await _context
                                            .AppUserCompany
                                            .Include(p => p.Company)
                                            .Include(p => p.AppUser)
                                            .Where(p => p.AppUserId == id)
                                            .ToListAsync();
            List<CompaniesListDto> organizastionList = new List<CompaniesListDto>();
            foreach (var item in organization)
            {
                var dto = new CompaniesListDto
                {
                    CompanyName = item.Company.CompanyName,
                };
                organizastionList.Add(dto);
            }
            return organizastionList;
        }
    }
}