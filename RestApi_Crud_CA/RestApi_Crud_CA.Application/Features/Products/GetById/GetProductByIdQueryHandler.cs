using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Products.GetById;

internal sealed class GetProductByIdQueryHandler(IProductRepository productRepository) : IRequestHandler<GetProductByIdQuery, ProductResponse>
{
    public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.ProductId) ?? throw new KeyNotFoundException($"Product with ID {request.ProductId} not found.");

        var productResponse = new ProductResponse(
            product.Name,
            product.Description,
            product.Price,
            product.StockQuantity,
            product.Category,
            product.Brand,
            product.SKU,
            product.Manufacturer,
            product.ManufactureDate,
            product.ExpiryDate
        );

        return productResponse;
    }
}
