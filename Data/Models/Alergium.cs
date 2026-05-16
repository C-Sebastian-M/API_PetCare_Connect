using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Alergium
{
    public int IdAlergia { get; set; }

    public string NombreAlergia { get; set; } = null!;

    public string? DescripcionAlergia { get; set; }

    public virtual ICollection<MascotaAlergium> MascotaAlergia { get; set; } = new List<MascotaAlergium>();
}
