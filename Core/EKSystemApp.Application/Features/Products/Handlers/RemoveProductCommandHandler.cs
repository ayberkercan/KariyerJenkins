﻿using EKSystemApp.Application.Features.Products.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommandRequest>
    {
        private readonly IGenericRepository<Product> repository;

        public RemoveProductCommandHandler(IGenericRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RemoveProductCommandRequest request, CancellationToken cancellationToken)
        {
            var removeEntity = await this.repository.GetByIdAsync(request.Id);
            if (removeEntity != null)
            {
                await this.repository.Remove(removeEntity);
            }
            return Unit.Value;
        }
    }
}
