using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Tratamiento
{
    public int IdTratamiento { get; set; }

    public string NombreTratamiento { get; set; } = null!;

    public string? DescripcionTratamiento { get; set; }

    public virtual ICollection<ConsultaTratamiento> ConsultaTratamientos { get; set; } = new List<ConsultaTratamiento>();
}
