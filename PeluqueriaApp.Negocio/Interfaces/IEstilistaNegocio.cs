using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Interfaces
{
    public interface IEstilistaNegocio
    {
        Task<List<Estilista>> Listar();
        Task<Estilista> Agregar(Estilista estilista);
        Task<Estilista?> Actualizar(int id, Estilista estilista);
        Task<bool> Eliminar(int id);
    }
}
