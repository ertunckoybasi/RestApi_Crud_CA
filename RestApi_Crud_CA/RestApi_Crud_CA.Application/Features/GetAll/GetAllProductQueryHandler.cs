using Application.Interfaces.Repositories;
using MediatR;
using RestApi_Crud_CA.Domain.Entities;

namespace Application.Features.GetAll;

internal sealed class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, List<Product>>
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {

        var products = await _productRepository.GetAllProductAsync();
        return products;
    }
}