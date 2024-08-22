using eCommerceAPI.Interface;
using Microsoft.AspNetCore.Mvc;


namespace eCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public IUsuarioRepository _repository { get; }
        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        //{localhost}/api/usuarios
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
        public ActionResult Add([FromBody] Usuario usuario)
        {
            _repository.Add(usuario);
            return Ok(usuario);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            _repository.Update(usuario);
            return Ok(usuario);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok("Registro Deletado!");
        }


    }
}
