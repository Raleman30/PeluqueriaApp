using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApp.Negocio.Interfaces;

namespace PeluqueriaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaNegocio _repositorio;

        public CitaController(ICitaNegocio repositorio)
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
