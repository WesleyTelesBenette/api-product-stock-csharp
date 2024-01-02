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

    [HttpGet("/id/{idProduct}")]
    public IActionResult GetProductId(int idProduct)
    {
        return Ok();
    }

    [HttpGet("/category/{category}")]
    public IActionResult GetProductsCategory(string category)
    {
        return Ok();
    }

    [HttpPost("/")]
    public IActionResult CreateProduct([FromBody] object newProduct)
    {
        return Created();
    }

    [HttpPut("/{idProduct}")]
    public IActionResult UpdateProduct(int idProduct, [FromBody] object newUpdateProduct)
    {
        return Ok();
    }

    [HttpDelete("/{idProduct}")]
    public IActionResult DeleteProduct(int idProduct)
    {
        return Ok();
    }
}
