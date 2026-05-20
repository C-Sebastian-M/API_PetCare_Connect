using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Proveedor;

namespace API_PetCare_Connect.Validators.Proveedor;

public class CrearProveedorDtoValidator : AbstractValidator<CrearProveedorDto>
{
    public CrearProveedorDtoValidator()
    {
        RuleFor(x => x.NombreProveedor)
            .NotEmpty()
            .WithMessage("El nombre del proveedor es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.TelefonoProveedor)
            .MaximumLength(20);

        RuleFor(x => x.CorreoProveedor)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoProveedor))
            .WithMessage("El correo no es válido.");

        RuleFor(x => x.DireccionProveedor)
            .MaximumLength(200);

        RuleFor(x => x.CiudadProveedor)
            .MaximumLength(100);

        RuleFor(x => x.NombreContacto)
            .MaximumLength(100);

        RuleFor(x => x.TelefonoContacto)
            .MaximumLength(20);
    }
}