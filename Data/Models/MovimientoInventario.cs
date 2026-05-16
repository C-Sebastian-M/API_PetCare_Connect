using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class MovimientoInventario
{
    public int IdMovimiento { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string? TipoMovimiento { get; set; }

    public int CantidadMovimiento { get; set; }

    public string? MotivoMovimiento { get; set; }

    public int? IdProducto { get; set; }

    public int? IdSede { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }
}
