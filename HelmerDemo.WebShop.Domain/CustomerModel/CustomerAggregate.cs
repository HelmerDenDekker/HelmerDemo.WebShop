using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    /// <summary>
    /// The aggregate encapsulates all Customer logic
    /// </summary>
    public class CustomerAggregate : ICustomerAggregate
    {
        /// <inheritdoc/>
        public Result<CustomerEntity> CreateCustomer(string fullName, string email)
        {
            var customerLogic = new CustomerEntity();

            return customerLogic.CreateCustomer(fullName, email);
        }
    }
}
