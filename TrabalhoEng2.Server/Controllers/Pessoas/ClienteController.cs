using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Pessoas
{
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter os clientes
            var clientes = new List<string> { "Cliente 1", "Cliente 2", "Cliente 3" };
            return Ok(clientes);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter um cliente específico pelo ID
            var cliente = $"Cliente {id}";
            return Ok(cliente);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string cliente)
        {
            // Aqui você pode adicionar a lógica para adicionar um novo cliente
            return CreatedAtAction(nameof(Get), new { id = 1 }, cliente);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string cliente)
        {
            // Aqui você pode adicionar a lógica para atualizar um cliente existente
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir um cliente existente
            return NoContent();
        }
    }
}