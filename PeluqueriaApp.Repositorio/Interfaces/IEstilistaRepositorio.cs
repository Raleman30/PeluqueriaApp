using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface IEstilistaRepositorio
    {
        Task<List<Estilista>> Listar();
    }
}
