using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new[] {
new Customer { Id = 1, FullName = "Alex"},
new Customer { Id = 2, FullName = "Duck"},
new Customer { Id = 3, FullName = "UVP"},
new Customer { Id = 4, FullName = "Suchkov"},
new Customer { Id = 5, FullName = "I <3 linux"}
};
            return Ok(customers);
        }
    }
}