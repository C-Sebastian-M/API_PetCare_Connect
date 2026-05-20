using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Empleado;

namespace API_PetCare_Connect.Validators.Empleado;

public class CrearEmpleadoDtoValidator : AbstractValidator<CrearEmpleadoDto>
{
    public CrearEmpleadoDtoValidator()
    {
        RuleFor(x => x.DniEmpleado)
            .NotEmpty()
            .WithMessage("El DNI es obligatorio.")
            .MaximumLength(20);

        RuleFor(x => x.NombreEmpleado)
            .NotEmpty()
            .WithMessage("El nombre es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.ApellidoEmpleado)
            .NotEmpty()
            .WithMessage("El apellido es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.TelefonoEmpleado)
            .MaximumLength(20);

        RuleFor(x => x.CorreoEmpleado)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoEmpleado))
            .WithMessage("El correo no es válido.");

        RuleFor(x => x.DireccionEmpleado)
            .MaximumLength(200);

        RuleFor(x => x.CiudadEmpleado)
            .MaximumLength(100);

        RuleFor(x => x.IdRol)
            .GreaterThan(0)
            .WithMessage("El rol es obligatorio.");

        RuleFor(x => x.IdSede)
            .GreaterThan(0)
            .WithMessage("La sede es obligatoria.");
    }
}
