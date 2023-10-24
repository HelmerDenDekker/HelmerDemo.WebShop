using Asp.Versioning;
using HelmerDemo.WebShop.Application.CustomerService;
using HelmerDemo.WebShop.Presentation.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace HelmerDemo.WebShop.Presentation.Controllers
{
    [ApiVersion("1.0")]
    public class CustomerController : BaseApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public ActionResult CreateAccount(AddCustomerDto customerDto) 
        {
            return ActionResponse(_customerService.CreateAccount(customerDto));
        }
    }

}
