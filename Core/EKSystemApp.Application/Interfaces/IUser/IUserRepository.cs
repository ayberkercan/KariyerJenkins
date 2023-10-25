using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Interfaces.IUser
{
    public interface IUserRepository
    {
        List<Menu> GetUserToMenu(Guid id);
        Task<ICollection<UsersDetailsDto>> GetUserRoleAndMenuList();
    }
}
