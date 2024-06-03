
using RestApi_Crud_CA.Domain.Entities;
using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWork;
using MediatR;
using Application.Common.Models;


namespace Application.Features.Products.Update;

internal sealed class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Result>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateProductCommandHandler(
        IProductRepository productRepository,
        IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = request.Id,
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


        _productRepository.Update(product);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result > 0) return Result.Success();
        else return Result.Failure("Product could not be Updated!");

    }
}