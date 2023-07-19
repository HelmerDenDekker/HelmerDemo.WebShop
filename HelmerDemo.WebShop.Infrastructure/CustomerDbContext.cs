using HelmerDemo.WebShop.Infrastructure.CustomerModel;
using Microsoft.EntityFrameworkCore;

namespace HelmerDemo.WebShop.Infrastructure
{
    public class CustomerDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDbContext"/> class.
        /// </summary>
        /// <param name="options">The options for this DbContext</param>
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Customers database table set.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the Addresses for Customers
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the CustomerDetails for the Customers
        /// </summary>
        public DbSet<CustomerDetail> CustomersDetails { get; set; }


        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We only have to create relations not discovered by convention: https://learn.microsoft.com/en-us/ef/core/modeling/relationships/conventions

            // For Customers: optional to one relation with CustomerDetails
            modelBuilder.Entity<Customer>()
                .HasOne(customer => customer.CustomerDetails)
                .WithOne(customerdetails => customerdetails.Customer)
                .HasForeignKey<CustomerDetail>(customerdetails => customerdetails.CustomerId);

            modelBuilder.Entity<CustomerDetail>()
                .HasOne(customerdetails => customerdetails.Customer)
                .WithOne(customer => customer.CustomerDetails)
                .HasForeignKey<Customer>(customer => customer.CustomerDetailId);

            // For Customerdetails, one to many relations with Address

            modelBuilder.Entity<CustomerDetail>()
                .HasMany(customerdetails => customerdetails.Addresses)
                .WithOne(address => address.CustomerDetails)
                .HasForeignKey(address => address.CustomerDetailId);

            modelBuilder.Entity<Address>()
                .HasOne(address=>address.CustomerDetails)
                .WithMany(customerdetails => customerdetails.Addresses)
                .HasForeignKey(address => address.CustomerDetailId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
