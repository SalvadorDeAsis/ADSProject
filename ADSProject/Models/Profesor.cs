using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string NombresProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string ApellidosProfesor { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede se mayor a 254 Caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto.")]
        public string gmail {  get; set; }  
    }
}
