using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Pago;

namespace API_PetCare_Connect.Validators.Pago;

public class CrearPagoDtoValidator : AbstractValidator<CrearPagoDto>
{
    public CrearPagoDtoValidator()
    {
        RuleFor(x => x.MontoPago)
            .GreaterThan(0)
            .WithMessage("El monto del pago debe ser mayor a cero.");

        RuleFor(x => x.ReferenciaPago)
            .MaximumLength(50);

        RuleFor(x => x.ObservacionesPago)
            .MaximumLength(200);

        RuleFor(x => x.IdFactura)
            .GreaterThan(0)
            .WithMessage("La factura es obligatoria.");

        RuleFor(x => x.IdMetodoPago)
            .GreaterThan(0)
            .WithMessage("El método de pago es obligatorio.");
    }
}
