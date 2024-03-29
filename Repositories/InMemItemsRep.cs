using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;

namespace Catalog.Repositories

{

    public class InMemItemsRep
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreateDate = DateTimeOffset.UtcNow},
            new Item { Id = Guid.NewGuid(), Name = "Sword", Price = 10, CreateDate = DateTimeOffset.UtcNow},
            new Item { Id = Guid.NewGuid(), Name = "Ring", Price = 7, CreateDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

    }
}