using System;
using System.Collections.Generic;

namespace PeluqueriaApp.Entities;

public partial class Estilista
{
    public int EstilistaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int EspecialidadId { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    public virtual Especialidad? Especialidad { get; set; }
}
