
using RestApi_Crud_CA.Domain.Entities;
using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWork;
using MediatR;
using Application.Common.Models;

namespace Application.Features.Products.Create;

internal sealed class CreateProductCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand,Result>
{
    public async Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            StockQuantity = request.StockQuantity,
            Category = request.Category,
            Brand = request.Brand,
            SKU = request.SKU,
            Manufacturer = request.Manufacturer,
            ManufactureDate = request.ManufactureDate,
            ExpiryDate = request.ExpiryDate
        };


        productRepository.Add(product);

      var result=  await unitOfWork.SaveChangesAsync(cancellationToken);
        if (result > 0) return Result.Success();
        else return Result.Failure("Product could not be created!");

    }
}