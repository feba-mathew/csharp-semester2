using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;

namespace HelloWorld
{
    public interface IProductRepository
    {
        IEnumerable<Models.Product> Products { get; }
    }

    public class ProductRepository : IProductRepository
    {
        private IMemoryCache memoryCache;

        public ProductRepository(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        public IEnumerable<Models.Product> Products
        {
            get
            {
                IEnumerable<Models.Product> items;

                if (!memoryCache.TryGetValue("MyProducts", out items))
                {
                    helloworldContext database = new helloworldContext();

                    items = database.Product.Select(t => new Models.Product { ProductId = t.ProductId, Description = t.Description, Name = t.Name, Price = t.Price, ProductCount = t.ProductCount }).AsEnumerable();

                    memoryCache.Set("MyProducts", items,
                        new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(System.TimeSpan.FromSeconds(5)));
                }

                return items;
            }
        }
    }
}