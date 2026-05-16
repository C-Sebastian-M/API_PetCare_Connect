using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class ResultadoExaman
{
    public int IdResultadoExamen { get; set; }

    public string? ResultadoExamen { get; set; }

    public DateTime? FechaResultado { get; set; }

    public string? Observaciones { get; set; }

    public int? IdExamen { get; set; }

    public int? IdConsulta { get; set; }

    public virtual Consultum? IdConsultaNavigation { get; set; }

    public virtual Examan? IdExamenNavigation { get; set; }
}
