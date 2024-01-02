using System.ComponentModel.DataAnnotations;

namespace api_product_stock_csharp.Model;

public class Category
{
    [Key]
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
    public int CategoryId { get; set; } = 0;

    [Required(ErrorMessage = "The category name is mandatory.")]
    [MaxLength(30, ErrorMessage = "The number of characters is limited to 30.")]
    public string Name { get; set; } = string.Empty;
}
