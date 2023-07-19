using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Application.CustomerService
{
    public interface ICustomerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerDto"></param>
        /// <returns></returns>
        public Result CreateAccount(AddCustomerDto customerDto);
    }
}
