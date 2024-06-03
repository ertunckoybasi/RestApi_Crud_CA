using Application.Common.Models;
using Application.Interfaces.Repositories;
using MediatR;

namespace Application.Features.Products.DeleteIfEmptyNames;

internal sealed class DeleteProductEmptyNamesCommandHandler(
    IProductRepository productRepository) : IRequestHandler<DeleteProductEmptyNamesCommand, Result>
{
    public async Task<Result> Handle(DeleteProductEmptyNamesCommand request, CancellationToken cancellationToken)
    {
        var result = await productRepository.RemoveProductIfNameEmpty();

        return result > 0
            ? Result.Success()
            : Result.Failure("Product could not be deleted!");
    }
}
