using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Comida
{
    public class BebidaController : ControllerBase
    {
        private readonly ILogger<BebidaController> _logger;

        public BebidaController(ILogger<BebidaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter as bebidas
            // Por exemplo, você pode chamar um serviço ou acessar um banco de dados
            // Retornando uma lista de bebidas como exemplo
            var bebidas = new List<string> { "Água", "Refrigerante", "Suco" };
            return Ok(bebidas);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter uma bebida específica pelo ID
            // Por exemplo, você pode chamar um serviço ou acessar um banco de dados
            // Retornando uma bebida como exemplo
            var bebida = "Água";
            return Ok(bebida);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string bebida)
        {
            // Aqui você pode adicionar a lógica para adicionar uma nova bebida
            // Por exemplo, você pode chamar um serviço ou acessar um banco de dados
            // Retornando uma resposta de sucesso como exemplo
            return CreatedAtAction(nameof(Get), new { id = 1 }, bebida);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string bebida)
        {
            // Aqui você pode adicionar a lógica para atualizar uma bebida existente
            // Por exemplo, você pode chamar um serviço ou acessar um banco de dados
            // Retornando uma resposta de sucesso como exemplo
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir uma bebida existente
            // Por exemplo, você pode chamar um serviço ou acessar um banco de dados
            // Retornando uma resposta de sucesso como exemplo
            return NoContent();
        }

        

    }
}
