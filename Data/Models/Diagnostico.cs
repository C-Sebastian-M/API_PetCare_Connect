using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Diagnostico
{
    public int IdDiagnostico { get; set; }

    public string NombreDiagnostico { get; set; } = null!;

    public string? DescripcionDiagnostico { get; set; }

    public virtual ICollection<Consultum> IdConsulta { get; set; } = new List<Consultum>();
}
