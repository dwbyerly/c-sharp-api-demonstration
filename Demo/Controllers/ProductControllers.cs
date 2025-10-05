// Demo/Controllers/ProductControllers.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// Assuming you have a DbContext named AppDbContext and a model named Product
// Controller for product-related endpoints
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    // Constructor to inject the database context
    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/products
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }
}