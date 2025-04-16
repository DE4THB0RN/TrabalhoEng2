using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Serviço
{
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;

        public EnderecoController(ILogger<EnderecoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter os endereços
            var enderecos = new List<string> { "Rua A, Bairro B, Nº 123", "Rua X, Bairro Y, Nº 456" };
            return Ok(enderecos);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter um endereço específico pelo ID
            var endereco = $"Endereço {id}";
            return Ok(endereco);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string endereco)
        {
            // Aqui você pode adicionar a lógica para adicionar um novo endereço
            return CreatedAtAction(nameof(Get), new { id = 1 }, endereco);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string endereco)
        {
            // Aqui você pode adicionar a lógica para atualizar um endereço existente
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir um endereço existente
            return NoContent();
        }
    }
}