using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Inserts a new customer to the database
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <returns>A <see cref="Result"/> indicating the response status</returns>
        public Result CreateCustomer(Customer customer);

        /// <summary>
        /// Find the user by their unique Id
        /// </summary>
        /// <param name="uniqueId"></param>
        /// <returns>A <see cref="Result"/> indicating the response status</returns>
        public Result<Customer> FindById(Guid uniqueId);
    }
}
