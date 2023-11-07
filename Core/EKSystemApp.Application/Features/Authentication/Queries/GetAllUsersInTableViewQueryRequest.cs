using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.Authorization.User;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Queries
{
    public class GetAllUsersInTableViewQueryRequest : IRequest<ICollection<UsersDetailsDto>>
    {
        public string role { get; set; }
        public string organization { get; set; }
        public GetAllUsersInTableViewQueryRequest(string role, string organization)
        {
            this.role = role;
            this.organization = organization;
        }
    }
}
