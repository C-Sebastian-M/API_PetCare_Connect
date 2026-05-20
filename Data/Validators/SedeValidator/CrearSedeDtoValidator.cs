using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Sede;

namespace API_PetCare_Connect.Validators.Sede;

public class CrearSedeDtoValidator : AbstractValidator<CrearSedeDto>
{
    public CrearSedeDtoValidator()
    {
        RuleFor(x => x.NombreSede)
            .NotEmpty()
            .WithMessage("El nombre de la sede es obligatorio.")
            .MaximumLength(100);

        RuleFor(x => x.TelefonoSede)
            .MaximumLength(20);

        RuleFor(x => x.CorreoSede)
            .EmailAddress()
            .When(x => !string.IsNullOrWhiteSpace(x.CorreoSede))
            .WithMessage("El correo no es válido.");

        RuleFor(x => x.DireccionSede)
            .MaximumLength(200);

        RuleFor(x => x.CiudadSede)
            .MaximumLength(100);
    }
}