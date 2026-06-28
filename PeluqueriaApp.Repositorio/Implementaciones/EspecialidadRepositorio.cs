using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PeluqueriaApp.Repositorio.Interfaces;

namespace PeluqueriaApp.Repositorio.Implementaciones
{
    public class EspecialidadRepositorio : IEspecialidadRepositorio
    {
        private readonly CitasPeluqueriaContext _bd;

        public EspecialidadRepositorio(CitasPeluqueriaContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Especialidad>> Listar()
        {
            return await _bd.Especialidads.Where(p => p.Activo).ToListAsync();
        }
    }
}
