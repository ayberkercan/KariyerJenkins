using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EKSystemApp.Application.DTO.Jwt;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.PermissonList;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace EKSystemApp.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(CheckUserResponseDto dto)
        {
            var claims = new List<Claim>();

            if (!string.IsNullOrWhiteSpace(dto.Role))
                claims.Add(new Claim("Id", dto.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Role, dto.Role!));
            foreach (var item in dto.Menus!)
            {
                var claimMenu = new[]
               {
                   new Claim("Menus", new Claim("MenuName",item.Name).ToString()),
                   new Claim("Menus", new Claim("RouterLink",item.RouterLink).ToString()),
                   new Claim("Menus", new Claim("Icon",item.RouterIcon).ToString())
                };
                claims.AddRange(claimMenu);
            }

            if (dto.Role == "HumanResources")
            {
                claims.Add(new Claim("Permission", Permissions.Product.Read));
                claims.Add(new Claim("Permission", Permissions.Category.Read));
            };
            if (dto.Role == "Administrators")
            {
                claims.Add(new Claim("Permission", Permissions.Product.Read));
                claims.Add(new Claim("Permission", Permissions.Category.Read));
                claims.Add(new Claim("Permission", Permissions.Product.Create));
                claims.Add(new Claim("Permission", Permissions.Category.Create));
                claims.Add(new Claim("Permission", Permissions.Product.Update));
                claims.Add(new Claim("Permission", Permissions.Category.Update));
            }
            if (dto.Role == "SystemAdministrators")
            {
                claims.Add(new Claim("Permission", Permissions.Product.Read));
                claims.Add(new Claim("Permission", Permissions.Category.Read));
                claims.Add(new Claim("Permission", Permissions.Product.Create));
                claims.Add(new Claim("Permission", Permissions.Category.Create));
                claims.Add(new Claim("Permission", Permissions.Product.Update));
                claims.Add(new Claim("Permission", Permissions.Category.Update));
                claims.Add(new Claim("Permission", Permissions.Product.Delete));
                claims.Add(new Claim("Permission", Permissions.Category.Delete));
            }
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));

            if (!string.IsNullOrWhiteSpace(dto.UserName))
                claims.Add(new Claim("UserName", dto.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
            var signinCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: JwtTokenDefaults.ValidIssuer,
                audience: JwtTokenDefaults.ValidAudience,
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expireDate,
                signingCredentials: signinCredentials
                );

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            return new TokenResponseDto(tokenHandler.WriteToken(token), expireDate, claims);
        }

    }

}
