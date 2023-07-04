namespace HelmerDemo.WebShop.Application.CustomerService
{
    public class CustomerDto
    {
        /// <summary>
        /// Gets the full name of the customer
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        /// Gets the Email address of the customer
        /// </summary>
        public string Email { get; private set; } = string.Empty;
    }
}
