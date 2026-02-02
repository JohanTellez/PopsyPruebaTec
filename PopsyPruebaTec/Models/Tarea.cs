using System;
using System.Collections.Generic;

namespace PopsyPruebaTec.Models;

public partial class Tarea
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime? FechaCreación { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string? Rol { get; set; }
}
