using EKSystemApp.Application.DTO.Jwt;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace EKSystemApp.Application.Features.Authentication.Handlers
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IGenericRepository<AppUser> userRepository;
        private readonly IGenericRepository<AppRole> roleRepository;
        private readonly SignInManager<AppUser> signInManager;

        public CheckUserQueryHandler(IGenericRepository<AppUser> userRepository, IGenericRepository<AppRole> roleRepository, SignInManager<AppUser> signInManager)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.signInManager = signInManager;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var isUser = (await this.userRepository.GetByFilterAsync(x => x.UserName == request.UserName))!;
            if (isUser == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.IsExist = true;
                dto.UserName = isUser.UserName;
                dto.Role = (await this.roleRepository.GetByFilterAsync(x => x.Id == isUser.AppRoleId))?.Name;
                dto.Id = isUser.Id;
            }
            return dto;
        }
    }
}
