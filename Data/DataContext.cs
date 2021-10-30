using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Colors> Colors { get; set; }

        

        
    }
}