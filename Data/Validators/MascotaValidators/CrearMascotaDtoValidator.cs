using FluentValidation;
using API_PetCare_Connect.DTOs.Mascota;

namespace API_PetCare_Connect.Validators.Mascota
{
    public class CrearMascotaDtoValidator : AbstractValidator<CrearMascotaDto>
    {
        public CrearMascotaDtoValidator()
        {
            RuleFor(x => x.NombreMascota)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.SexoMascota)
                .Must(SexoValido)
                .When(x => !string.IsNullOrWhiteSpace(x.SexoMascota))
                .WithMessage("El sexo debe ser Macho o Hembra.");

            RuleFor(x => x.PesoActual)
                .GreaterThan(0)
                .When(x => x.PesoActual.HasValue);

            RuleFor(x => x.IdCliente)
                .GreaterThan(0);

            RuleFor(x => x.IdEspecie)
                .GreaterThan(0);

            RuleFor(x => x.IdRaza)
                .GreaterThan(0);
        }

        private bool SexoValido(string? sexo)
        {
            return sexo?.ToLower() switch
            {
                "macho" => true,
                "hembra" => true,
                _ => false
            };
        }
    }
}