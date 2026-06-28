using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<Cliente>> Listar();
        Task<Cliente> Agregar(Cliente cliente);
        Task<Cliente?> Actualizar(int id, Cliente cliente);
        Task<bool> Eliminar(int id);
    }
}
