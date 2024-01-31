using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyntraEcommerceWebApi.Model;

namespace MyntraEcommerceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult RegisterCustomer(Customer customer)
        {
            return Ok();
        }
    }
}
