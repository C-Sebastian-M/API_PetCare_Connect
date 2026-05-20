using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Factura;

namespace API_PetCare_Connect.Validators.Factura;

public class ActualizarFacturaDtoValidator : AbstractValidator<ActualizarFacturaDto>
{
    public ActualizarFacturaDtoValidator()
    {
        RuleFor(x => x.FechaFactura)
            .NotEmpty();

        RuleFor(x => x.SubtotalFactura)
            .GreaterThanOrEqualTo(0)
            .When(x => x.SubtotalFactura.HasValue);

        RuleFor(x => x.ImpuestosFactura)
            .GreaterThanOrEqualTo(0)
            .When(x => x.ImpuestosFactura.HasValue);

        RuleFor(x => x.TotalFactura)
            .GreaterThanOrEqualTo(0)
            .When(x => x.TotalFactura.HasValue);

        RuleFor(x => x.IdCliente)
            .GreaterThan(0);

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0);

        RuleFor(x => x.IdSede)
            .GreaterThan(0);

        RuleFor(x => x.EstadoFactura)
            .Must(x =>
                string.Equals(x, "Pendiente", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Pagada", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Anulada", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoFactura));
    }
}