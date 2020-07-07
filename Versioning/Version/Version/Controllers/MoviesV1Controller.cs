using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Version.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Version.Controllers
{
    [ApiVersion("1.0")]
    //[Route("api/movies")] // Versioning via normal route
    [Route("api/v{version:apiVersion}/movies")] // Versioning via URL
    [ApiController]
    public class MoviesV1Controller : ControllerBase
    {
        static List<MoviesV1> _movies = new List<MoviesV1>()
        {
            new MoviesV1(){Id = 0, MovieName = "Iron Man"},
            new MoviesV1(){Id = 1, MovieName = "Avengers"},
            new MoviesV1(){Id = 2, MovieName = "Spiderman"},
            new MoviesV1(){Id = 3, MovieName = "Lost Ark"},
            new MoviesV1(){Id = 4, MovieName = "The Book"}
        };

        // GET: api/<MoviesV1Controller>
        [HttpGet]
        public IEnumerable<MoviesV1> Get()
        {
            return _movies;
        }

        // GET api/<MoviesV1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesV1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesV1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesV1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
