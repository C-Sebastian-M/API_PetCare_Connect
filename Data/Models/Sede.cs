using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Sede
{
    public int IdSede { get; set; }

    public string NombreSede { get; set; } = null!;

    public string? TelefonoSede { get; set; }

    public string? CorreoSede { get; set; }

    public string? DireccionSede { get; set; }

    public string? CiudadSede { get; set; }

    public string? EstadoSede { get; set; }

    public DateOnly? FechaApertura { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<InventarioSede> InventarioSedes { get; set; } = new List<InventarioSede>();

    public virtual ICollection<Jaula> Jaulas { get; set; } = new List<Jaula>();

    public virtual ICollection<LoteProducto> LoteProductos { get; set; } = new List<LoteProducto>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();
}
