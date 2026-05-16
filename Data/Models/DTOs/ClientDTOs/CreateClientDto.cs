using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_PetCare_Connect.Data.Models.DTOs.ClientDTOs
{
    public class CreateClientDto
    {
        [Required (ErrorMessage = "El DNI es obligatorio.")]
        [MaxLength (20, ErrorMessage = "El DNI El nombre no puede tener más de 20 caracteres.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El DNI debe contener solo números.")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "El DNI debe tener entre 8 y 20 caracteres.")]
        public string Dni { get; set; } = null!;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
        public string Apellido { get; set; } = null!;

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "El teléfono debe contener solo números.")]
        public string? Telefono { get; set; }
    }
}
