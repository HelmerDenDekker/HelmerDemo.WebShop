using HelmerDemo.WebShop.Infrastructure.CustomerModel;
using Microsoft.EntityFrameworkCore;

namespace HelmerDemo.WebShop.Infrastructure
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
    }
}
