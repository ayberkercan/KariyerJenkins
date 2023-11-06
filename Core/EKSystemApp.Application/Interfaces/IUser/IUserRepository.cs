using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Interfaces.IUser
{
    public interface IUserRepository
    {
        Task<ICollection<MenuListDto>> GetUserToMenu(Guid id);
        Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuListById(string role);
        Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuList();
    }
}
