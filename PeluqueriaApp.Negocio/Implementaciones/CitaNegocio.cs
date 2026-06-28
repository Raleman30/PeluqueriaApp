using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;
using PeluqueriaApp.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Implementaciones
{
    public class CitaNegocio : ICitaNegocio
    {
        private readonly ICitaRepositorio _repositorio;

        public CitaNegocio(ICitaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Cita>> Listar()
        {
            var resultado = await _repositorio.Listar();
            return resultado;
        }
        public async Task<Cita> Agregar(Cita cita)
        {
            return await _repositorio.Agregar(cita);
        }

        public async Task<Cita?> Actualizar(int id, Cita cita)
        {
            return await _repositorio.Actualizar(id, cita);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _repositorio.Eliminar(id);
        }

    }
}
