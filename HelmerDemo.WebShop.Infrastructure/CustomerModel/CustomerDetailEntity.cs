namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class CustomerDetailEntity
    {
        /// <summary>
        /// Gets or sets the primary key for this persistance entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the customer number
        /// </summary>
        public int Number { get; set; } = default;

        /// <summary>
        /// Gets the phone number of the customer
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;


        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with (Billing)Address.
        /// </summary>
        public string BillingAddresId { get; set; }

        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with (Billing)Address.
        /// </summary>
        public AddressEntity BillingAddress { get; set; }

        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with (Shipping)Address.
        /// </summary>
        public int ShippingAddresId { get; set; }
        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with (Shipping)Address.
        /// </summary>
        public AddressEntity ShippingAddress { get; set; }


        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with Customer.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with Customer.
        /// </summary>
        public CustomerEntity Customer { get; set; }
    }
}
