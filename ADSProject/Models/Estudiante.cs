using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string NombresEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string ApellidosEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede se menor a 12 Caracteres.")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string CodigoEstudiante { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede se mayor a 254 Caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto.")]
        public string CorreoEstudiante { get; set; }



    }
}
