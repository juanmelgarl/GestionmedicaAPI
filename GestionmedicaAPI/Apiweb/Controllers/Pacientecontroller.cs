using GestionmedicaAPI.Dtos.Request;
using GestionmedicaAPI.Dtos.Response;
using GestionmedicaAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionmedicaAPI.Apiweb.Controllers
{
    [Route("api/v1/pacientes")]
    [ApiController]
    public class Pacientecontroller : ControllerBase
    {
        private readonly Ipacienteservice _Servicio;

        public Pacientecontroller(Ipacienteservice ipacienteservice)
        {
             _Servicio = ipacienteservice;
        }
        [HttpGet]
        public async Task<ActionResult<List<_PacienteGet>>> Listar()
        {
            var paciente = await _Servicio.Listar();
            return Ok(paciente);
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<List<_PacienteGet>>> Obtenerporid(int id)
        {
            if (id <= 0)
            {
                return BadRequest("el id no puede ser 0 ");
            }
            var paciente = await _Servicio.Get(id);
            if (paciente == null)
                return NotFound("no se encontro al paciente");

            return Ok(paciente);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Actualizar([FromRoute] int id, [FromBody] PacientePUTrequest dto)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var actualizado = await _Servicio.Actualizarpaciente(dto,id);
            if (!actualizado)
            {
                return NotFound();
            }
            /**/
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest("El id debe ser mayor a 0");

            var eliminado = await _Servicio.Eliminarpaciente(id);

            if (!eliminado)
                return NotFound("Producto no encontrado");

            return Ok("Producto eliminado correctamente");
        }
    }
}
