using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Examan
{
    public int IdExamen { get; set; }

    public string NombreExamen { get; set; } = null!;

    public string? DescripcionExamen { get; set; }

    public decimal? CostoExamen { get; set; }

    public virtual ICollection<ResultadoExaman> ResultadoExamen { get; set; } = new List<ResultadoExaman>();
}
