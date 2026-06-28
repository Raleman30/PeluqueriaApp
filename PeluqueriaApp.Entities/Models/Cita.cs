using System;
using System.Collections.Generic;

namespace PeluqueriaApp.Entities;

public partial class Cita
{
    public int CitaId { get; set; }

    public int ClienteId { get; set; }

    public int EstilistaId { get; set; }

    public DateOnly FechaCita { get; set; }

    public TimeOnly HoraCita { get; set; }

    public string? Notas { get; set; }

    public byte Estado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Cliente? Cliente { get; set; }
    public virtual Estilista? Estilista { get; set; }
}
