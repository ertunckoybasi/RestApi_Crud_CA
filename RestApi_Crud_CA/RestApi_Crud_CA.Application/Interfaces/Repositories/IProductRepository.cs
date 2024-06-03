using RestApi_Crud_CA.Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllProductAsync();

    Task<Product?> GetByIdAsync(Guid id);

    void Add(Product product);

    void Update(Product product);

    void Remove(Product product);

    Task<int> RemoveProductIfNameEmpty();
}
