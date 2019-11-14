using Demo.Pubs.Core.Entities;
using Demo.Pubs.Infrastructure.EntityConfigurations;
using Demo.Pubs.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo.Pubs.Infrastructure.DbContexts
{
    public class PubsContext : DbContext, IPubsContext
    {
        public PubsContext(DbContextOptions<PubsContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorAddress> AuthorAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("books");
            
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
