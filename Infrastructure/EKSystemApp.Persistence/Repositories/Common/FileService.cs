using EKSystemApp.Application.Interfaces.Common;
using EKSystemApp.Domain.Entities.Admin.AdminBaseEntity;
using EKSystemApp.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace EKSystemApp.Persistence.Repositories.Common
{
    public class FileService : IFileService
    {
        private readonly ApplicationDbContext context;

        public FileService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DownloadFileById(Guid Id)
        {
            try
            {
                var file = this.context.Logos.Where(x => x.Id == Id).FirstOrDefaultAsync();

                var content = new System.IO.MemoryStream(file.Result.FileData);
                var path = Path.Combine(
                   Directory.GetCurrentDirectory(), "FileDownloaded",
                   file.Result.FileName);

                await CopyStream(content, path);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task CopyStream(Stream stream, string downloadPath)
        {
            using (var fileStream = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
            {
                await stream.CopyToAsync(fileStream);
            }
        }

        public async Task PostFileAsync(IFormFile fileData, Guid id)
        {
            try
            {
                var fileDetails = new Logo()
                {
                    Id = id,
                };
                using (var stream = new MemoryStream())
                {
                    fileData.CopyTo(stream);
                    fileDetails.FileData = stream.ToArray();
                }
                var result = this.context.Logos.Add(fileDetails);
                await this.context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
