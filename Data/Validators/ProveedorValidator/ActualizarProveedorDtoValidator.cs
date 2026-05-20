using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Proveedor;

namespace API_PetCare_Connect.Validators.Proveedor;

public class ActualizarProveedorDtoValidator : AbstractValidator<ActualizarProveedorDto>
{
    public ActualizarProveedorDtoValidator()
    {
        RuleFor(x => x.NombreProveedor)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.TelefonoProveedor)
            .MaximumLength(20);

        RuleFor(x => x.CorreoProveedor)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoProveedor));

        RuleFor(x => x.DireccionProveedor)
            .MaximumLength(200);

        RuleFor(x => x.CiudadProveedor)
            .MaximumLength(100);

        RuleFor(x => x.NombreContacto)
            .MaximumLength(100);

        RuleFor(x => x.TelefonoContacto)
            .MaximumLength(20);

        RuleFor(x => x.EstadoProveedor)
            .Must(x =>
                string.Equals(x, "Activo", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Inactivo", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoProveedor));
    }
}