using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using Microsoft.AspNetCore.Http;

namespace EKSystemApp.Application.Interfaces.Common
{
    public interface IFileService 
    {
        public Task PostFileAsync(IFormFile fileData,Guid id);


        public Task DownloadFileById(Guid id);
    }
}
