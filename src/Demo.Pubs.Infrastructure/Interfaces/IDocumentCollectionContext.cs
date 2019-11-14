using System;
using Demo.Pubs.Core.Entities;
using Microsoft.Azure.Documents;

namespace Demo.Pubs.Infrastructure.Interfaces
{
    public interface IDocumentCollectionContext<in T> where T : BaseEntity
    {
        string CollectionName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}
