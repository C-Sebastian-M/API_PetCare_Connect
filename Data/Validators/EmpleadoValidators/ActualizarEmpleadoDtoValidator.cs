using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Empleado;

namespace API_PetCare_Connect.Validators.Empleado;

public class ActualizarEmpleadoDtoValidator : AbstractValidator<ActualizarEmpleadoDto>
{
    public ActualizarEmpleadoDtoValidator()
    {
        RuleFor(x => x.DniEmpleado)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(x => x.NombreEmpleado)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.ApellidoEmpleado)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.TelefonoEmpleado)
            .MaximumLength(20);

        RuleFor(x => x.CorreoEmpleado)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoEmpleado));

        RuleFor(x => x.DireccionEmpleado)
            .MaximumLength(200);

        RuleFor(x => x.CiudadEmpleado)
            .MaximumLength(100);

        RuleFor(x => x.IdRol)
            .GreaterThan(0);

        RuleFor(x => x.IdSede)
            .GreaterThan(0);

        RuleFor(x => x.EstadoEmpleado)
            .Must(x =>
                string.Equals(x, "Activo", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Inactivo", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoEmpleado));
    }
}
