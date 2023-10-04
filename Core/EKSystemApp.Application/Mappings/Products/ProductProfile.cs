using AutoMapper;
using EKSystemApp.Application.DTO.Products;
using EKSystemApp.Domain.Entities;

namespace EKSystemApp.Application.Mappings.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
            this.CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}
