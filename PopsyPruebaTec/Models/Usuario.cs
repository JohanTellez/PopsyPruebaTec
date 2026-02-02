using System;
using System.Collections.Generic;

namespace PopsyPruebaTec.Models;

public partial class Usuario
{
    public int? Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? FechaCreación { get; set; }
}
