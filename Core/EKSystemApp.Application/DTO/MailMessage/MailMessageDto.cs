namespace EKSystemApp.Application.DTO.MailMessage
{
    public class MailMessageDto
    {
        public Guid Id { get; set; }
        public string MessageScope { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public bool OpenClosed { get; set; }
    }
}
