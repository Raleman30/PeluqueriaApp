using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Interfaces
{
    public interface IEspecialidadNegocio
    {
        Task<List<Especialidad>> Listar();
    }
}
