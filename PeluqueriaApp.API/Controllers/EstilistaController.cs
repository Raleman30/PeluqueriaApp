using Microsoft.AspNetCore.Http;
using PeluqueriaApp.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    }
}