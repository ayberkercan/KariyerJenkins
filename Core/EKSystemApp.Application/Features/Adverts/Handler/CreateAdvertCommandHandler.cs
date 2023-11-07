using AutoMapper;
using EKSystemApp.Application.DTO.Advert.Create;
using EKSystemApp.Application.Features.Adverts.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Domain.Entities.Admin.Eba;
using EKSystemApp.Domain.Entities.Admin.NewAdvertCreated;
using MediatR;

namespace EKSystemApp.Application.Features.Adverts.Handler
{
    public class CreateAdvertCommandHandler : IRequestHandler<NewAdvertCreateCommandRequest, CreateAdvertDto>
    {
        private readonly IGenericRepository<AdvertCreate> repository;
        private readonly IMapper mapper;
        private readonly IGenericRepository<Position> position;

        public CreateAdvertCommandHandler(IGenericRepository<AdvertCreate> repository,
            IGenericRepository<Position> position,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.position = position;
        }

        public async Task<CreateAdvertDto> Handle(NewAdvertCreateCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.CreateAsync(new AdvertCreate
            {
                WorkDefination = request.WorkDefination,
                PublicQuality = request.PublicQuality,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Logo = request.Logo,
            });
            foreach (var item in request.Positions)
            {

                var positions = new Position
                {
                    AdvertCreateId = data.Id,
                    Id = Guid.Parse(item.ToString()!),
                };
                await position.CreateAsync(positions);
            }
            return this.mapper.Map<CreateAdvertDto>(data);
        }
    }
}
