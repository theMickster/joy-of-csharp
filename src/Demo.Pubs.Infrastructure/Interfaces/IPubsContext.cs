using Demo.Pubs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Pubs.Infrastructure.Interfaces
{
    public interface IPubsContext
    {
        DbSet<Book> Books { get; set; }

        DbSet<Publisher> Publishers { get; set; }

        DbSet<Author> Authors { get; set; }

        DbSet<AuthorAddress> AuthorAddresses { get; set; }

    }
}
