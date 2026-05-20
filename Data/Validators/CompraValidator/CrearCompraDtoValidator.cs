using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Compra;

namespace API_PetCare_Connect.Validators.Compra;

public class CrearCompraDtoValidator : AbstractValidator<CrearCompraDto>
{
    public CrearCompraDtoValidator()
    {
        RuleFor(x => x.FechaCompra)
            .NotEmpty()
            .WithMessage("La fecha de la compra es obligatoria.");

        RuleFor(x => x.NumeroFacturaProveedor)
            .MaximumLength(50);

        RuleFor(x => x.TotalCompra)
            .GreaterThanOrEqualTo(0)
            .When(x => x.TotalCompra.HasValue);

        RuleFor(x => x.IdProveedor)
            .GreaterThan(0)
            .WithMessage("El proveedor es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}