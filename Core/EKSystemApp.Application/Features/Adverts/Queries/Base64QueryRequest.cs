using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.File;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class Base64QueryRequest : IRequest<FormFilesDto>
    {
        public IFormFile File { get; set; }
        public Base64QueryRequest(IFormFile file) { this.File = file; }
    }
}
