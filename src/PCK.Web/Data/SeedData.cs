using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PCK.Model;

namespace PCK.Web.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SalesContext(
                serviceProvider.GetRequiredService<DbContextOptions<SalesContext>>()))
            {
                // Look for any movies.
                if (context.SalesOrder.Any())
                {
                    return;   // DB has been seeded
                }

                context.SalesOrder.AddRange(
                    new SalesOrder { PONumber = "1", CustomerName = "John" },
                    new SalesOrder { PONumber = "2", CustomerName = "George" }
                    );
                context.SaveChanges();
            }
        }
    }
}