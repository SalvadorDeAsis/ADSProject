using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {

        private List<Materia> lstMateria = new List<Materia>()
        {
            new Materia
            {   IdMateria = 1,
                NombreMateria="Analisis de sistema"
            }
        };

        public int ActualizarMateria(int IdMateria, Materia materia)
        {
            try
            {
                //Obtenemos el indice del objeto para actualizar
                int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == IdMateria);
                //Procedemos con la actualizacion
                lstMateria[indice] = materia;

                return IdMateria;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                //Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                //Y lo incrementamos en una unidad
                if (lstMateria.Count > 0)
                {
                    materia.IdMateria = lstMateria.Last().IdMateria + 1;
                }
                lstMateria.Add(materia);

                return materia.IdMateria;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarMateria(int IdMateria)
        {
            try
            {
                //Obtenemos el indice del objeto a eliminar
                int indice = lstMateria.FindIndex(tmp => tmp.IdMateria == IdMateria);
                //Procedemos a eliminar el registro
                lstMateria.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Materia ObtenerMateriaPorId(int IdMateria)
        {
            try
            {
                //Buscamos asignamos el objeto carrera
                Materia materia = lstMateria.FirstOrDefault(tmp => tmp.IdMateria == IdMateria);

                return materia;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Materia> ObtenerTodasLasMaterias()
        {
            try
            {
                return lstMateria;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}