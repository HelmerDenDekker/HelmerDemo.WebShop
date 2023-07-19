using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelmerDemo.WebShop.Domain.CustomerModel
{
    /// <summary>
    /// The aggregate encapsulates all Customer logic
    /// </summary>
    public class CustomerAggregate : ICustomerAggregate
    {
        /// <inheritdoc/>
        public Result<CustomerEntity> CreateCustomer(string fullName, string email)
        {
            // validation

            if (fullName.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            if (email.IsNullOrWhiteSpace())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            if (!email.IsValidEmail())
            {
                return Result.BadRequest.DownCast<CustomerEntity>();
            }

            var uniqueId = Guid.NewGuid();
            var registeredOn = DateTime.Now;

            var customer = new CustomerEntity(uniqueId, registeredOn, fullName, email);

            return Result.Created.DownCast(customer);
        }
    }
}
