using EKSystemApp.Application.Features.Products.Commands;
using EKSystemApp.Application.Interfaces;
using EKSystemApp.Domain.Entities;
using MediatR;

namespace EKSystemApp.Application.Features.Products.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IGenericRepository<Product> repository;

        public UpdateProductCommandHandler(IGenericRepository<Product> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var getProduct = await this.repository.GetByIdAsync(request.Id);
            if (getProduct != null)
            {
                getProduct.Name = request.Name;
                getProduct.Price = request.Price;
                getProduct.Stock = request.Stock;
                getProduct.CategoryId = request.CategoryId;
                await this.repository.UpdateAsync(getProduct);
            }
            return Unit.Value;
        }
    }
}
