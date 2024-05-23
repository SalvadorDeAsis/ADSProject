using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(Id))]
    public class Carrera
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede se mayor a 3 Caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede se mayor a 40 Caracteres.")]
        public string Nombre { get; set; }
    }
}
