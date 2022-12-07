using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAWOS.Data.Services;
using ProyectoAWOS.Data.ViewModels;

namespace ProyectoAWOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoUsuarioController : ControllerBase
    {
        public UsuarioCryptoService _usuariocryptosService;
        public CryptoUsuarioController(UsuarioCryptoService usuariocryptosService)
        {
            _usuariocryptosService = usuariocryptosService;
        }
        //Metodo para mostrar todos los registros en la tabla CryptoUsuario
        [HttpGet("get-all-cryptousuario")]
        public IActionResult GetAllCryptoUsuario()
        {
            var _allcryptousuario = _usuariocryptosService.GetAllCrypoUsuario();
            return Ok(_allcryptousuario);
        }
        //Meteodo para mostrar una crypto mediante el Id
        [HttpGet("get-usuariocrypto-by-id")]
        public IActionResult GetUsuarioCryptoById(int id)
        {
            var _cryptousuario = _usuariocryptosService.GetCryptoUsuarioById(id);
            return Ok(_cryptousuario);
        }
        //Metodo para agregar una nueva crypto
        [HttpPost("add-usuariocrypto")]
        public IActionResult AddCryptoUsuario([FromBody] UsuarioCryptoVM usuariocrypto)
        {
            _usuariocryptosService.AddCrypos(usuariocrypto);
            return Ok();
        }
        //Metodo que te permite actualizar una crypto mediante su Id
        [HttpPut("updatae-usuariocrypto-by-id/{id}")]
        public IActionResult UpdateUsuarioCryptoById(int id, [FromBody] UsuarioCryptoVM usuariocrypto)
        {
            var updateusuariocrypto = _usuariocryptosService.UpdateCryptoUsuarioById(id, usuariocrypto);
            return Ok(updateusuariocrypto);
        }
        //Metodo que te permite eliminar una cripto mediante su id
        [HttpDelete("delete-crypto-by-id")]
        public IActionResult DeleteUsuarioCryptoById(int id)
        {
            _usuariocryptosService.DeleteUsuarioCryptoById(id);
            return Ok();
        }
    }
}
