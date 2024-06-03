using MediatR;
using RestApi_Crud_CA.Domain.Entities;

namespace Application.Features.GetAll;

public record GetAllProductQuery : IRequest<List<Product>>;