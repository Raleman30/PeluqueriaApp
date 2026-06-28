using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;

namespace PeluqueriaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadNegocio _repositorio;

        public EspecialidadController(IEspecialidadNegocio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var resultado = await _repositorio.Listar();
            return Ok(resultado);
        }
        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody] Especialidad especialidad)
        {
            var resultado = await _repositorio.Agregar(especialidad);
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Especialidad especialidad)
        {
            var resultado = await _repositorio.Actualizar(id, especialidad);
            if (resultado == null) return NotFound();
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var resultado = await _repositorio.Eliminar(id);
            if (!resultado) return NotFound();
            return Ok(resultado);
        }
    }
}
