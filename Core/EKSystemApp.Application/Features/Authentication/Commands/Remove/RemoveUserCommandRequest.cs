using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Commands.Remove
{
    public class RemoveUserCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public RemoveUserCommandRequest(Guid id)
        {
            Id = id;
        }
    }
}
