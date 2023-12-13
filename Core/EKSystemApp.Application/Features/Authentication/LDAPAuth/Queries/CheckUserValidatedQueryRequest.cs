using EKSystemApp.Application.DTO.Authorization.LDAPAuth;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.LDAPAuth.Queries
{
    public class CheckUserValidatedQueryRequest : IRequest<AuthApiResponseDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ValidationError { get; set; }

        public CheckUserValidatedQueryRequest(string Email, string Password, string ValidationError)
        {
            this.Email = Email;
            this.Password = Password;
            this.ValidationError = ValidationError;
        }
    }
}
