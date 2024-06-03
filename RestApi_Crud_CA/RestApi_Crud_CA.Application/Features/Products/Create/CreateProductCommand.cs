using Application.Common.Models;
using MediatR;

namespace Application.Features.Products.Create;


public record CreateProductCommand(
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


