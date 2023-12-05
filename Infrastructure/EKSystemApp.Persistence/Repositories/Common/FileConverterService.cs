using EKSystemApp.Application.DTO.File;
using EKSystemApp.Application.Interfaces.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace EKSystemApp.Persistence.Repositories.Common
{
    public class FileConverterService : IFileConverterService
    {
        public async Task<Base64Response> ConvertToBase64(IFormFile file)
        {
            MemoryStream ms = new();

            file.CopyTo(ms);
            byte[] fileBytes = ms.ToArray();

            return new Base64Response { FileBytes = fileBytes, FileName = file.FileName };
        }

        public async Task<Base64Response> ConvertToFile(Base64Request request)
        {
            try
            {
                return new Base64Response()
                {
                    FileBytes = Convert.FromBase64String(request.Base64String),
                    FileName = string.IsNullOrEmpty(request.FileName) ? "converted_file" : request.FileName
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya dönüştürme sırasında bir hata oluştu: {ex.Message}");
            }
        }
    }
}
