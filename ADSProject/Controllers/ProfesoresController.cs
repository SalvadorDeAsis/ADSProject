using ADSProject.Interfaces;
using ADSProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProject.Controllers
{
    [Route("api/profesores/")]

    public class ProfesoresController : ControllerBase
    {
        private readonly IProfesor profesor;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public ProfesoresController(IProfesor profesor)
        {
            this.profesor = profesor;
        }
        [HttpPost("agregarProfesor")]

        public ActionResult<string> AgregarProfesor([FromBody] Profesor profesor)
        {
            try
            {
                //Verificar que todas la validacione por atributo del modelo este correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.profesor.AgregarProfesor(profesor);
                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "registo insertado con existo";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al insertar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("actualizarProfesor/{Id}")]

        public ActionResult<string> ActualizarProfesor(int IdProfesor, [FromBody] Profesor profesor)
        {
            try
            {
                //Verificar que todas la validacione por atributo del modelo este correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.profesor.ActualizarProfesor(IdProfesor, profesor);
                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro actaulizado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al actualizar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpDelete("eliminarProfesor/{Id}")]
        public ActionResult<string> EliminarProfesor(int IdProfesor)
        {
            try
            {
                bool eliminado = this.profesor.EliminarProfesor(IdProfesor);
                if (eliminado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro eliminado con exito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un problema al eliminar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("obtenerProfesorPorId/{Id}")]
        public ActionResult<Profesor> ObtenerProfesorPorId(int Id)
        {
            try
            {
                Profesor profesor = this.profesor.ObtenerProfesorPorId(Id);

                if (profesor != null)
                {
                    return Ok(profesor);
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "No se encontraron datos del estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet("obtenerProfesor")]

        public ActionResult<List<Profesor>> ObtenerProfesor()
        {
            try
            {
                List<Profesor> lstProfesor = this.profesor.ObtenerTodosLosProfesor();
                return Ok(lstProfesor);

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
