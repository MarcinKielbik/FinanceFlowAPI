using FinanceFlowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceFlowAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
