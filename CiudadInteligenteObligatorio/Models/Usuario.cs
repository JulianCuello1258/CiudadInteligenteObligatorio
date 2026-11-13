using System.ComponentModel.DataAnnotations;

namespace CiudadInteligenteObligatorio.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres")]
        public string Contrasenia { get; set; }
        [Required(ErrorMessage = "El rol es obligatorio")]
        [RegularExpression("^(Ciudadano|Empleado|Administrador)$", ErrorMessage = "Rol no válido")]
        public string Rol { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Area { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Cargo { get; set; }
        public bool Activo { get; set; }
    }
}
