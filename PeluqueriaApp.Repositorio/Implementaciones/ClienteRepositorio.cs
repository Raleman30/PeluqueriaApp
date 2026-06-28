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
        public async Task<Cliente> Agregar(Cliente cliente)
        {
            cliente.Activo = true;
            cliente.FechaCreacion = DateTime.Now;
            _bd.Clientes.Add(cliente);
            await _bd.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente?> Actualizar(int id, Cliente cliente)
        {
            var clienteExistente = await _bd.Clientes.FindAsync(id);
            if (clienteExistente == null) return null;

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.Email = cliente.Email;

            await _bd.SaveChangesAsync();
            return clienteExistente;
        }

        public async Task<bool> Eliminar(int id)
        {
            var cliente = await _bd.Clientes.FindAsync(id);
            if (cliente == null) return false;

            cliente.Activo = false;
            await _bd.SaveChangesAsync();
            return true;
        }
    }
}