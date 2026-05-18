using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Raza
{
    public int IdRaza { get; set; }

    public string NombreRaza { get; set; } = null!;

    public int? IdEspecie { get; set; }

    public string? DescripcionRaza { get; set; }

    public DateTime FechaRegistroRaza { get; set; }

    public DateTime? FechaModificacionRaza { get; set; }

    public virtual Especie? IdEspecieNavigation { get; set; }

    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();
}
