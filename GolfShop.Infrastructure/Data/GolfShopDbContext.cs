using GolfShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GolfShop.Infrastructure.Data
{
    public class GolfShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}