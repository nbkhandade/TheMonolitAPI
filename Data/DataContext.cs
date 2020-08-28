using Microsoft.EntityFrameworkCore;
using TheMonolit.API.Models;
using TheMonolit.API.Properties.Models;

namespace TheMonolit.API.Data
{
   
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }

        public DbSet<FundDataValue> FundDataValues { get; set; }
        
    }
}