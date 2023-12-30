using System.ComponentModel.DataAnnotations;

namespace api_product_stock_csharp.Model;
public class Product
{
    public int ProductId { get; set; } = 0;

    [Required(ErrorMessage = "Product name is mandatory.")]
    [MaxLength(100, ErrorMessage = "The number of characters is limited to 100.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Product description is mandatory.")]
    [MaxLength(1000, ErrorMessage = "The number of characters is limited to 1000.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Product category is mandatory.")]
    public int CategoryId { get; set; } = 0;

    [Required(ErrorMessage = "Product price is mandatory.")]
    [Range(0,int.MaxValue, ErrorMessage = "The price cannot be less than 0.")]
    public double Price { get; set; } = 0;

    [Required(ErrorMessage = "The quantity of the product in stock is mandatory.")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be less than 0.")]
    public int AmountStock { get; set; } = 0;
}
