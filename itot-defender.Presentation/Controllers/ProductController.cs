using Microsoft.AspNetCore.Mvc;
using itot_defender.Domain.Entities;
using itot_defender.Service.Services;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace itot_defender.API.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductService _productService;
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService;
        _logger = logger;
        Console.WriteLine("ProductsController initialized");
    }

    [HttpGet]
    public ActionResult<List<Product>> GetAllProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }
}
}
