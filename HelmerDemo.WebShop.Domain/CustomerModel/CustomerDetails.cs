using System.ComponentModel.DataAnnotations;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    public class CustomerDetails
    {
        public Guid CustomerId { get; private set; }

        /// <summary>
        /// Gets the customer number
        /// </summary>
        public int Number { get; private set; } = default;

        /// <summary>
        /// Gets the billing address
        /// </summary>
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// Gets the billing address
        /// </summary>
        public Address ShippingAddress { get; private set; }


        /// <summary>
        /// Gets the phone number of the customer
        /// </summary>
        [Phone]
        public string PhoneNumber { get; private set; } = string.Empty;


    }
}
