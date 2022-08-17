using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;



namespace Catalog.Controllers
{
    //GET /items

    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRep repository;


    }
}