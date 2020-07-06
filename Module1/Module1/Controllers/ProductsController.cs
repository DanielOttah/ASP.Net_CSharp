using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static List<Products> _products = new List<Products>()
        {
            new Products(){Product_Id=0, Product_Name="Laptop",Product_Price="CAD$200"},
        new Products() { Product_Id = 1, Product_Name = "Smart Phone",Product_Price = "CAD$100"},
        new Products() { Product_Id = 2, Product_Name = "Desktop",Product_Price = "CAD$300"},
        };

 
        //------------------- Status Codes------------------------------
        //A Get method. iActionResult is used to return status code
        //public IActionResult Get()
        //{
        //    return ok();
        //    return notfound();
        //    return badrequest();
        //    return StatusCode(StatusCodes.Status201Created);
        //}


        [HttpGet]
        //A Get method. IEnumerable is used because we're returning a list nb as long sa the method name starts with 'Get', it'll be directed to the [HttpGet] route
        public IEnumerable<Products> GetProducts()
        {
            return _products;
        }

        //============= A custome Get Method =====================
        [HttpGet("WelcomeMessage")]
        //A custom Get method. With the route '/WelcomeMessage', the message will be displayed
        public IActionResult Get()
        {
            return Ok("Wlecome to the Store ...");
        }


        //[HttpPost] is used to identify the route as a post method
        [HttpPost]
        public IActionResult Post([FromBody] Products product)
        {
            _products.Add(product);
            return StatusCode(StatusCodes.Status201Created);
        }

        //[HttpPut()] is used to identify the route as a put method.  The parameter '"{id}"' is used to create an extra route that takes the id of the product to be updated
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products product)
        {
            _products[id] = product;
            return StatusCode(StatusCodes.Status201Created);
        }

        //[HttpPut()] is used to identify the route as a put method.  The parameter '"{id}"' is used to create an extra route that takes the id of the product to be updated
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _products.RemoveAt(id);
            return StatusCode(StatusCodes.Status202Accepted);
        }
    }
}
