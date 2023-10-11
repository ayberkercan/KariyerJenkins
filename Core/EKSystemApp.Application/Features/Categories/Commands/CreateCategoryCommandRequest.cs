using EKSystemApp.Application.DTO.Categories.Create;
using MediatR;

namespace EKSystemApp.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandRequest : IRequest<CreatedCategoryDto>
    {
        public string? Defination { get; set; }
    }
}
