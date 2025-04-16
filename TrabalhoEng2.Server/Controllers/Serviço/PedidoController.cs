using Microsoft.AspNetCore.Mvc;

namespace TrabalhoEng2.Server.Controllers.Serviço
{
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            // Aqui você pode adicionar a lógica para obter os pedidos
            var pedidos = new List<string> { "Pedido 1", "Pedido 2", "Pedido 3" };
            return Ok(pedidos);
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetById(int id)
        {
            // Aqui você pode adicionar a lógica para obter um pedido específico pelo ID
            var pedido = $"Pedido {id}";
            return Ok(pedido);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] string pedido)
        {
            // Aqui você pode adicionar a lógica para adicionar um novo pedido
            return CreatedAtAction(nameof(Get), new { id = 1 }, pedido);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] string pedido)
        {
            // Aqui você pode adicionar a lógica para atualizar um pedido existente
            return NoContent();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            // Aqui você pode adicionar a lógica para excluir um pedido existente
            return NoContent();
        }
    }
}