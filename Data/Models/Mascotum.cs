using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Mascotum
{
    public int IdMascota { get; set; }

    public string NombreMascota { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string? SexoMascota { get; set; }

    public string? ColorMascota { get; set; }

    public decimal? PesoActual { get; set; }

    public bool? Esterilizado { get; set; }

    public string? ObservacionesGenerales { get; set; }

    public string? EstadoMascota { get; set; }

    public int? IdRaza { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEspecie { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual ICollection<Hospitalizacion> Hospitalizacions { get; set; } = new List<Hospitalizacion>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Especie? IdEspecieNavigation { get; set; }

    public virtual Raza? IdRazaNavigation { get; set; }

    public virtual ICollection<MascotaAlergium> MascotaAlergia { get; set; } = new List<MascotaAlergium>();

    public virtual ICollection<VacunaMascotum> VacunaMascota { get; set; } = new List<VacunaMascotum>();
}
