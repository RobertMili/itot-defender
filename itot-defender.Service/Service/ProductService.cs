using itot_defender.Domain.Entities;
using itot_defender.Domain.Interfaces;
using System.Collections.Generic;

namespace itot_defender.Service.Services
{
public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        Console.WriteLine("ProductService constructor");
        _productRepository = productRepository;
    }

    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }
}
}
