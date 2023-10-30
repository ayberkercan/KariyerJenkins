using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Domain.Common;
using EKSystemApp.Domain.Entities;
using System.Security.Claims;

namespace EKSystemApp.Application.DTO.Jwt
{
    public class CheckUserResponseDto : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public bool IsExist { get; set; }
        public List<MenuListDto> Menus { get; set; }
    }
}

