using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Interfaces
{
    public interface IEspecialidadRepositorio
    {
        Task<List<Especialidad>> Listar();
    }
}
