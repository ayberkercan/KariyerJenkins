using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User.Update;
using EKSystemApp.Application.Features.Authentication.Commands.Update;
using EKSystemApp.Application.Features.Authentication.Handlers.RemoveHandlers;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.Update
{
    public class UpdateUserQueryHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserDto>
    {
        private readonly IGenericRepository<AppUser> repository;
        private readonly IGenericRepository<Menu> menuRepository;
        private readonly IGenericRepository<AppUserMenu> appUserMenuRepository;
        private readonly IMapper mapper;
        public UpdateUserQueryHandler(
            IGenericRepository<AppUser> repository,
            IMapper mapper,
            IGenericRepository<Menu> menuRepository,
            IGenericRepository<AppUserMenu> appUserMenuRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.menuRepository = menuRepository;
            this.appUserMenuRepository = appUserMenuRepository;
        }
        public async Task<UpdateUserDto> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var getUser = await this.repository.GetByIdAsync(request.Id);
            var getUserMenus = await this.appUserMenuRepository.GetByFilterAsync(p=>p.AppUserId == request.Id);
            foreach (var item in request.Menus)
            {
                if(getUserMenus.MenuId != Guid.Empty)
                {
                    //getUserMenus.MenuId = item; 
                }
            }
            if (getUser != null)
            {
                getUser.FirstName = request.FirstName;
                getUser.UserName = request.UserName;
                getUser.LastName = request.LastName;
                getUser.Email = request.Email;
                getUser.Registry = request.Registry;
                getUser.AppRoleId = request.RoleId;
                await this.repository.UpdateAsync(getUser);
            }

            return mapper.Map<UpdateUserDto>(getUser);
        }
    }
}
