using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static List<Customer> _customers = new List<Customer>()
        {
            new Customer(){Id=0, Name="Daniel",Email="dgo@gmail.com", Phone="123456789"},
            new Customer(){Id=1, Name="Suo",Email="suo@gmail.com", Phone="987654321"},
            new Customer(){Id=2, Name="Thea",Email="thea@gmail.com", Phone="456987123"},
            new Customer(){Id=3, Name="Eli",Email="Eli@gmail.com", Phone="789654123"},
        };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            if (ModelState.IsValid)
            {
            _customers.Add(customer);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
