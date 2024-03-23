using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarreras = new List<Carrera>()
        {
            new Carrera
            {   Id = 1,Codigo = "004001",
                Nombre="Ing. Sistema"
            }
        };


        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                //Validar si existen datos en la lista, de ser asi, tomaremos el ultimo ID
                //Y lo incrementamos en una unidad
                if (lstCarreras.Count > 0)
                {
                    carrera.Id = lstCarreras.Last().Id + 1;
                }
                lstCarreras.Add(carrera);

                return carrera.Id;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public int ActualizarCarrera(int Idcarrera, Carrera carrera)
        {
            try
            {
                //Obtenemos el indice del objeto para actualizar
                int indice = lstCarreras.FindIndex(tmp => tmp.Id == Idcarrera);
                //Procedemos con la actualizacion
                lstCarreras[indice] = carrera;

                return Idcarrera;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public bool EliminarCarrera(int IdCarrera)
        {
            try
            {
                //Obtenemos el indice del objeto a eliminar
                int indice = lstCarreras.FindIndex(tmp => tmp.Id == IdCarrera);
                //Procedemos a eliminar el registro
                lstCarreras.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Carrera ObtenerCarreraPorId(int Id)
        {
            try
            {
                //Buscamos asignamos el objeto carrera
                Carrera carrera = lstCarreras.FirstOrDefault(tmp => tmp.Id == Id);

                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Carrera> ObtenerTodasLasCarreras()
        {
            try
            {
                return lstCarreras;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
