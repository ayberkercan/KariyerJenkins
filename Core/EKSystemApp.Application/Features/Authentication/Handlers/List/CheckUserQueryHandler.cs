using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Jwt;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Features.Authentication.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
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
        private readonly IUserRepository userMenu;


        public CheckUserQueryHandler(IGenericRepository<AppUser> userRepository, IGenericRepository<AppRole> roleRepository, SignInManager<AppUser> signInManager, IUserRepository userMenu)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
            this.signInManager = signInManager;
            this.userMenu = userMenu;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();

            var isUser = (await userRepository.GetByFilterAsync(x => x.UserName == request.UserName))!;
            var menus = (await userMenu.GetUserToMenu(isUser.Id));
            var company = (await userMenu.GetUserToCompaniesList(isUser.Id));

            var result = await this.signInManager.CheckPasswordSignInAsync(isUser, request.Password, false);

            if (result.Succeeded)
            {
                dto.IsExist = true;
                dto.UserName = isUser.UserName;
                dto.Role = (await roleRepository.GetByFilterAsync(x => x.Id == isUser.AppRoleId))?.Name;
                dto.Id = isUser.Id;
                dto.Menus = menus;
                dto.Companies = company;

                return dto;
            }
            else
            {
                dto.IsExist = false;
            }
            return dto;
        }
    }
}
