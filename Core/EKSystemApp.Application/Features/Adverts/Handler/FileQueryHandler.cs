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
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class FileQueryHandler : IRequestHandler<FileQueryRequest, Base64Response>
    {
        private readonly IFileConverterService fileConverterService;

        public FileQueryHandler(IFileConverterService fileConverterService)
        {
            this.fileConverterService = fileConverterService;
        }

        public async Task<Base64Response> Handle(FileQueryRequest request, CancellationToken cancellationToken)
        {
            return fileConverterService.ConvertToFile(new Base64Request() { Base64String = request.Base64String, FileName = request.FileName }).Result;
        }
    }
}
