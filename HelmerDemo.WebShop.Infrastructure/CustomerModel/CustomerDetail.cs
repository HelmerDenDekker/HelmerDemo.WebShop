namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class CustomerDetail
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
        public List<Address> Addresses { get; set; } = new List<Address>();


        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with Customer.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Navigational property, the CustomerDetails have a one to one relation with Customer.
        /// </summary>
        public Customer Customer { get; set; }
    }
}
