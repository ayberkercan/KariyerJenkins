using EKSystemApp.Application.DTO.Company.List;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Domain.Common;

namespace EKSystemApp.Application.DTO.Jwt
{
    public class CheckUserResponseDto : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public bool IsExist { get; set; }
        public ICollection<MenuListDto> Menus { get; set; }
        public ICollection<CompaniesListDto> Companies { get; set; }
    }
}

