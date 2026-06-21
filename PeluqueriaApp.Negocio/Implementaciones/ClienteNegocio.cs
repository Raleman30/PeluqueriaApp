using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;
using PeluqueriaApp.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Implementaciones
{
    public class ClienteNegocio : IClienteNegocio
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteNegocio(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Cliente>> Listar()
        {
            var resultado = await _repositorio.Listar();
            return resultado;
        }
    }
}
