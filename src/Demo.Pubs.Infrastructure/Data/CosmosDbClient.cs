using System;
using System.Threading;
using System.Threading.Tasks;
using Demo.Pubs.Infrastructure.Interfaces;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace Demo.Pubs.Infrastructure.Data
{
    public class CosmosDbClient : ICosmosDbClient
    {
        private readonly string _databaseName;
        private readonly string _collectionName;
        private readonly IDocumentClient _documentClient;

        public CosmosDbClient(string databaseName, string collectionName, IDocumentClient documentClient)
        {
            _databaseName = databaseName ?? throw new ArgumentNullException(nameof(databaseName));
            _collectionName = collectionName ?? throw new ArgumentNullException(nameof(collectionName));
            _documentClient = documentClient ?? throw new ArgumentNullException(nameof(documentClient));
        }

        public async Task<Document> ReadDocumentAsync(string documentId, RequestOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = UriFactory.CreateDocumentUri(_databaseName, _collectionName, documentId);
            return await _documentClient.ReadDocumentAsync(uri, options, cancellationToken);
        }

        public async Task<Document> CreateDocumentAsync(object document, RequestOptions options = null,
            bool disableAutomaticIdGeneration = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = UriFactory.CreateDocumentCollectionUri(_databaseName, _collectionName);
            return await _documentClient.CreateDocumentAsync(uri, document, options, disableAutomaticIdGeneration, cancellationToken);
        }

        public async Task<Document> ReplaceDocumentAsync(string documentId, object document,
            RequestOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = UriFactory.CreateDocumentUri(_databaseName, _collectionName, documentId);
            return await _documentClient.ReplaceDocumentAsync(uri, document, options, cancellationToken);
        }

        public async Task<Document> DeleteDocumentAsync(string documentId, RequestOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = UriFactory.CreateDocumentUri(_databaseName, _collectionName, documentId);
            return await _documentClient.DeleteDocumentAsync(uri, options, cancellationToken);
        }
    }
}
