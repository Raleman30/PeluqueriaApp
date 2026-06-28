using PeluqueriaApp.AccesoDatos.Models;
using PeluqueriaApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PeluqueriaApp.Repositorio.Interfaces;


namespace PeluqueriaApp.Repositorio.Implementaciones
{
    public class EstilistaRepositorio : IEstilistaRepositorio
    {
        private readonly CitasPeluqueriaContext _bd;

        public EstilistaRepositorio(CitasPeluqueriaContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Estilista>> Listar()
        {
            return await _bd.Estilista.Where(p => p.Activo).ToListAsync();
        }
        public async Task<Estilista> Agregar(Estilista estilista)
        {
            estilista.Activo = true;
            estilista.FechaCreacion = DateTime.Now;
            _bd.Estilista.Add(estilista);
            await _bd.SaveChangesAsync();
            return estilista;
        }

        public async Task<Estilista?> Actualizar(int id, Estilista estilista)
        {
            var existente = await _bd.Estilista.FindAsync(id);
            if (existente == null) return null;

            existente.Nombre = estilista.Nombre;
            existente.Telefono = estilista.Telefono;
            existente.Email = estilista.Email;
            existente.EspecialidadId = estilista.EspecialidadId;

            await _bd.SaveChangesAsync();
            return existente;
        }

        public async Task<bool> Eliminar(int id)
        {
            var estilista = await _bd.Estilista.FindAsync(id);
            if (estilista == null) return false;

            estilista.Activo = false;
            await _bd.SaveChangesAsync();
            return true;
        }
    }
}
