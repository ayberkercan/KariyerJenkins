using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Persistence.Context;
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

        public List<Menu> GetUserToMenu(Guid id)
        {
            var userMenu = _context.AppUserMenus
                            .Where(p => p.AppUserId == id)
                            .Select(p =>p.Menu).ToList();
            return userMenu;
        }
    }
}
