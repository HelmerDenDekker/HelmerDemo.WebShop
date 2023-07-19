using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Domain.SeedWork.Models;
using HelmerDemo.WebShop.Infrastructure.CustomerModel;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerAggregate _customerAggregate;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerAggregate customerAggregate, ICustomerRepository customerRepository) 
        {
            _customerAggregate = customerAggregate;
            _customerRepository = customerRepository;
        }


        /// <inheritdoc/>
        public Result CreateAccount(AddCustomerDto customerDto)
        {
            // validation

            // We could for example, check if the email is unique in the database here.

            // Create a Customer in the domain
            Result<CustomerEntity> createCustomerResult = _customerAggregate.CreateCustomer(customerDto.FullName, customerDto.Email) ;

            if(!createCustomerResult.IsSuccess) 
            {
                return createCustomerResult;
            }

            Customer customer = new CustomerAdapter().CreateFromCustomerEntity(createCustomerResult.Value);
           
            // Store in DB
            Result persistResult = _customerRepository.CreateCustomer(customer);

            return persistResult;
        }
    }
}
