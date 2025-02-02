using Microsoft.EntityFrameworkCore;
using itot_defender.Domain.Entities;

namespace itot_defender.Infrastructure.Data
{
public class DataContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}
}
