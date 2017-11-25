using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCK.Model;

namespace PCK.Model
{
    public class SalesOrderConfiguration : IEntityTypeConfiguration<SalesOrder>
    {
        public void Configure(EntityTypeBuilder<SalesOrder> builder)
        {
            builder.HasKey(c => c.SalesOrderId);
            builder.Property(c => c.CustomerName).HasMaxLength(30);
            builder.Property(c => c.PONumber).HasMaxLength(10);
        }
        
    }
}
