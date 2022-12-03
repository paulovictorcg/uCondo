using Microsoft.AspNetCore.Mvc;
using uCondo.PlanoContas.Domain.Entidades;
using uCondo.PlanoContas.Domain.Interfaces;

namespace Ucondo.PlanoContas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaService _contaService;
        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }
        // GET: api/<ContaController>
        [HttpGet]
        public async Task<IEnumerable<Conta>> Get()
        {
            return await _contaService.listarTodasContasAsync();
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
