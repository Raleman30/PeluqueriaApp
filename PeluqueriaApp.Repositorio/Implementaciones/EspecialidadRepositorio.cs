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
        public async Task<Especialidad> Agregar(Especialidad especialidad)
        {
            especialidad.Activo = true;
            especialidad.FechaCreacion = DateTime.Now;
            _bd.Especialidads.Add(especialidad);
            await _bd.SaveChangesAsync();
            return especialidad;
        }

        public async Task<Especialidad?> Actualizar(int id, Especialidad especialidad)
        {
            var existente = await _bd.Especialidads.FindAsync(id);
            if (existente == null) return null;

            existente.Nombre = especialidad.Nombre;

            await _bd.SaveChangesAsync();
            return existente;
        }

        public async Task<bool> Eliminar(int id)
        {
            var especialidad = await _bd.Especialidads.FindAsync(id);
            if (especialidad == null) return false;

            especialidad.Activo = false;
            await _bd.SaveChangesAsync();
            return true;
        }
    }
}
