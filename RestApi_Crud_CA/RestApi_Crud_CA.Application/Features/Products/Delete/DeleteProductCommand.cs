using Application.Common.Models;
using MediatR;

namespace Application.Features.Products.Delete.Delete;

public record DeleteProductCommand(Guid Id) : IRequest<Result>;
