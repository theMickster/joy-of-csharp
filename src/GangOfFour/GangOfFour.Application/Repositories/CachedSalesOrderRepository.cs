using GangOfFour.Core.Entities.Sales;
using Microsoft.Extensions.Caching.Memory;

namespace GangOfFour.Application.Repositories
{
    public class CachedSalesOrderRepository : SalesOrderRepository
    {
        private readonly IMemoryCache _cache;
        private readonly MemoryCacheEntryOptions _options = new MemoryCacheEntryOptions().SetPriority(CacheItemPriority.NeverRemove);

        public CachedSalesOrderRepository(IMemoryCache cache) : base()
        {
            _cache = cache;
            
        }

        public override SalesOrder GetById(int id)
        {
            var cacheKey = $"SalesOrderEntity_{id}";
            if (_cache.Get(cacheKey) is SalesOrder entity)
            {
                return entity;
            }

            entity = base.GetById(id);
            _cache.Set(cacheKey, entity, _options);

            return entity;
        }
    }
}