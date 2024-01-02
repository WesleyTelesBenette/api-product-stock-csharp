using System.ComponentModel.DataAnnotations;

namespace api_product_stock_csharp.Model
{
    public class ItemSold
    {
        [Key]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
        public int ItemSoldId { get; set; } = 0;

        [Required(ErrorMessage = "Product id is mandatory.")]
        [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
        public int ProductId { get; set; } = 0;

        [Required(ErrorMessage = "Sale id is mandatory.")]
        [Range(0, int.MaxValue, ErrorMessage = "An id cannot be less than 0.")]
        public int SaleId { get; set; } = 0;

        [Required(ErrorMessage = "Amount is mandatory.")]
        [Range(0, int.MaxValue, ErrorMessage = "Amount cannot be less than 0.")]
        public int Amount { get; set; } = 0;

        [Required(ErrorMessage = "Item price is mandatory.")]
        [Range(0, int.MaxValue, ErrorMessage = "The price cannot be less than 0.")]
        public double UnitPrice { get; set; } = 0;
    }
}
