using MediatR;
namespace Application.Features.Products.GetById;

public record GetProductByIdQuery(Guid ProductId) : IRequest<ProductResponse>;

public record ProductResponse(
   string Name, string Description, decimal Price, int StockQuantity, string Category, string Brand, string Sku, string Manufacturer, DateTime ManufactureDate, DateTime? ExpiryDate);