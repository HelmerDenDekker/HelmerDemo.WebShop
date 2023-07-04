using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public class CustomerService
    {
        public Result CreateAccount(CustomerDto customerDto)
        {
            // validate

            // create a Customer
            var customerResult = Customer.CreateCustomer(customerDto.FullName, customerDto.Email);
            
            return customerResult;
        }
    }
}
