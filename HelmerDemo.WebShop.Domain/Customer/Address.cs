namespace HelmerDemo.WebShop.Domain.Customer
{
    public record Address
    {
        /// <summary>
        /// Gets the street
        /// </summary>
        public string Street { get; init; } = string.Empty;

        /// <summary>
        /// Gets the House Number
        /// </summary>
        public int HouseNumber { get; init; }

        /// <summary>
        /// Gets the city
        /// </summary>
        public string City { get; init; } = string.Empty;

        /// <summary>
        /// Gets the postal code
        /// </summary>
        public string PostalCode { get; init; } = string.Empty;

        /// <summary>
        /// Gets the country
        /// </summary>
        public string Country { get; init; } = string.Empty;
    }
}
