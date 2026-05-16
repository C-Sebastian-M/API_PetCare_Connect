using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Vacuna
{
    public int IdVacuna { get; set; }

    public string NombreVacuna { get; set; } = null!;

    public string? DescripcionVacuna { get; set; }

    public string? DosisRecomendada { get; set; }

    public string? FrecuenciaAplicacion { get; set; }

    public virtual ICollection<VacunaMascotum> VacunaMascota { get; set; } = new List<VacunaMascotum>();
}
