using Microsoft.AspNetCore.Mvc;

namespace HelmerDemo.WebShop.Application.Controllers
{
    [ApiVersion("1.0")]
    public class OrderController : BaseApiController
    {

        [HttpGet]
        //[MapToApiVersion("1.0")]
        public string Get() => ".Net Core Web API Version 1";
    }

}
