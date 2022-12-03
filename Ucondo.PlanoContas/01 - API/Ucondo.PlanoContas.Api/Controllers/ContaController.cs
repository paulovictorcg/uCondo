﻿using Microsoft.AspNetCore.Mvc;

namespace Ucondo.PlanoContas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        // GET: api/<ContaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
