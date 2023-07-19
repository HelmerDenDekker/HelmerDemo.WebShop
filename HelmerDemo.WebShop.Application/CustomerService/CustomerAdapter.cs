using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Infrastructure.CustomerModel;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public class CustomerAdapter
    {
        public Customer CreateFromCustomerEntity(CustomerEntity customerEntity)
        {
            return new Customer(customerEntity.UniqueId, customerEntity.RegisteredOn, customerEntity.FullName, customerEntity.Email);
        }
    }
}
