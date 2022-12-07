using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAWOS.Data.Services;
using ProyectoAWOS.Data.ViewModels;

namespace ProyectoAWOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisasController : ControllerBase
    {
        public DivisasService _divisasService;
        public DivisasController(DivisasService divisasService)
        {
            _divisasService = divisasService;
        }
        //Metodo para mostrar todos los registros en la tabla Cryptos
        [HttpGet("get-all-divisas")]
        public IActionResult GetAllDivisas()
        {
            var _alldivisas = _divisasService.GetAllDivisas();
            return Ok(_alldivisas);
        }
        //Meteodo para mostrar una crypto mediante el Id
        [HttpGet("get-divisas-by-id")]
        public IActionResult GetDivisasById(int id)
        {
            var divisas = _divisasService.GetDivisasById(id);
            return Ok(divisas);
        }
        //Metodo para agregar una nueva crypto
        [HttpPost("add-divisas")]
        public IActionResult AddDivisas([FromBody] DivisasVM divisas)
        {
            _divisasService.AddDivisas(divisas);
            return Ok();
        }
        //Metodo que te permite actualizar una crypto mediante su Id
        [HttpPut("updatae-divisas-by-id/{id}")]
        public IActionResult UpdateDivisasById(int id, [FromBody] DivisasVM divisas)
        {
            var updatedivisas = _divisasService.UpdateDivisasById(id, divisas);
            return Ok(updatedivisas);
        }
        //Metodo que te permite eliminar una cripto mediante su id
        [HttpDelete("delete-divisas-by-id")]
        public IActionResult DeleteDivisasById(int id)
        {
            _divisasService.DeleteDivisasById(id);
            return Ok();
        }
    }
}
