using Application.Common.Models;
using MediatR;

namespace Application.Features.Products.DeleteIfEmptyNames;

public record DeleteProductEmptyNamesCommand : IRequest<Result>;
