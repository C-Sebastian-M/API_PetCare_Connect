using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class MascotaAlergium
{
    public int IdMascota { get; set; }

    public int IdAlergia { get; set; }

    public string? NivelGravedad { get; set; }

    public string? Observaciones { get; set; }

    public virtual Alergium IdAlergiaNavigation { get; set; } = null!;

    public virtual Mascotum IdMascotaNavigation { get; set; } = null!;
}
