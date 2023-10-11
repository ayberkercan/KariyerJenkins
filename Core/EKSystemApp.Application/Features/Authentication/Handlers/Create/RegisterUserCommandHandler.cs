using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User.Create;
using EKSystemApp.Application.Features.Authentication.Commands.Register;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace EKSystemApp.Application.Features.Authentication.Handlers.Create
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest, CreatedUserDto>
    {
        private readonly IGenericRepository<AppUser> repository;
        private readonly IGenericRepository<AppUserCompany> companyRepository;
        private readonly IGenericRepository<AppUserMenu> companyMenuRepository;

        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        public RegisterUserCommandHandler(
            IGenericRepository<AppUser> repository,
            IMapper mapper, UserManager<AppUser> userManager,
            IGenericRepository<AppUserCompany> companyRepository,
            IGenericRepository<AppUserMenu> companyMenuRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.companyRepository = companyRepository;
            this.companyMenuRepository = companyMenuRepository;
        }
        public async Task<CreatedUserDto> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            var data = new AppUser
            {
                UserName = request.UserName,
                AppRoleId = request.RoleId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Registry = request.Registry,
            };
            IdentityResult result = await userManager.CreateAsync(data, request.Password);
            if (!result.Succeeded)
            {
                throw new ApplicationException("Kullanıcı kayıt edilirken hata meydana geldi!");
            }
            foreach (var item in request.Companies)
            {

                var companies = new AppUserCompany
                {
                    AppUserId = data.Id,
                    CompanyId = Guid.Parse(item.ToString()!),
                };
                await companyRepository.CreateAsync(companies);
            }
            foreach (var menuItem in request.Menues)
            {
                var menus = new AppUserMenu
                {
                    AppUserId = data.Id,
                    MenuId = Guid.Parse(menuItem.ToString()!),
                };
                await companyMenuRepository.CreateAsync(menus);
            }
            return mapper.Map<CreatedUserDto>(data);
        }
    }
}
