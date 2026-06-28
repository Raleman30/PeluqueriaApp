using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Interfaces
{
    public interface IEspecialidadNegocio
    {
        Task<List<Especialidad>> Listar();
        Task<Especialidad> Agregar(Especialidad especialidad);
        Task<Especialidad?> Actualizar(int id, Especialidad especialidad);
        Task<bool> Eliminar(int id);
    }
}
