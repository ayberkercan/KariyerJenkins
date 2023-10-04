using System.Security.Claims;

namespace EKSystemApp.Application.DTO.Jwt
{
    public class TokenResponseDto
    {
        public TokenResponseDto(string token, DateTime expireDate, List<Claim> claim)
        {
            Token = token;
            ExpireDate = expireDate;
            Claim = claim;

        }

        public string Token { get; set; }

        public DateTime ExpireDate { get; set; }
        public List<Claim> Claim { get; set; }
    }
}
