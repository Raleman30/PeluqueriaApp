using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface ICitaRepositorio
    {
        Task<List<Cita>> Listar();
        Task<Cita> Agregar(Cita cita);
        Task<Cita?> Actualizar(int id, Cita cita);
        Task<bool> Eliminar(int id);
    }
}
