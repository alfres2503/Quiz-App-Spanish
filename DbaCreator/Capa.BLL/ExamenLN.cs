using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class ExamenLN : IExamenLN
    {
        /// <summary>
        /// Método que guarda el examen en la base de datos, si encuentra un dato con ese ID, lo edita
        /// </summary>
        /// <param name="c">Examen del cuál extraerá los datos </param>
        public void Guardar(Examen e)
        {
            if (ObtenerPorID(e.ID) == null)
            {
                ExamenDB.Agregar(e);
            }
            else
            {
                ExamenDB.Actualizar(e);
            }
        }

        /// <summary>
        /// Método que busca los examenes por certificación
        /// </summary>
        /// <param name="idCertificacion"> ID de certificación a buscar</param>
        /// <returns> retorna una lista de examenes que pertenecen a una certificación</returns>
        public List<Examen> ObtenerPorCertificacion(int idCertificacion)
        {
            return ExamenDB.SeleccionarPorCertificacion(idCertificacion);
        }

        /// <summary>
        /// Retorna de la tabla Examen el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns>Retorna de la tabla Examen el dato con el ID buscado</returns>
        public Examen ObtenerPorID(int id)
        {
            return ExamenDB.SeleccionarPorId(id);
        }

        /// <summary>
        /// Método para obtener todos los datos de la tabla Examen
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Examen</returns>
        public List<Examen> ObtenerTodos()
        {
            return ExamenDB.ObtenerTodos();
        }

        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public void Borrar(int id)
        {
            ExamenDB.Borrar(id);
        }
        
    }
}
