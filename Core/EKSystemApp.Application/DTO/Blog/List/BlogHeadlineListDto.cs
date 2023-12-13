namespace EKSystemApp.Application.DTO.Blog.List
{
    public class BlogHeadlineDto
    {
        public Guid Id { get; set; }
        public string BlogTitle { get; set; }
        public string PublicationPage { get; set; }
        public DateTime PublicationEndDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string BlogPublicStatu { get; set; }
        public string HeadlinePublicStatu { get; set; }
        public string LinkHeadline { get; set; }
    }
}
