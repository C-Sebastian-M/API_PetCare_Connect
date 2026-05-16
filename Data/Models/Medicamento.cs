using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Medicamento
{
    public int IdMedicamento { get; set; }

    public string NombreMedicamento { get; set; } = null!;

    public string? Concentracion { get; set; }

    public string? Presentacion { get; set; }

    public string? Laboratorio { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string? DescripcionMedicamento { get; set; }

    public int? IdProducto { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
