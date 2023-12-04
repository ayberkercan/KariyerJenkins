using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
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

        public async Task<ICollection<Menu>> GetAllMenus()
        {
            ICollection<Menu> menuList = new List<Menu>();
            var menus = await _context.Menus.Include(p => p.Items).ToListAsync();
            foreach (var item in menus)
            {
                Menu menu = new Menu
                {
                    Id = item.Id,
                    Label = item.Label,

                };
                menuList.Add(menu);
            }
            foreach (var item in menus)
            {
                foreach (var itemMenu in item.Items)
                {
                    Menu menu = new Menu
                    {
                        Id = itemMenu.Id,
                        Label = itemMenu.Label
                    };
                    menuList.Add(menu);
                }
            }
            return menuList;
        }
        public List<Items> GetAllMenu(Guid id)
        {
            return _context.Items.Where(x => x.Id == id).ToList();
        }
        public List<Menu> AppUserMenuGuidNull(Guid id)
        {
            return _context.Menus.Where(x => x.Id == id).ToList();
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
                         p.AppUserMenus.Select(p => p.Menu.Label),
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
                             p.AppUserMenus.Select(p => p.Menu.Label),
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
                             p.AppUserMenus.Select(p => p.Menu.Label),
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
                 p.AppUserMenus.Select(p => p.Menu.Label),
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
            await this.userDetailelasticSearch.InsertBulkDocuments("users", userDetail);
            return userDetail;
        }
        public async Task<ICollection<MenuListDto>> GetUserToMenu(Guid id)
        {
            var userMenu = await _context.AppUserMenus
                                    .Include(p => p.Menu)
                                    .Include(p => p.AppUser)
                                    .ThenInclude(p => p.AppUserItems)
                                    .ThenInclude(p => p.Items)
                                    .Where(p => p.AppUserId == id)
                                    .OrderByDescending(d => d)
                                    .AsNoTracking()
                                    .Distinct()
                                    .ToListAsync();

            List<MenuListDto> menuToUser = new List<MenuListDto>();
            foreach (var item in userMenu)
            {
                var dto = new MenuListDto
                {
                    KeyId = item.Menu.KeyId,
                    Label = item.Menu.Label,
                    RouterLink = item.Menu.RouterLink,
                    Icon = item.Menu.Icon,
                };
                menuToUser.Add(dto);
            }
            foreach (var item in userMenu)
            {
                foreach (var item2 in item.AppUser.AppUserItems)
                {
                    var dto = new MenuListDto
                    {
                        KeyId = item2.Items.KeyId,
                        Label = item2.Items.Label,
                        RouterLink = item2.Items.RouterLink,
                        Icon = item2.Items.Icon
                    };
                    menuToUser.Add(dto);
                }
            }
            if (menuToUser.Count > 0)
                await this.menuToListElasticSearch.InsertBulkDocuments("menulist", menuToUser);

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