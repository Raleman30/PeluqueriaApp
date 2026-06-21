using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Entities;
using PeluqueriaApp.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeluqueriaApp.Repositorio.Implementaciones
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly CitasPeluqueriaContext _bd;

        public ClienteRepositorio(CitasPeluqueriaContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Cliente>> Listar()
        {
            return await _bd.Clientes.Where(p => p.Activo).ToListAsync();
        }
    }
}