using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Entities;
using PeluqueriaApp.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Implementaciones
{
    public class CitaRepositorio : ICitaRepositorio
    {
        private readonly CitasPeluqueriaContext _bd;

        public CitaRepositorio(CitasPeluqueriaContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Cita>> Listar()
        {
            return await _bd.Cita.ToListAsync();
        }
    }
}
