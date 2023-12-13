using EKSystemApp.Application.DTO.File;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EKSystemApp.Application.Interfaces.Common
{
    public interface IFileConverterService 
    {
        Task<Base64Response> ConvertToBase64(IFormFile file);
        Task<Base64Response> ConvertToFile(Base64Request request);
    }
}
