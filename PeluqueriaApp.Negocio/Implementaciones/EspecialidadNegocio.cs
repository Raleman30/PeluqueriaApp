using PeluqueriaApp.Entities;
using PeluqueriaApp.Negocio.Interfaces;
using PeluqueriaApp.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Implementaciones
{
    public class EspecialidadNegocio : IEspecialidadNegocio
    {
        private readonly IEspecialidadRepositorio _repositorio;

        public EspecialidadNegocio(IEspecialidadRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<List<Especialidad>> Listar()
        {
            var resultado = await _repositorio.Listar();
            return resultado;
        }
        public async Task<Especialidad> Agregar(Especialidad especialidad)
        {
            return await _repositorio.Agregar(especialidad);
        }

        public async Task<Especialidad?> Actualizar(int id, Especialidad especialidad)
        {
            return await _repositorio.Actualizar(id, especialidad);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _repositorio.Eliminar(id);
        }
    }
}
