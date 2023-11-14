using EKSystemApp.Application.DTO.Authorization.LDAPAuth;
using EKSystemApp.Application.DTO.Authorization.Role;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
