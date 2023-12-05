using AutoMapper;
using EKSystemApp.Application.Features.Menus.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Application.Interfaces.IUser;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Menus.Handlers.List
{
    public class GetMenusQueryHandler : IRequestHandler<GetMenusQueryRequest, ICollection<Menu>>
    {
        private readonly IGenericRepository<Menu> repository;
        private readonly IUserRepository userRepository;
        private readonly IMapper _mapper;
        public GetMenusQueryHandler(IGenericRepository<Menu> repository, IMapper mapper, IUserRepository userRepository)
        {
            this.repository = repository;
            _mapper = mapper;
            this.userRepository = userRepository;
        }
        public async Task<ICollection<Menu>> Handle(GetMenusQueryRequest request, CancellationToken cancellationToken)
        {
            var itemList = await this.userRepository.GetAllMenus();
            return this._mapper.Map<ICollection<Menu>>(itemList);
        }
    }
}
