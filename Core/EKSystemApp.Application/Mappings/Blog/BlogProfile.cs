using AutoMapper;
using EKSystemApp.Application.DTO.Blog.Create;
using EKSystemApp.Application.DTO.Blog.List;
using EKSystemApp.Application.DTO.Categories.Create;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Domain.Entities.Admin.Blog;

namespace EKSystemApp.Application.Mappings.Blog
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            this.CreateMap<BlogHeadlineManager, BlogHeadlineDto>().ReverseMap();
            this.CreateMap<BlogHeadlineManager, BlogHeadlineCreateDto>().ReverseMap();
        }
    }
}
