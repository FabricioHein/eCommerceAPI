using eCommerce.Models;
using eCommerceAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        public IPedidoRepository _repository { get; }
        public PedidosController(IPedidoRepository repository)
        {
            _repository = repository;
        }
        //{localhost}/api/pedidos
        [HttpGet]
        public ActionResult Get()
        {
            var listaUsuario = _repository.Get();

            return Ok(listaUsuario);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var findFistUsuario = _repository.Get(id);

            if (findFistUsuario == null)
            {
                return NotFound("Não Encontrado!");

            };

            return Ok(findFistUsuario);
        }
        [HttpPost]
        public ActionResult Add([FromBody] Pedido pedido)
        {
            _repository.Add(pedido);
            return Ok(pedido);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Pedido pedido)
        {
            _repository.Update(pedido);
            return Ok(pedido);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok("Registro Deletado!");
        }


    }
}
