using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAWOS.Data.Services;
using ProyectoAWOS.Data.ViewModels;

namespace ProyectoAWOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        public CryptosService _cryptosService;
        public CryptoController(CryptosService cryptosService) 
        {
            _cryptosService = cryptosService;      
        }
        //Metodo para mostrar todos los registros en la tabla Cryptos
        [HttpGet("get-all-cryptos")]
        public IActionResult GetAllCrypto()
        {
            var _allcryptos = _cryptosService.GetAllCryptos();
            return Ok(_allcryptos);
        }
        //Meteodo para mostrar una crypto mediante el Id
        [HttpGet("get-crypto-by-id")]
        public IActionResult GetCryptoById(int id) 
        {
            var crypto = _cryptosService.GetCryptosById(id);
            return Ok(crypto);
        }
        //Metodo para agregar una nueva crypto
        [HttpPost("add-crypto")]
        public IActionResult AddCrypto([FromBody] CryptosVM crypto)
        {
            _cryptosService.AddCryptos(crypto);
            return Ok();
        }
        //Metodo que te permite actualizar una crypto mediante su Id
        [HttpPut("updatae-crypto-by-id/{id}")]
        public IActionResult UpdateCryptoById(int id, [FromBody] CryptosVM crypto)
        {
            var updatecrypto = _cryptosService.UpdateCryptoById(id, crypto);
            return Ok(updatecrypto);
        }
        //Metodo que te permite eliminar una cripto mediante su id
        [HttpDelete("delete-crypto-by-id")]
        public IActionResult DeleteCryptoById(int id) 
        {
            _cryptosService.DeleteCryptoById(id);
            return Ok();
        }
    }
}
