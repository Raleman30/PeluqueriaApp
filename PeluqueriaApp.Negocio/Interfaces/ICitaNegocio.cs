using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Negocio.Interfaces
{
    public interface ICitaNegocio
    {
        Task<List<Cita>> Listar();
    }
}
