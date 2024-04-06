using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        private List<Profesor> lstProfesor = new List<Profesor>()
        {
            new Profesor
            {   IdProfesor = 1,NombresProfesor = "Pedro Alexander",
                ApellidosProfesor="Perez Sosa",gmail="Pedro@usonsonate.edu.sv"
            }
        };

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                //Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                //Y lo incrementamos en una unidad
                if (lstProfesor.Count > 0)
                {
                    profesor.IdProfesor = lstProfesor.Last().IdProfesor + 1;
                }
                lstProfesor.Add(profesor);

                return profesor.IdProfesor;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                //Obtenemos el indice del objeto para actualizar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == idProfesor);
                //Procedemos con la actualizacion
                lstProfesor[indice] = profesor;

                return idProfesor;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarProfesor(int IdProfesor)
        {
            try
            {
                //Obtenemos el indice del objeto a eliminar
                int indice = lstProfesor.FindIndex(tmp => tmp.IdProfesor == IdProfesor);
                //Procedemos a eliminar el registro
                lstProfesor.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profesor ObtenerProfesorPorId(int IdProfesor)
        {
            try
            {
                //Buscamos asignamos el objeto Estudiante
                Profesor profesor = lstProfesor.FirstOrDefault(tmp => tmp.IdProfesor == IdProfesor);

                return profesor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> ObtenerTodosLosProfesor()
        {
            try
            {
                return lstProfesor;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
