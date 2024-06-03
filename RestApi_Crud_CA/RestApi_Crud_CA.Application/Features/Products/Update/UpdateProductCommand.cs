using Application.Common.Models;
using MediatR;

namespace Application.Features.Products.Update;


public record UpdateProductCommand(
Guid Id,
  string Name,
  string Description,
  decimal Price,
  int StockQuantity,
  string Category,
  string Brand,
  string SKU,
  string Manufacturer,
  DateTime ManufactureDate,
  DateTime? ExpiryDate = null
) : IRequest<Result>;

