using EKSystemApp.Domain.Common;

namespace EKSystemApp.Domain.Entities.Admin.Blog
{
    public class BlogHeadlineManager : BaseEntity
    {
        public string BlogTitle { get; set; }
        public string PublicationPage { get; set; }
        public DateTime PublicationEndDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string BlogPublicStatu { get; set; }
        public string HeadlinePublicStatu { get; set; }
        public string LinkHeadline { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
