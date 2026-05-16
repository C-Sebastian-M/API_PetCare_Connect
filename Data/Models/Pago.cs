using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Pago
{
    public int IdPago { get; set; }

    public DateTime FechaPago { get; set; }

    public decimal MontoPago { get; set; }

    public string? ReferenciaPago { get; set; }

    public string? ObservacionesPago { get; set; }

    public string? EstadoPago { get; set; }

    public int? IdFactura { get; set; }

    public int? IdMetodoPago { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual MetodoPago? IdMetodoPagoNavigation { get; set; }
}
