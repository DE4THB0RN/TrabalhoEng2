using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Pessoas
{
    public class FuncionarioController : ControllerBase
    {
        private readonly ILogger<FuncionarioController> _logger;

        public FuncionarioController(ILogger<FuncionarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter os funcionários
            var funcionarios = new List<string> { "Funcionario 1", "Funcionario 2", "Funcionario 3" };
            return Ok(funcionarios);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter um funcionário específico pelo ID
            var funcionario = $"Funcionario {id}";
            return Ok(funcionario);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string funcionario)
        {
            // Aqui você pode adicionar a lógica para adicionar um novo funcionário
            return CreatedAtAction(nameof(Get), new { id = 1 }, funcionario);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string funcionario)
        {
            // Aqui você pode adicionar a lógica para atualizar um funcionário existente
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir um funcionário existente
            return NoContent();
        }
    }
}