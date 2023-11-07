using AutoMapper;
using EKSystemApp.Application.DTO.Authorization.User.Update;
using EKSystemApp.Application.Features.Authentication.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Authentication.Handlers.Update
{
    public class UpdateUserQueryHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserDto>
    {
        private readonly IGenericRepository<AppUser> repository;
        private readonly IMapper mapper;
        public UpdateUserQueryHandler(IGenericRepository<AppUser> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<UpdateUserDto> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var getUser = await this.repository.GetByIdAsync(request.Id);
            if (getUser != null)
            {
                getUser.FirstName = request.FirstName;
                getUser.UserName = request.UserName;
                getUser.LastName = request.LastName;
                getUser.Email = request.Email;
                getUser.Registry = request.Registry;
                getUser.AppRoleId = request.RoleId;
                //getUser.AppUserCompanies = request.AppUserCompanies;
                //getUser.AppUserMenus = request.AppUserMenus;
                await this.repository.UpdateAsync(getUser);
            }
         
            return mapper.Map<UpdateUserDto>(getUser);
        }
    }
}
