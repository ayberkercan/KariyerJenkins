using EKSystemApp.Domain.Common;
using System.Security.Claims;

namespace EKSystemApp.Application.DTO.Jwt
{
    public class CheckUserResponseDto : BaseEntity
    {
        public string? UserName { get; set; }
        public string? Role { get; set; }
        public bool IsExist { get; set; }
    }
}

