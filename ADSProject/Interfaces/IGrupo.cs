using ADSProject.Models;

namespace ADSProject.Interfaces
{
    public interface IGrupo
    {
        public int AgregarGrupo(Grupo grupo);
        public int ActualizarGrupo(int IdGrupo, Grupo grupo);
        public bool EliminarGrupo(int IdGrupo);
        public List<Grupo> ObtenerTodosLosGrupos();
        public Grupo ObtenerGrupoPorId(int IdGrupo);
    }
}
