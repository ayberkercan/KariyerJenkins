using EKSystemApp.Application.Features.MailMessage.Commands.Update;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities.Admin.MailMesaj;
using MediatR;

namespace EKSystemApp.Application.Features.MailMessage.Handlers
{
    public class UpdateMailMessageCommandHandler : IRequestHandler<UpdateMailMessageCommandRequest>
    {
        private readonly IGenericRepository<MailMessageTemplate> repository;

        public UpdateMailMessageCommandHandler(IGenericRepository<MailMessageTemplate> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateMailMessageCommandRequest request, CancellationToken cancellationToken)
        {
            var updateEntity = await this.repository.GetByIdAsync(request.Id);
            if (updateEntity != null)
            {
                updateEntity.MessageSubject = request.MessageSubject;
                updateEntity.MessageContent = request.MessageContent;
                updateEntity.MessageScope = request.MessageScope;
                updateEntity.OpenClosed = request.OpenClosed;

                await this.repository.UpdateAsync(updateEntity);
            }
            return Unit.Value;
        }
    }
}
