using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;
using PeluqueriaApp.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Implementaciones
{
    public class EstilistaNegocio : IEstilistaNegocio
    {
        private readonly IEstilistaRepositorio _repositorio;

        public EstilistaNegocio(IEstilistaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Estilista>> Listar()
        {
            var resultado = await _repositorio.Listar();
            return resultado;
        }
    }
}
