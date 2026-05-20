using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Factura;

namespace API_PetCare_Connect.Validators.Factura;

public class CrearFacturaDtoValidator : AbstractValidator<CrearFacturaDto>
{
    public CrearFacturaDtoValidator()
    {
        RuleFor(x => x.FechaFactura)
            .NotEmpty()
            .WithMessage("La fecha de la factura es obligatoria.");

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
            .GreaterThan(0)
            .WithMessage("El cliente es obligatorio.");

        RuleFor(x => x.IdEmpleado)
            .GreaterThan(0)
            .WithMessage("El empleado es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}