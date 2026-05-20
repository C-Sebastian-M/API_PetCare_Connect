using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Sede;

namespace API_PetCare_Connect.Validators.Sede;

public class ActualizarSedeDtoValidator : AbstractValidator<ActualizarSedeDto>
{
    public ActualizarSedeDtoValidator()
    {
        RuleFor(x => x.NombreSede)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.TelefonoSede)
            .MaximumLength(20);

        RuleFor(x => x.CorreoSede)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoSede));

        RuleFor(x => x.DireccionSede)
            .MaximumLength(200);

        RuleFor(x => x.CiudadSede)
            .MaximumLength(100);

        RuleFor(x => x.EstadoSede)
            .Must(x =>
                string.Equals(x, "Activo", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x, "Inactivo", StringComparison.OrdinalIgnoreCase))
            .When(x => !string.IsNullOrWhiteSpace(x.EstadoSede));
    }
}