using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using Catalog.Entities;


namespace Catalog.Controllers
{

    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRep repository;

        public ItemsController()
        {
            repository = new InMemItemsRep();
        }

        //GET /Items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
    }
}