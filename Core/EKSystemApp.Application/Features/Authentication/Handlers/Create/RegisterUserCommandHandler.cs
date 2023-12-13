using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User;
using EKSystemApp.Application.DTO.Authorization.User.Create;
using EKSystemApp.Application.Features.Authentication.Commands.Register;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IElasticSearchService;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Nest;

namespace EKSystemApp.Application.Features.Authentication.Handlers.Create
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest, CreatedUserDto>
    {
        private readonly IGenericRepository<AppUser> repository;
        private readonly IGenericRepository<AppUserCompany> companyRepository;
        private readonly IGenericRepository<AppUserMenu> companyMenuRepository;
        private readonly IGenericRepository<AppUserItem> menuItemRepository;
        private readonly IUserRepository userRepository;
        private IElasticSearchService<AppUser> elasticSearch;

        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        public RegisterUserCommandHandler(
            IGenericRepository<AppUser> repository,
            IMapper mapper, UserManager<AppUser> userManager,
            IGenericRepository<AppUserCompany> companyRepository,
            IGenericRepository<AppUserMenu> companyMenuRepository,
            IUserRepository userRepository,
            IElasticSearchService<AppUser> elasticSearch, IGenericRepository<AppUserItem> menuItemRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.userManager = userManager;
            this.companyRepository = companyRepository;
            this.companyMenuRepository = companyMenuRepository;
            this.userRepository = userRepository;
            this.elasticSearch = elasticSearch;
            this.menuItemRepository = menuItemRepository;
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
                var say = Guid.Parse(menuItem.ToString()!);
                var items = this.userRepository.GetAllMenu(say);
                if (items.Count() != 0)
                {
                    foreach (var item in items)
                    {
                        var menu = new AppUserItem
                        {
                            AppUserId = data.Id,
                            ItemId = item.Id
                        };
                        await menuItemRepository.CreateAsync(menu);
                    }
                }
                var menusId = Guid.Parse(menuItem.ToString()!);
                var menus = this.userRepository.AppUserMenuGuidNull(menusId);
                if (menus.Count() != 0)
                {
                    foreach (var item in menus)
                    {
                        var menuss = new AppUserMenu
                        {
                            AppUserId = data.Id,
                            MenuId = item.Id,
                        };
                        await companyMenuRepository.CreateAsync(menuss);
                    }
                }
            }
            await this.elasticSearch.InsertDocument("appuser", data);
            return mapper.Map<CreatedUserDto>(data);
        }
    }
}
