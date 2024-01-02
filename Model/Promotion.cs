using System.ComponentModel.DataAnnotations;

namespace api_product_stock_csharp.Model;

public class Promotion
{
    [Key]
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
    public int PromotionId { get; set; } = 0;

    [Required(ErrorMessage = "The id is mandatory.")]
    [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
    public int ProductId { get; set; } = 0;

    [Required(ErrorMessage = "The promotion percentage is mandatory.")]
    [Range(0, int.MaxValue, ErrorMessage = "The promotion percentage cannot be less than 0.")]
    public double PromotionPercentage { get; set; } = 0;

    [Required(ErrorMessage = "The duration in hours is mandatory.")]
    [Range(0, int.MaxValue, ErrorMessage = "The duration in hours cannot be less than 0.")]
    public int DurationInHours { get; set; } = 0;
}
