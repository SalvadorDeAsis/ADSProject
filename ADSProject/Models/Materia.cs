﻿using ADSProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdMateria))]
    public class Materia
    {
        public int IdMateria { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede se mayor a 50 Caracteres.")]
        public string NombreMateria { get; set; }

    }
}
