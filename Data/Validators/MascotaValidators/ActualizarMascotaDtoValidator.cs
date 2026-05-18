using FluentValidation;
using API_PetCare_Connect.DTOs.Mascota;

namespace API_PetCare_Connect.Validators.Mascota
{
    public class ActualizarMascotaDtoValidator : AbstractValidator<ActualizarMascotaDto>
    {
        public ActualizarMascotaDtoValidator()
        {
            RuleFor(x => x.NombreMascota)
                .NotEmpty()
                .WithMessage("El nombre de la mascota es obligatorio.")
                .MaximumLength(100);

            RuleFor(x => x.SexoMascota)
                .Must(SexoValido)
                .When(x => !string.IsNullOrWhiteSpace(x.SexoMascota))
                .WithMessage("El sexo debe ser Macho o Hembra.");

            RuleFor(x => x.PesoActual)
                .GreaterThan(0)
                .When(x => x.PesoActual.HasValue)
                .WithMessage("El peso debe ser mayor a 0.");

            RuleFor(x => x.EstadoMascota)
                .Must(EstadoValido)
                .When(x => !string.IsNullOrWhiteSpace(x.EstadoMascota))
                .WithMessage("El estado debe ser Activo o Inactivo.");

            RuleFor(x => x.IdCliente)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un cliente válido.");

            RuleFor(x => x.IdEspecie)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una especie válida.");

            RuleFor(x => x.IdRaza)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una raza válida.");
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