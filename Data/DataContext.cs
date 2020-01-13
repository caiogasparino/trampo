using Microsoft.EntityFrameworkCore;
using trampo.Models;

namespace trampo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }
        public DbSet<database> Users { get; set; }

    }
}