using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class ConsultaTratamiento
{
    public int IdConsulta { get; set; }

    public int IdTratamiento { get; set; }

    public string? Indicaciones { get; set; }

    public int? DuracionDias { get; set; }

    public virtual Consultum IdConsultaNavigation { get; set; } = null!;

    public virtual Tratamiento IdTratamientoNavigation { get; set; } = null!;
}
