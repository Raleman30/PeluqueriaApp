using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface IEspecialidadRepositorio
    {
        Task<List<Especialidad>> Listar();
        Task<Especialidad> Agregar(Especialidad especialidad);
        Task<Especialidad?> Actualizar(int id, Especialidad especialidad);
        Task<bool> Eliminar(int id);
    }
}
