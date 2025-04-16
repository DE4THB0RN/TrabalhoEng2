using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Comida
{
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter as pizzas
            var pizzas = new List<string> { "Pizza Margherita", "Pizza Pepperoni", "Pizza Quatro Queijos" };
            return Ok(pizzas);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter uma pizza específica pelo ID
            var pizza = $"Pizza {id}";
            return Ok(pizza);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string pizza)
        {
            // Aqui você pode adicionar a lógica para adicionar uma nova pizza
            return CreatedAtAction(nameof(Get), new { id = 1 }, pizza);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string pizza)
        {
            // Aqui você pode adicionar a lógica para atualizar uma pizza existente
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir uma pizza existente
            return NoContent();
        }
    }
}