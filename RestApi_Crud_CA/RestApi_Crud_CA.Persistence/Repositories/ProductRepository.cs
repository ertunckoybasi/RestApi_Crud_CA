using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RestApi_Crud_CA.Domain.Entities;
using RestApi_Crud_CA.Persistence.Context;

namespace Persistence.Repositories
{
    internal sealed class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Product?> GetByIdAsync(Guid id)
        {
            return _context.Products
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public Task<List<Product>> GetAllProductAsync()
        {
            return _context.Products.AsNoTracking().ToListAsync();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }

        public async Task<int> RemoveProductIfNameEmpty()
        {
            var result = await _context.Products
                .Where(x => string.IsNullOrEmpty(x.Name))
                .ExecuteDeleteAsync();

            return result;
        }

    }
}
