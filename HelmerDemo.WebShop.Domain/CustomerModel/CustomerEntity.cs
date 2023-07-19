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
        /// 
        /// </summary>
        /// <param name="fullName">The full name of the customer</param>
        /// <param name="email">The email of the customer</param>
        internal CustomerEntity(Guid uniqueId, DateTime registeredOn, string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            UniqueId = uniqueId;
            RegisteredOn = registeredOn;
        }

        
    }
}
