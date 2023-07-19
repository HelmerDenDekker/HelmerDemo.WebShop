using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;
using HelmerDemo.WebShop.Infrastructure.CustomerModel;

namespace HelmerDemo.WebShop.Application.UnitTest
{
    /// <summary>
    /// Stubs the dependencies of CustomerRepository
    /// </summary>
    internal class CustomerRepositoryStub : ICustomerRepository
    {
        /// <summary>
        /// For testing purposes, indicates if the customer was found in the database
        /// </summary>
        public bool IsFound { get; set; }

        /// <inheritdoc />
        public Result CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Result<Customer> FindById(Guid uniqueId)
        {
            if (!IsFound)
            {
                return Result.NotFound.DownCast<Customer>();
            }
            var customer = new Customer(uniqueId, DateTime.Now, "Test the Tester", "testemail@testdomain.com");
            return Result.Ok.DownCast<Customer>(customer);
        }
    }
}
