using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module2.Data;
using Module2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductsDbContext productsDbContext;
        public ProductsController(ProductsDbContext _productsDbContext)
        {
            productsDbContext = _productsDbContext;
        }
        
        
        // GET: api/<ProductsController>
        [HttpGet]
        //public IEnumerable<Products> Get(string sort)
        //{
        //    IQueryable<Products> products;
        //    switch (sort)
        //    {
        //        case "desc_Price":
        //            products = productsDbContext.Products.OrderByDescending(p => Convert.ToDecimal(p.Product_Price));
        //            break;
        //        case "asc_Price":
        //            products = productsDbContext.Products.OrderBy(p => Convert.ToDecimal(p.Product_Price));
        //            break;
        //        case "desc_Id":
        //            products = productsDbContext.Products.OrderByDescending(p => p.Product_Id);
        //            break;
        //        case "asc_Id":
        //            products = productsDbContext.Products.OrderBy(p => p.Product_Id);
        //            break;
        //        default:
        //            products = productsDbContext.Products;
        //            break;
        //    }

        //    return products;
        //}
        //Pagination in API's
        //public IEnumerable<Products> Get_Pagination(int? pageNumber, int? pageSize)
        //{
        //    var products = from p in productsDbContext.Products.OrderBy(a => a.Product_Id) select p;
        //    var defaultPage = pageNumber ?? 1;
        //    var defaultSize = pageSize ?? 2;
        //    var items = products.Skip((defaultPage - 1) * defaultSize).Take(defaultSize).ToList();
        //    return items;
        //}

        //Search in API's
        public IEnumerable<Products> Get_Search(string search)
        {
            var items = productsDbContext.Products.Where(p => p.Product_Name.StartsWith(search));
            return items;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}", Name ="Get")]
        public IActionResult Get(int id)
        {
           var product =  productsDbContext.Products.SingleOrDefault(m=>m.Product_Id==id);
            if(product == null)
            {
                return NotFound("No record found ...");
            }
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post(int id, [FromBody] Products product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            productsDbContext.Products.Add(product);
            productsDbContext.SaveChanges(true);
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Products product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != product.Product_Id)
            {
                return BadRequest("No record found...");
            }
            productsDbContext.Products.Update(product);
            productsDbContext.SaveChanges(true);
            return Ok("Record updated ...");

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = productsDbContext.Products.SingleOrDefault(m => m.Product_Id == id);
            if (product == null)
            {
                return NotFound("No record found ...");
            }
            productsDbContext.Products.Remove(product);
            productsDbContext.SaveChanges(true);
            return Ok("Product Deleted ...");
        }
    }
}
