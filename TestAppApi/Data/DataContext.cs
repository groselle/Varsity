using TestAppApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TestAppApi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Value> Values { get; set; }



    }
}