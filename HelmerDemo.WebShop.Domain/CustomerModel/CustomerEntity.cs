using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    public class CustomerEntity
    {
        /// <summary>
        /// The unique identifier for this domain entity
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
        /// Initializes a new instance of the <see cref="CustomerEntity"/> class.
        /// </summary>
        internal CustomerEntity()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomerEntity"/> (instead of factory pattern)
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        internal Result<CustomerEntity> CreateCustomer(string fullName, string email)
        {
            // validation

            if (fullName.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            if (email.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            if (!email.IsValidEmail())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            var uniqueId = Guid.NewGuid();
            var registeredOn = DateTime.Now;

            var customer = new CustomerEntity(uniqueId, registeredOn, fullName, email);

            return Result.Created.DownCast(customer);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerEntity"/> class.
        /// </summary>
        /// <param name="fullName">The full name of the customer</param>
        /// <param name="email">The email of the customer</param>
        private CustomerEntity(Guid uniqueId, DateTime registeredOn, string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            UniqueId = uniqueId;
            RegisteredOn = registeredOn;
        }

    }
}
