using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Interfaces.IUser
{
    public interface IUserRepository
    {
        Task<ICollection<Menu>> GetAllMenus();
        List<Menu> AppUserMenuGuidNull(Guid id);
        List<Items> GetAllMenu(Guid id); 
        Task<ICollection<MenuListDto>> GetUserToMenu(Guid id);
        Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuListById(string role, string organization);
        Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuList();
        Task<ICollection<CompaniesListDto>> GetUserToCompaniesList(Guid id);
    }
}
