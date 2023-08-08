using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    /// <summary>
    /// Encapsulates the customer domain layer
    /// </summary>
    public interface ICustomerAggregate
    {
        /// <summary>
        /// Simple factory for creating a new <see cref="CustomerEntity">CustomerEntity</see> object
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        public Result<CustomerEntity> CreateCustomer(string fullName, string email);
    }
}
