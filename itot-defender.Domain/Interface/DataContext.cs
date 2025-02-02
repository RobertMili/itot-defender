using System.Collections.Generic;
using itot_defender.Domain.Entities;

namespace itot_defender.Domain.Interfaces
{
public interface IProductRepository
{
    List<Product> GetAllProducts();
}
}
