using MediatR;

namespace EKSystemApp.Application.Features.Categories.Commands
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public Guid Id { get; set; }
        public string? Defination { get; set; }
    }
}
