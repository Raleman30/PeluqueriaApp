using System;
using System.Collections.Generic;

namespace PeluqueriaApp.Entities;

public partial class Especialidad
{
    public int EspecialidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<Estilista> Estilista { get; set; } = new List<Estilista>();
}
