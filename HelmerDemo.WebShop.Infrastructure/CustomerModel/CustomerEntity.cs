using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelmerDemo.WebShop.Infrastructure.CustomerModel
{
    public class CustomerEntity
    {
        /// <summary>
        /// The unique identifier for this entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets the full name of the customer
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the Email address of the customerCustomer
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets the date the customer account was created
        /// </summary>
        public DateTime RegisteredOn { get; set; }
    }
}
