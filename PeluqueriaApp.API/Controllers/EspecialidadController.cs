using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
