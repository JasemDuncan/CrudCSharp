using CrudCSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        //[Route("/shirts")] // it is not necessary beccuase in line 6 we are using the route
        public string GetShirts() 
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]
        public string GetShirtById(int id)// GetShirtById(int id, [fromQuery] string color]) // GetShirtById(int id, [FromRoute] string color)// [HttpGet("{id}/{color}")]
        //public string GetShirtById(int id, [FromHeader(Name = "Color")] string color)
        {
            return $"Reading shirt with ID: {id}";
        }

        [HttpPost]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            return $"Creating a shirt";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleting shirt: {id}";
        }

    }
}
