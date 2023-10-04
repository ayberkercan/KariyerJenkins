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
        public async Task<ICollection<UsersDetailsDto>> GetUserRoleList()
        {
            var data = await _context.AppUsers
              .Include(p => p.AppRoles)
              .Include(p => p.AppUserCompanies)
              .ThenInclude(p => p.Company)
              .ThenInclude(p => p.CompanyMenues)
              .ThenInclude(p => p.Menu)
              .OrderByDescending(d => d)
              .AsNoTracking()
              .Distinct()
              .ToListAsync();
            var s = data.Select(
             p => (
               p.Id,
                 p.FirstName,
                 p.LastName,
                 p.UserName,
                 p.AppRoleId,
                 p.AppRoles.Name,
                 p.AppUserCompanies.Select(p => new { p.Company.Id, p.Company.CompanyName }),
                 p.AppUserCompanies.Select(p => p.Company.CompanyMenues.Select(p => new { p.Menu.Id, p.Menu.Name })),
                 p.Email
                 ));
            List<UsersDetailsDto> userDetail = new List<UsersDetailsDto>();
            foreach (var item in s)
            {
                var users = new UsersDetailsDto
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    RoleId= item.Item5,
                    RoleName = item.Item6,
                    Companies = item.Item7,
                    Menus = item.Item8,
                    Email = item.Email
                };
                userDetail.Add(users);
            }
            return userDetail;
        }
    }
}
