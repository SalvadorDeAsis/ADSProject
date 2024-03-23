using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
       
        private List<Estudiante> lstEstudiantes = new List<Estudiante>()
        {
            new Estudiante
            {   IdEstudiante = 1,NombresEstudiante = "Juan Carlos",
                ApellidosEstudiante="Perez Sosa",CodigoEstudiante="PS24I04002",
                CorreoEstudiante="PS24I04002@usonsonate.edu.sv"
            }
        };


        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                //Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                //Y lo incrementamos en una unidad
                if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }
                lstEstudiantes.Add(estudiante);

                return estudiante.IdEstudiante;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                //Obtenemos el indice del objeto para actualizar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);
                //Procedemos con la actualizacion
                lstEstudiantes[indice] = estudiante;

                return idEstudiante;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public bool EliminarEstudiante(int IdEstudiante)
        {
            try
            {
                //Obtenemos el indice del objeto a eliminar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == IdEstudiante);
                //Procedemos a eliminar el registro
                lstEstudiantes.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Estudiante ObtenerEstudiantePorId(int IdEstudiante)
        {
            try
            {
                //Buscamos asignamos el objeto Estudiante
                Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == IdEstudiante);

                return estudiante;
            }
            catch(Exception)
            {
                throw;
            }
        }
            
        
        public List<Estudiante> ObtenerTodosLosEstudiante()
        {
            try
            {
                return lstEstudiantes;
            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}
