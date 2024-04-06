using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class GrupoRepository : IGrupo
    {
        private List<Grupo> lstGrupo = new List<Grupo>()
        {
            new Grupo
            {   IdGrupo = 1,
                IdCarrera = 1,
                IdMateria = 1,
                IdProfesor = 1,
                Ciclo = 1,
                Anio = 2024
            }
        };
        public int ActualizarGrupo(int IdGrupo, Grupo grupo)
        {
            try
            {
                //Obtenemos el indice del objeto para actualizar
                int indice = lstGrupo.FindIndex(tmp => tmp.IdGrupo == IdGrupo);
                //Procedemos con la actualizacion
                lstGrupo[indice] = grupo;

                return IdGrupo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AgregarGrupo(Grupo grupo)
        {
            try
            {
                //Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                //Y lo incrementamos en una unidad
                if (lstGrupo.Count > 0)
                {
                    grupo.IdGrupo = lstGrupo.Last().IdGrupo + 1;
                }
                lstGrupo.Add(grupo);

                return grupo.IdGrupo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarGrupo(int IdGrupo)
        {
            try
            {
                //Obtenemos el indice del objeto a eliminar
                int indice = lstGrupo.FindIndex(tmp => tmp.IdGrupo == IdGrupo);
                //Procedemos a eliminar el registro
                lstGrupo.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Grupo ObtenerGrupoPorId(int IdGrupo)
        {
            try
            {
                //Buscamos asignamos el objeto Estudiante
                Grupo grupo = lstGrupo.FirstOrDefault(tmp => tmp.IdGrupo == IdGrupo);

                return grupo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Grupo> ObtenerTodosLosGrupos()
        {
            try
            {
                return lstGrupo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
