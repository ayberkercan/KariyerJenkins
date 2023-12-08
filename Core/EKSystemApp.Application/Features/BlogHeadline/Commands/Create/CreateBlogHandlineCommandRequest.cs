using EKSystemApp.Application.DTO.Blog.Create;
using EKSystemApp.Application.DTO.Blog.List;
using EKSystemApp.Domain.Entities;
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
        public string HeadlinePublicStatu { get; set; }
        public string LinkHeadline { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
