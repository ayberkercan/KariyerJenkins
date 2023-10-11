using AutoMapper;
using EKSystemApp.Application.DTO.Categories.Create;
using EKSystemApp.Application.DTO.Categories.List;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.CategoriesProfileMap
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoriesListDto>().ReverseMap();
            this.CreateMap<Category, CreatedCategoryDto>().ReverseMap();
        }
    }
}
