using GestionmedicaAPI.Dtos.Request;
using GestionmedicaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionmedicaAPI.Apiweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Turnoscontroller : ControllerBase
    {
        private readonly Iturnoservice _Service;

        public Turnoscontroller(Iturnoservice service)
        {
            _Service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<TurnoGet>>> Listar()
        {
            var turno = await _Service.Listar();
            return Ok(turno);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<TurnoGet>>> Obtenerporid(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var turno = _Service.Get(id);
            return Ok(turno);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Actualizar([FromRoute] int id, [FromBody] TurnoPUTrequest dto)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var actualizar = await _Service.Actualizarturno(dto,id);
            if (!actualizar)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar([FromRoute] int id)
        {
            var buscar = await _Service.Eliminarturno(id);
            if (!buscar)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
