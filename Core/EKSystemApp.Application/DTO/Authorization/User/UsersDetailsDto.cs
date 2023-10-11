using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Application.DTO.Authorization.User
{
    public class UsersDetailsDto
    {
        public Guid Id { get; set; }
        public string Registry { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<Object> Companies { get; set; }
        public IEnumerable<Object> Menus { get; set; }
        public string Email { get; set; }
    }
}
