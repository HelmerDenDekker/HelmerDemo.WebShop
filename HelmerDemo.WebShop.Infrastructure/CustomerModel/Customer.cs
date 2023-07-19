namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class Customer
    {
        public Customer(Guid uniqueId, DateTime registeredOn, string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            UniqueId = uniqueId;
            RegisteredOn = registeredOn;
        }
        /// <summary>
        /// Gets or sets the primary key for this persistance entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the domain entity
        /// </summary>
        public Guid UniqueId { get; private set; }

        /// <summary>
        /// Gets the full name of the customer
        /// </summary>
        public string FullName { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the Email address of the customerCustomer
        /// </summary>
        public string Email { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the date the customer account was created
        /// </summary>
        public DateTime RegisteredOn { get; private set; }

        /// <summary>
        /// Navigational property, the Customer has a optional to one relation with CustomerDetails.
        /// </summary>
        public int? CustomerDetailId { get; set; }

        /// <summary>
        /// Navigational property, the Customer has a optional to one relation with CustomerDetails.
        /// </summary>
        public CustomerDetail? CustomerDetails { get; set; }
    }
}
