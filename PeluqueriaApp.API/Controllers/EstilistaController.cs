using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;

namespace PeluqueriaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstilistaController : ControllerBase
    {
        private readonly IEstilistaNegocio _repositorio;

        public EstilistaController(IEstilistaNegocio repositorio)
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
        public async Task<IActionResult> Agregar([FromBody] Estilista estilista)
        {
            var resultado = await _repositorio.Agregar(estilista);
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, [FromBody] Estilista estilista)
        {
            var resultado = await _repositorio.Actualizar(id, estilista);
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