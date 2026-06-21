using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeluqueriaApp.Negocio.Interfaces;

namespace PeluqueriaApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteNegocio _repositorio;

        public ClienteController(IClienteNegocio repositorio)
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
