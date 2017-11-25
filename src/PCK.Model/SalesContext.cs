using Microsoft.EntityFrameworkCore;


namespace PCK.Model
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {            
        }


        public DbSet<SalesOrder> SalesOrder { get; set; }


        protected override void OnModelCreating( ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new SalesOrderConfiguration());
        }
    }
}
