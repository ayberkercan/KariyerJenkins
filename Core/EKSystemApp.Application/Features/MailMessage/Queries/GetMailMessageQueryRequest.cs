using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Application.DTO.MailMessage;
using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Queries
{
    public class GetMailMessageQueryRequest : IRequest<ICollection<MailMessageDto>>
    {
    }
}
