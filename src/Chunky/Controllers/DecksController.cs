using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chunky.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chunky.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        // GET: api/decks
        [HttpGet]
        public IEnumerable<DeckModel> Get()
        {
            DeckModel[] decks = new DeckModel[3] 
            {
                new DeckModel() { Id = 1, Title = "Adjectives", Date = DateTime.Now},
                new DeckModel() { Id = 2, Title = "Verbs", Date = DateTime.Now},
                new DeckModel() { Id = 3, Title = "Phrasal Verbs", Date = DateTime.Now}
            };

            return decks;
        }

        // GET: api/Decks/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Decks
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Decks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
