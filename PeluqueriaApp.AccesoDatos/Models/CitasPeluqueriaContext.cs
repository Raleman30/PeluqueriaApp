using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PeluqueriaApp.Entities;


namespace PeluqueriaApp.AccesoDatos.Models;

public partial class CitasPeluqueriaContext : DbContext
{
    public CitasPeluqueriaContext()
    {
    }

    public CitasPeluqueriaContext(DbContextOptions<CitasPeluqueriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cita> Cita { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Estilista> Estilistas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.CitaId);

            entity.Property(e => e.Estado).HasDefaultValue((byte)1, "DF_Cita_Estado");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_Cita_Fecha");
            entity.Property(e => e.HoraCita).HasPrecision(0);
            entity.Property(e => e.Notas).HasMaxLength(500);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Cita)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cita_Cliente");

            entity.HasOne(d => d.Estilista).WithMany(p => p.Cita)
                .HasForeignKey(d => d.EstilistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cita_Estilista");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.Activo).HasDefaultValue(true, "DF_Cliente_Activo");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_Cliente_Fecha");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Telefono).HasMaxLength(30);
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.ToTable("Especialidad");

            entity.HasIndex(e => e.Nombre, "UQ_Especialidad").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true, "DF_Especialidad_Activo");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_Especialidad_Fecha");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Estilista>(entity =>
        {
            entity.HasKey(e => e.EstilistaId);

            entity.Property(e => e.Activo).HasDefaultValue(true, "DF_Estilista_Activo");
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())", "DF_Estilista_Fecha");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Telefono).HasMaxLength(30);

            entity.HasOne(d => d.Especialidad).WithMany(p => p.Estilista)
                .HasForeignKey(d => d.EspecialidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Estilista_Especialidad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
