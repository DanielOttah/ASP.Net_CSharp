using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Version.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Version.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/movies")]
    [ApiController]
    public class MoviesV2Controller : ControllerBase
    {

        static List<MoviesV2> _movies = new List<MoviesV2>()
        {
            new MoviesV2(){Id = 0, MovieName = "Iron Man", Description ="A suit that does all the superman does... Atleast some", Type ="Action" },
            new MoviesV2(){Id = 1, MovieName = "Avengers", Description ="Superheroes destroying everywhere ", Type ="Action" },
            new MoviesV2(){Id = 2, MovieName = "Spiderman", Description ="A man bitten by a spider", Type = "Adventure"},
            new MoviesV2(){Id = 3, MovieName = "Lost Ark", Description = "Story of the lost Ark and the journey it took", Type = "Documentary"},
            new MoviesV2(){Id = 4, MovieName = "The Book", Description = "About the bible and life of Jesus", Type = "Faith"}
        };

        // GET: api/<MoviesV2Controller>
        [HttpGet]
        public IEnumerable<MoviesV2> Get()
        {
            return _movies;
        }

        // GET api/<MoviesV2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesV2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesV2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesV2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
