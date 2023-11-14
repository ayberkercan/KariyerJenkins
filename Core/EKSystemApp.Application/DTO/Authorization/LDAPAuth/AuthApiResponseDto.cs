using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Authorization.LDAPAuth
{
    public class AuthApiResponseDto
    {
        public string Result { get; set; }
        public string User { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}
