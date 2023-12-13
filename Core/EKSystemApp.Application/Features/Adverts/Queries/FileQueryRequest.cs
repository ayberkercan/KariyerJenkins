using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.File;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EKSystemApp.Application.Features.Adverts.Queries
{
    public class FileQueryRequest : IRequest<Base64Response>
    {
        public string Base64String { get; set; }
        public string FileName { get; set; }
        public FileQueryRequest(string base64String, string fileName) { this.Base64String = base64String; this.FileName = fileName; }
    }
}
