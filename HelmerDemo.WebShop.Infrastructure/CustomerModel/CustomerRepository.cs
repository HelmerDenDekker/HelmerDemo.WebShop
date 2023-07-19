using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDbContext _dbContext;

        public CustomerRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Result CreateCustomer(Customer customer)
        {
            try
            {
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                return Result.Created;
            }
            catch (Exception)
            {
                return Result.InternalServerError;
            }

        }

        public Result<Customer> FindById(Guid uniqueId)
        {
            try
            {
                var customer = _dbContext.Customers.FirstOrDefault(customer => customer.UniqueId.Equals(uniqueId));

                if (customer == null)
                {
                    return Result.NotFound.DownCast<Customer>();
                }

                return Result.Ok.DownCast<Customer>(customer);
            }
            catch (Exception)
            {
                return Result.InternalServerError.DownCast<Customer>();
            }
            
        }
    }
}
