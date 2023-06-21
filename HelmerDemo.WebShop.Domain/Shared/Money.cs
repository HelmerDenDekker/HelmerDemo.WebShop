using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelmerDemo.WebShop.Domain.Shared
{
    public class Money
    {
        /// <summary>
        /// Gets the currency
        /// </summary>
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the amount
        /// </summary>
        public decimal Amount { get; private set; }
    }
}
