using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAWOS.Data.Services;
using ProyectoAWOS.Data.ViewModels;

namespace ProyectoAWOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuariosService _usuarioService;
        public UsuarioController(UsuariosService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        //Metodo para mostrar todos los registros en la tabla Cryptos
        [HttpGet("get-all-usuario")]
        public IActionResult GetAllUsuario()
        {
            var _allusuarios = _usuarioService.GetAllUsuarios();
            return Ok(_allusuarios);
        }
        //Meteodo para mostrar una crypto mediante el Id
        [HttpGet("get-usuario-by-id")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _usuarioService.GetUsuarioById(id);
            return Ok(usuario);
        }
        //Metodo para agregar una nueva crypto
        [HttpPost("add-usuario")]
        public IActionResult AddUsuarios([FromBody] UsuarioVM usuario)
        {
            _usuarioService.AddUsuarios(usuario);
            return Ok();
        }
        //Metodo que te permite actualizar una crypto mediante su Id
        [HttpPut("updatae-usuario-by-id/{id}")]
        public IActionResult UpdateUsuarioById(int id, [FromBody] UsuarioVM usuario)
        {
            var updateusuario = _usuarioService.UpdateUsuarioById(id, usuario);
            return Ok(updateusuario);
        }
        //Metodo que te permite eliminar una cripto mediante su id
        [HttpDelete("delete-usuario-by-id")]
        public IActionResult DeleteUsuarioById(int id)
        {
            _usuarioService.DeleteUsuarioById(id);
            return Ok();
        }
    }
}
