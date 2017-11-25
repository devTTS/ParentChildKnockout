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

            builder.Entity<SalesOrder>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId);
                
                entity.Property(e => e.PONumber).HasMaxLength(10);
                entity.Property(e => e.CustomerName).HasMaxLength(50);

            });

            //builder.ApplyConfiguration(new SalesOrderConfiguration());
        }
    }
}
