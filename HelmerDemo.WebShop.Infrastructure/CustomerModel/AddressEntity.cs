namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class AddressEntity
    {
        /// <summary>
        /// Gets or sets the primary key for this persistance entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the address type
        /// </summary>
        public AddressType AddressType { get; set; }

        /// <summary>
        /// Gets or sets the street
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the House Number
        /// </summary>
        public int HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Navigational property, the Address has a one to one relation with CustomerDetails.
        /// </summary>
        public int? CustomerDetailId { get; set; }

        /// <summary>
        /// Navigational property, the Address has a one to one relation with CustomerDetails.
        /// </summary>
        public CustomerDetailEntity CustomerDetails { get; set; }
    }
}
