using System;
using Demo.Pubs.Core.Entities;
using Demo.Pubs.Core.Interfaces;
using Demo.Pubs.Infrastructure.Interfaces;
using Microsoft.Azure.Documents;

namespace Demo.Pubs.Infrastructure.Repositories
{
    public class BookRepository : CosmosDbRepository<Book>, IBookRepository
    {
        public BookRepository(ICosmosDbClientFactory factory):base(factory){}

        public override string CollectionName { get; } = "books";

        public override string GenerateId(Book entity) => $"{entity.PublishYear}:{Guid.NewGuid()}";

        public override PartitionKey ResolvePartitionKey(string entityId) => new PartitionKey(entityId.Split(':')[0]);
    }
}
