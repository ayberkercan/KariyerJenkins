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
        public string HeadlinePublicStatü { get; set; }
        public string LinkHeadline { get; set; }
    }
}
