
using RestApi_Crud_CA.Domain.Abstractions;

namespace RestApi_Crud_CA.Domain.Entities;


public class Product : Entity
{

    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
        Category = string.Empty;
        Brand = string.Empty;
        SKU = string.Empty;
        Manufacturer = string.Empty;
    }


    public Product(string name, string description, decimal price, int stockQuantity, string category, string brand, string sku, string manufacturer, DateTime manufactureDate, DateTime? expiryDate)
    {
        Name = name;
        Description = description;
        Price = price;
        StockQuantity = stockQuantity;
        Category = category;
        Brand = brand;
        SKU = sku;
        Manufacturer = manufacturer;
        ManufactureDate = manufactureDate;
        ExpiryDate = expiryDate;
    }

    public required string Name { get;  set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public required string Category { get; set; }
    public required string Brand { get; set; }
    public required string SKU { get; set; }
    public required string Manufacturer { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
}






