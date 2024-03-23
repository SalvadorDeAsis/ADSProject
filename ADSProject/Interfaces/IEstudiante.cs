﻿using ADSProject.Models;

namespace ADSProject.Interfaces
{
    public interface IEstudiante
    {
        public int AgregarEstudiante(Estudiante estudiante);
        public int ActualizarEstudiante(int IdEstudiante, Estudiante estudiante);
        public bool EliminarEstudiante(int IdEstudiante);
        public List<Estudiante> ObtenerTodosLosEstudiante();
        public Estudiante ObtenerEstudiantePorId(int IdEstudiante);

    }
}
