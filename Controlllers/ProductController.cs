using Microsoft.AspNetCore.Mvc;

namespace ClaudPointsAPI_2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet("list")]
    public IActionResult GetProducts()
    {
        var products = new List<string>
        {
            "Product 1",
            "Product 2",
            "Product 3"
        };

        return Ok(products);
    }
}