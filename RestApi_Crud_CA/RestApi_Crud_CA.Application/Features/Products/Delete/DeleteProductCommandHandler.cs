using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWork;
using MediatR;
using Application.Common.Models;

namespace Application.Features.Products.Delete.Delete;

internal sealed class DeleteProductCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteProductCommand, Result>
{

    public async Task<Result> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetByIdAsync(request.Id);

        if (product is null)
            return Result.Failure("Product could not be found!");

        productRepository.Remove(product);
        return await unitOfWork.SaveChangesAsync(cancellationToken) > 0
            ? Result.Success()
            : Result.Failure("Product could not be deleted!");
    }

}