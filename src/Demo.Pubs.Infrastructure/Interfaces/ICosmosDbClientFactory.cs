namespace Demo.Pubs.Infrastructure.Interfaces
{
    public interface ICosmosDbClientFactory
    {
        ICosmosDbClient GetClient(string collectionName);
    }
}
