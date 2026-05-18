using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public decimal? SubtotalFactura { get; set; }

    public decimal? ImpuestosFactura { get; set; }

    public decimal? TotalFactura { get; set; }

    public string? EstadoFactura { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdSede { get; set; }

    public DateTime FechaRegistroFactura { get; set; }

    public DateTime? FechaModificacionFactura { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Sede? IdSedeNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
