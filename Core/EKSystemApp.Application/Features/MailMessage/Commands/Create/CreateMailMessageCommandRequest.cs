using EKSystemApp.Application.DTO.MailMessage;
using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Commands.Create
{
    public class CreateMailMessageCommandRequest : IRequest<MailMessageDto>
    {
        public string MessageScope { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public bool OpenClosed { get; set; } = true;
    }
}
