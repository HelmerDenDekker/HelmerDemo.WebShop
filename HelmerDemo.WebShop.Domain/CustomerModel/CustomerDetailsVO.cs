namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    internal class CustomerDetailsVO
    {
        internal Guid CustomerUniqueId { get; private set; }

        /// <summary>
        /// Gets the customer number
        /// </summary>
        internal int Number { get; private set; } = default;

        /// <summary>
        /// Gets the billing address
        /// </summary>
        internal AddressVO BillingAddress { get; private set; }

        /// <summary>
        /// Gets the billing address
        /// </summary>
        internal AddressVO ShippingAddress { get; private set; }


        /// <summary>
        /// Gets the phone number of the customer
        /// </summary>
        internal string PhoneNumber { get; private set; } = string.Empty;
    }
}
