using AutoMapper;
using EKSystemApp.Application.DTO.MailMessage;
using EKSystemApp.Application.Features.MailMessage.Commands.Create;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.MailMesaj;
using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Handlers
{
    public class CreateMailMessageCommanHandler : IRequestHandler<CreateMailMessageCommandRequest, MailMessageDto>
    {
        private readonly IGenericRepository<MailMessageTemplate> repository;
        private readonly IMapper mapper;

        public CreateMailMessageCommanHandler(IGenericRepository<MailMessageTemplate> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<MailMessageDto> Handle(CreateMailMessageCommandRequest request, CancellationToken cancellationToken)
        {
            var mailMessage = new MailMessageTemplate
            {
                MessageContent = request.MessageContent,
                MessageScope = request.MessageScope,
                MessageSubject = request.MessageSubject,
                OpenClosed = request.OpenClosed,
                AppUserId = request.AppUserId
            };
            var result = await this.repository.CreateAsync(mailMessage);
            return this.mapper.Map<MailMessageDto>(mailMessage);
        }
    }
}
