using AutoMapper;
using EKSystemApp.Application.DTO.Menus.List;
using EKSystemApp.Application.Features.Menus.Queries;
using EKSystemApp.Application.Interfaces.IUser;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Handlers.List
{
    public class GetMenuQueryHandler : IRequestHandler<GetMenuQueryRequest,ICollection<MenuListDto>>
    {
      
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public GetMenuQueryHandler(IMapper mapper, IUserRepository userRepository )
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }
        public async Task<ICollection<MenuListDto>> Handle(GetMenuQueryRequest request, CancellationToken cancellationToken)
        {

            var data = await this.userRepository.GetUserToMenu(request.Id);
            return this.mapper.Map<ICollection<MenuListDto>>(data);
        }
    }
}
