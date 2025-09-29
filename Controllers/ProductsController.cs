using Microsoft.AspNetCore.Mvc;
using MySimpleApi.Models;

namespace MySimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[] {
new Product { Id = 1, Name = "Escape from Tarkov Unheard Edition" },
new Product { Id = 2, Name = "Hollow Knight" },
new Product { Id = 3, Name = "Hollow Knight:Silksong" },
new Product { Id = 4, Name = "Hades" },
new Product { Id = 5, Name = "Hades II" }
};
            return Ok(products);
        }
    }
}