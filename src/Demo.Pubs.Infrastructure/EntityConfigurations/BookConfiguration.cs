using Demo.Pubs.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Demo.Pubs.Infrastructure.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Id).HasValueGenerator<GuidValueGenerator>();

            builder.OwnsOne(b => b.Publisher);

            builder.OwnsMany(b => b.Authors);

        }
    }
}
