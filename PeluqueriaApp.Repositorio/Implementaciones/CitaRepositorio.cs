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
            return await _bd.Cita.Where(p => p.Estado == 1).ToListAsync();
        }
        public async Task<Cita> Agregar(Cita cita)
        {
            cita.FechaCreacion = DateTime.Now;
            cita.Estado = 1;
            _bd.Cita.Add(cita);
            await _bd.SaveChangesAsync();
            return cita;
        }

        public async Task<Cita?> Actualizar(int id, Cita cita)
        {
            var existente = await _bd.Cita.FindAsync(id);
            if (existente == null) return null;

            existente.ClienteId = cita.ClienteId;
            existente.EstilistaId = cita.EstilistaId;
            existente.FechaCita = cita.FechaCita;
            existente.HoraCita = cita.HoraCita;
            existente.Notas = cita.Notas;
            existente.Estado = cita.Estado;

            await _bd.SaveChangesAsync();
            return existente;
        }

        public async Task<bool> Eliminar(int id)
        {
            var cita = await _bd.Cita.FindAsync(id);
            if (cita == null) return false;

            cita.Estado = 2;
            await _bd.SaveChangesAsync();
            return true;
        }
    }
}
