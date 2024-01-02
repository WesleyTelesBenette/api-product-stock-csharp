using api_product_stock_csharp.Model;
using Microsoft.EntityFrameworkCore;

namespace api_product_stock_csharp.Data;

public class StockContext : DbContext
{
    public StockContext(DbContextOptions<StockContext> opts) : base(opts)
    {

    }

    public DbSet<Product> TbProduct { get; set; }
    public DbSet<Category> TbCategory { get; set; }
    public DbSet<ItemSold> TbItemSold { get; set;}
    public DbSet<Sale> TbSale { get; set; }
    public DbSet<Promotion> TbPromotion { get; set; }
}
