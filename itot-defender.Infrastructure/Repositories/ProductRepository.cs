using System.Collections.Generic;
using System.Linq;
using itot_defender.Domain.Entities;
using itot_defender.Domain.Interfaces;
using itot_defender.Infrastructure.Data;

namespace itot_defender.Infrastructure.Repositories
{
public class ProductRepository : IProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context)
    {
        Console.WriteLine("ProductRepository constructor");
        _context = context;
    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }
}
}
