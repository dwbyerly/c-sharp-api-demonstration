// Demo/Models/Products.cs
using Microsoft.EntityFrameworkCore;

// Model representing a product. This should match the schema found in the database
public class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}

// DbContext for interacting with the database
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}