using System;
using System.Collections.Generic;

namespace API_PetCare_Connect.Data.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string DniCliente { get; set; } = null!;

    public string NombreCliente { get; set; } = null!;

    public string ApellidoCliente { get; set; } = null!;

    public string? TelefonoCliente { get; set; }

    public string? CorreoCliente { get; set; }

    public string? DireccionCliente { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? EstadoCliente { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Mascotum> Mascota { get; set; } = new List<Mascotum>();
}
