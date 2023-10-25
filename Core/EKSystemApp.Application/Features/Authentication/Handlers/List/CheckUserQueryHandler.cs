using EKSystemApp.Application.DTO.Jwt;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace EKSystemApp.Application.Features.Authentication.Handlers.List
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IGenericRepository<AppUser> userRepository;
        private readonly IGenericRepository<AppRole> roleRepository;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IUserRepository user;

        public CheckUserQueryHandler(IGenericRepository<AppUser> userRepository, IGenericRepository<AppRole> roleRepository, SignInManager<AppUser> signInManager, IUserRepository user)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.signInManager = signInManager;
            this.user = user;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var isUser = (await userRepository.GetByFilterAsync(x => x.UserName == request.UserName))!;
            if (isUser == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.IsExist = true;
                dto.UserName = isUser.UserName;
                dto.Role = (await roleRepository.GetByFilterAsync(x => x.Id == isUser.AppRoleId))?.Name;
                dto.Id = isUser.Id;
                dto.Menus = this.user.GetUserToMenu(isUser.Id);
            }
            return dto;
        }
    }
}
