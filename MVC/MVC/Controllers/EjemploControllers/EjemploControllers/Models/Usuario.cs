using System.ComponentModel.DataAnnotations;

namespace EjemploControllers.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de usuario")]
        [Required]
        [MaxLength(250)]
        public string Nombre { get; set; }

        [Display(Name = "Dirección de email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [MinLength(6)]
        [MaxLength(28)]
        public string Password { get; set; }
    }
}