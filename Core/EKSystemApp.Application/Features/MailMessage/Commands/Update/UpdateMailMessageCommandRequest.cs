using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Commands.Update
{
    
    public class UpdateMailMessageCommandRequest: IRequest
    {
        public Guid Id { get; set; }
        public string MessageScope { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public bool OpenClosed { get; set; }
    }
}
