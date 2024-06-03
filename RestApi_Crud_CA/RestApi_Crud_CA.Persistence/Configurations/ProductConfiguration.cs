using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApi_Crud_CA.Domain.Entities;

namespace RestApi_Crud_CA.Persistence.Configurations
{
    internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            // Tablo ismi belirleme (varsayılan olarak class ismi kullanılır)
            builder.ToTable("Products");

            // Primary key belirleme
            builder.HasKey(p => p.Id);

            // Id alanının özellikleri
            builder.Property(p => p.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            // Name alanının özellikleri
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // Description alanının özellikleri
            builder.Property(p => p.Description)
                   .HasMaxLength(500);

            // Price alanının özellikleri
            builder.Property(p => p.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            // StockQuantity alanının özellikleri
            builder.Property(p => p.StockQuantity)
                   .IsRequired();

            // Category alanının özellikleri
            builder.Property(p => p.Category)
                   .IsRequired()
                   .HasMaxLength(50);

            // Brand alanının özellikleri
            builder.Property(p => p.Brand)
                   .HasMaxLength(50);

            // SKU alanının özellikleri
            builder.Property(p => p.SKU)
                   .HasMaxLength(50);

            // Manufacturer alanının özellikleri
            builder.Property(p => p.Manufacturer)
                   .HasMaxLength(100);

            // ManufactureDate alanının özellikleri
            builder.Property(p => p.ManufactureDate)
                   .IsRequired();

            // ExpiryDate alanının özellikleri
            builder.Property(p => p.ExpiryDate)
                   .IsRequired(false);

        }
    }
}
