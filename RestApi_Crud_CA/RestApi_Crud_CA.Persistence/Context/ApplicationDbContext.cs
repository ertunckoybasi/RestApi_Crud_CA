using Application.Interfaces.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using RestApi_Crud_CA.Domain.Entities;

namespace RestApi_Crud_CA.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {

        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
