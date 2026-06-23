using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PeluqueriaApp.Repositorio.Implementaciones
{
    public class EstilistaRepositorio
    {
        private readonly CitasPeluqueriaContext _bd;

        public EstilistaRepositorio(CitasPeluqueriaContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Estilista>> Listar()
        {
            return await _bd.Estilistas.Where(p => p.Activo).ToListAsync();
        }
    }
}
