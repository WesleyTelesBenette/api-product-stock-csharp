using Microsoft.AspNetCore.Mvc;

namespace api_product_stock_csharp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    [HttpGet("/")]
    public IActionResult GetAllProducts()
    {
        return Ok();
    }

    [HttpGet("/range")]
    public IActionResult GetRangeProducts([FromQuery] int startIndex = -1, [FromQuery] int elements = -1)
    {
        return Ok();
    }

    [HttpGet("/id/{id}")]
    public IActionResult GetProductId(int id)
    {
        return Ok();
    }

    [HttpGet("/category/{category}")]
    public IActionResult GetProductCategory(string category)
    {
        return Ok();
    }

    [HttpPost("/")]
    public IActionResult CreateProduct([FromBody] object newProduct)
    {
        return Created();
    }

    [HttpPut("/{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] object newUpdateProduct)
    {
        return Ok();
    }

    [HttpDelete("/{id}")]
    public IActionResult DeleteProduct(int id)
    {
        return Ok();
    }
}
