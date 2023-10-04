using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Interfaces.IUser
{
    public interface IUserRepository
    {
        Task<ICollection<UsersDetailsDto>> GetUserRoleList();
    }
}
