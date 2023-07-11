using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;
using System.ComponentModel.DataAnnotations;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    public class Customer
    {
        /// <summary>
        /// The unique identifier for this entity
        /// </summary>
        public Guid UniqueId { get; private set; }

        /// <summary>
        /// Gets the full name of the customer
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        /// Gets the Email address of the customerCustomer
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets the date the customer account was created
        /// </summary>
        public DateTime RegisteredOn { get; private set; }

        /// <summary>
        /// Initializes a new instance of the  <see cref="Customer">Customer</see> class
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        public static Result<Customer> CreateCustomer(string fullName, string email)
        {
            // validation

            if (fullName.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<Customer>();
            }

            if (email.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<Customer>();
            }

            if (!email.IsValidEmail())
            {
                return Result.BadRequest.DownCast<Customer>();
            }

            var customer = new Customer(fullName, email);

            return Result.Created.DownCast(customer);
        }

        private Customer(string fullName, string email)
        {
            // Properties to be filled from the DTO

            FullName = fullName;
            Email = email;

            // The application user does not need to know about these (internal) fields.
            UniqueId = Guid.NewGuid();
            RegisteredOn = DateTime.Now;
        }

        
    }
}
