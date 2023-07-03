using System.ComponentModel.DataAnnotations;

namespace HelmerDemo.WebShop.Domain.Customer
{
    public class Customer
    {
        /// <summary>
        /// Gets the customer number
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Get the first name
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets the last name
        /// </summary>
        public string LastName { get; private set; }
        
        /// <summary>
        /// Gets the billing address
        /// </summary>
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// Gets the billing address
        /// </summary>
        public Address ShippingAddress { get; private set; }


        /// <summary>
        /// Gets the Email address of the customer
        /// </summary>
        [EmailAddress]
        public string Email { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the phone number of the customer
        /// </summary>
        [Phone]
        public string PhoneNumber { get; private set; } = string.Empty;



    }
}
