using FluentValidation;
using API_PetCare_Connect.DTOs.Empleado;

namespace API_PetCare_Connect.Validators.Empleado
{
    public class ActualizarEmpleadoDtoValidator
        : AbstractValidator<ActualizarEmpleadoDto>
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

            RuleFor(x => x.EstadoEmpleado)
                .Must(EstadoValido)
                .When(x => !string.IsNullOrWhiteSpace(x.EstadoEmpleado))
                .WithMessage("El estado debe ser Activo o Inactivo.");

            RuleFor(x => x.IdRol)
                .GreaterThan(0);

            RuleFor(x => x.IdSede)
                .GreaterThan(0);
        }

        private bool EstadoValido(string? estado)
        {
            return estado?.ToLower() switch
            {
                "activo" => true,
                "inactivo" => true,
                _ => false
            };
        }
    }
}