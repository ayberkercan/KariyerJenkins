using AutoMapper;
using EKSystemApp.Application.DTO.File;
using EKSystemApp.Domain.Entities.File;

namespace EKSystemApp.Application.Mappings.FileMap
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            this.CreateMap<FormFiles, FormFilesDto>().ReverseMap();
        }
    }
}
