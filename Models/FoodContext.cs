using Microsoft.EntityFrameworkCore;

namespace FourthTemplateforfoodordering.Models
{
    public class FoodContext:DbContext
    {
        public FoodContext() { }
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }
            public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }

        public DbSet<OrderDetails> OrderDetail { get; set; }
    }
}
