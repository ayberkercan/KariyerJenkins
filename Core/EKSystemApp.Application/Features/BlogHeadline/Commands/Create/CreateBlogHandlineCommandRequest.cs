using EKSystemApp.Application.DTO.Blog.Create;
using EKSystemApp.Application.DTO.Blog.List;
using MediatR;

namespace EKSystemApp.Application.Features.BlogHeadline.Commands.Create
{
    public class CreateBlogHandlineCommandRequest : IRequest<BlogHeadlineCreateDto>
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
