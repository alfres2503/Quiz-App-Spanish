using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class CertificacionLN : ICertificacionLN
    {
        /// <summary>
        /// Método que guarda la certificacion en la base de datos, si encuentra un dato con ese ID, lo edita
        /// </summary>
        /// <param name="c">Certificación del cuál extraerá los datos </param>
        public void Guardar(Certificacion c)
        {
            if (ObtenerPorID(c.Id) == null)
            {
                CertificacionDB.AgregarCertificacion(c);
            } else
            {
                CertificacionDB.Actualizar(c);
            }
        }

        /// <summary>
        /// Retorna de la tabla Certificación el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns></returns>
        public Certificacion ObtenerPorID(int id)
        {
            return CertificacionDB.SeleccionarPorId(id);
        }


        /// <summary>
        /// Método para obtener todos los datos de la tabla Certificación
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Certificacion</returns>
        public List<Certificacion> ObtenerTodos()
        {
            return CertificacionDB.ObtenerTodos();
        }

        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public void Borrar(int id)
        {
            CertificacionDB.Borrar(id);
        }

    }
}
