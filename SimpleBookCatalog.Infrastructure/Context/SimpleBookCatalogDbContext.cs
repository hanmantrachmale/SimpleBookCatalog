
using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookCatalogDbContext:DbContext
    {
        public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use of Fluent API
            //modelBuilder.Entity<Book>().Property(e=>e.Title).IsRequired().HasMaxLength(100);
            base.OnModelCreating(modelBuilder);
        }
    }
}
