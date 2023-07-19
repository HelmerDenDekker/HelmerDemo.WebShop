namespace HelmerDemo.WebShop.Application.CustomerService
{
    /// <summary>
    /// Data transfer object for adding a new customer account
    /// </summary>
    public class AddCustomerDto
    {
        /// <summary>
        /// Gets the full name of the customer
        /// </summary>
        public string FullName { get;  set; }

        /// <summary>
        /// Gets the Email address of the customer
        /// </summary>
        public string Email { get;  set; } = string.Empty;
    }
}
