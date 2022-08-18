using Microsoft.EntityFrameworkCore; 
using RazorPizzeria.Model;

namespace RazorPizzeria.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) 
            : base(options)
        {
                
        }
    }
}
