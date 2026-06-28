using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface IEstilistaRepositorio
    {
        Task<List<Estilista>> Listar();
        Task<Estilista> Agregar(Estilista estilista);
        Task<Estilista?> Actualizar(int id, Estilista estilista);
        Task<bool> Eliminar(int id);
    }
}
