using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.DTO.Authorization.User
{
    public class UserListDto : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Registry { get; set; } = null;
        public int? UsernameChangeLimit { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public Guid AppRoleId { get; set; }
        public AppRole AppRoles { get; set; }
        public ICollection<AppUserCompany> AppUserCompanies { get; set; }
    }
}
