using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public class CustomerService : ICustomerService
    {
        /// <inheritdoc/>
        public Result CreateAccount(CustomerDto customerDto)
        {
            // validate

            //ToDo email must be unique in DB, and I want to notify the user that the email already exists

            // create a Customer
            var customerResult = Customer.CreateCustomer(customerDto.FullName, customerDto.Email);
            
            // ToDo Store in DB

            return customerResult;
        }
    }
}
