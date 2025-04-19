using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class ExpenseSmartDbContext:DbContext 
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseSmartDbContext(DbContextOptions<ExpenseSmartDbContext> options):base (options)
        {
            
        }
    }
}
