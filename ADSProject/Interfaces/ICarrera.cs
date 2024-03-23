﻿using ADSProject.Models;

namespace ADSProject.Interfaces
{
    public interface ICarrera
    {
        public int AgregarCarrera(Carrera carrera);
        public int ActualizarCarrera(int Id, Carrera carrera);
        public bool EliminarCarrera(int Id);
        public List<Carrera> ObtenerTodasLasCarreras();
        public Carrera ObtenerCarreraPorId(int Id);
    }
}
