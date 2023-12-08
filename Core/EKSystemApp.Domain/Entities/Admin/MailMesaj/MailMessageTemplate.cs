using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.MailMesaj
{
    public class MailMessageTemplate : BaseEntity
    {
        public string MessageScope { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public bool OpenClosed { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
