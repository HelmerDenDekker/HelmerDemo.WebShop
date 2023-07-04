using HelmerDemo.WebShop.Domain.SeedWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public interface ICustomerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerDto"></param>
        /// <returns></returns>
        public Result CreateAccount(CustomerDto customerDto);
    }
}
