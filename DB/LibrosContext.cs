using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class LibrosContext : DbContext
    {
        public LibrosContext(DbContextOptions<LibrosContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Brands> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>().ToTable("Brand");
            modelBuilder.Entity<Book>().ToTable("Book");
        }
    }
}
