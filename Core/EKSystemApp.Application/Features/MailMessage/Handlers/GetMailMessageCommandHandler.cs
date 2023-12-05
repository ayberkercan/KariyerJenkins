using AutoMapper;
using EKSystemApp.Application.DTO.MailMessage;
using EKSystemApp.Application.Features.MailMessage.Queries;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.MailMesaj;
using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Handlers
{
    public class GetMailMessageCommandHandler : IRequestHandler<GetMailMessageQueryRequest, ICollection<MailMessageDto>>
    {
        private readonly IGenericRepository<MailMessageTemplate> repository;
        private readonly IMapper mapper;

        public GetMailMessageCommandHandler(IGenericRepository<MailMessageTemplate> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ICollection<MailMessageDto>> Handle(GetMailMessageQueryRequest request, CancellationToken cancellationToken)
        {
            var mailMessage = await this.repository.GetAllAsync();
            return this.mapper.Map<ICollection<MailMessageDto>>(mailMessage);
        }
    }
}
