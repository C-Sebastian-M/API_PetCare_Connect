using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Especie
{
    public int IdEspecie { get; set; }

    public string NombreEspecie { get; set; } = null!;

    public DateTime FechaRegistroEspecie { get; set; }

    public DateTime? FechaModificacionEspecie { get; set; }

    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();

    public virtual ICollection<Raza> Razas { get; set; } = new List<Raza>();
}
