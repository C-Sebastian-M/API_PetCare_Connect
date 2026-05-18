using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Consultum
{
    public int IdConsulta { get; set; }

    public DateTime FechaConsulta { get; set; }

    public string? MotivoConsulta { get; set; }

    public string? Sintomas { get; set; }

    public string? DiagnosticoConsulta { get; set; }

    public string? TratamientoConsulta { get; set; }

    public string? ObservacionesConsulta { get; set; }

    public decimal? PesoMascota { get; set; }

    public decimal? TemperaturaMascota { get; set; }

    public int? FrecuenciaCardiaca { get; set; }

    public int? IdCita { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdMascota { get; set; }

    public DateTime FechaRegistroConsulta { get; set; }

    public DateTime? FechaModificacionConsulta { get; set; }

    public virtual ICollection<ConsultaTratamiento> ConsultaTratamientos { get; set; } = new List<ConsultaTratamiento>();

    public virtual Citum? IdCitaNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Mascotum? IdMascotaNavigation { get; set; }

    public virtual ICollection<ResultadoExaman> ResultadoExamen { get; set; } = new List<ResultadoExaman>();

    public virtual ICollection<Diagnostico> IdDiagnosticos { get; set; } = new List<Diagnostico>();
}
