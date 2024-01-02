using System.ComponentModel.DataAnnotations;

namespace api_product_stock_csharp.Model;

public class Sale
{
    [Key]
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
    public int SaleId { get; set; } = 0;

    [Required(ErrorMessage = "The date of sale is mandatory.")]
    public DateTime SaleDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "The status of the sale is mandatory.")]
    [MaxLength(30, ErrorMessage = "The number of characters is limited to 30.")]
    public string SaleStatus { get; set; } = string.Empty;
}

