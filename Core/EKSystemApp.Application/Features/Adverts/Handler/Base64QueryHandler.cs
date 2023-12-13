using AutoMapper;
using EKSystemApp.Application.DTO.Advert.List;
using EKSystemApp.Application.DTO.Eba.EbaPosition;
using EKSystemApp.Application.DTO.Eba.TMP;
using EKSystemApp.Application.DTO.File;
using EKSystemApp.Application.Features.Adverts.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.Common;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.File;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class Base64QueryHandler : IRequestHandler<Base64QueryRequest, FormFilesDto>
    {
        private readonly IGenericRepository<FormFiles> genericRepository;
        private readonly IFileConverterService fileConverterService;
        private readonly IMapper mapper;

        public Base64QueryHandler(IGenericRepository<FormFiles> genericRepository, IFileConverterService fileConverterService, IMapper mapper)
        {
            this.genericRepository = genericRepository;
            this.fileConverterService = fileConverterService;
            this.mapper = mapper;
        }

        public async Task<FormFilesDto> Handle(Base64QueryRequest request, CancellationToken cancellationToken)
        {
            var convertedFile = fileConverterService.ConvertToBase64(request.File);
            
            var data = new FormFiles
            {
                Id = new Guid(),
                FileName = convertedFile.Result.FileName,
                FileData = Convert.ToBase64String(convertedFile.Result.FileBytes),
                CreateDate = DateTime.Now,
                IsDeleted = false,
                Owner = "Melih"
            };

            #region SaveToDb
            genericRepository.CreateAsync(data);
            #endregion

            return mapper.Map<FormFilesDto>(data);
        }
    }
}
