using FluentValidation;
using API_PetCare_Connect.Data.DTOs.Cliente;

namespace API_PetCare_Connect.Validators.Cliente
{
    public class CrearClienteDtoValidator : AbstractValidator<CrearClienteDto>
    {
        public CrearClienteDtoValidator()
        {
            RuleFor(x => x.DniCliente)
                .NotEmpty()
                .WithMessage("El DNI es obligatorio.")
                .MaximumLength(20);

            RuleFor(x => x.NombreCliente)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(100);

            RuleFor(x => x.ApellidoCliente)
                .NotEmpty()
                .WithMessage("El apellido es obligatorio.")
                .MaximumLength(100);

            RuleFor(x => x.TelefonoCliente)
                .MaximumLength(20);

            RuleFor(x => x.CorreoCliente)
                .EmailAddress()
                .When(x => !string.IsNullOrWhiteSpace(x.CorreoCliente))
                .WithMessage("El correo no es válido.");

            RuleFor(x => x.DireccionCliente)
                .MaximumLength(200);
        }
    }
}