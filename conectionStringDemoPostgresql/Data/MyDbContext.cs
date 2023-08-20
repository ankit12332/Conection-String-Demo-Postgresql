using conectionStringDemoPostgresql.Model;
using Microsoft.EntityFrameworkCore;

namespace conectionStringDemoPostgresql.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
