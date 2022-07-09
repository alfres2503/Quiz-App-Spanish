using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class IntentoLN
    {
        /// <summary>
        /// Inserta un intento en la base de datos
        /// </summary>
        /// <param name="i">Intento del que extraerá los datos</param>
        public static void Insertar(Intento i)
        {
            IntentoDB.Insertar(i);
        }

        /// <summary>
        /// Usado para saber que numero de intento va y asignar un id
        /// </summary>
        /// <returns> Retorna el id máximo en la tabla + 1 </returns>
        public static int ObtenerNumeroDeIntentoActual()
        {
            return IntentoDB.ObtenerNumeroDeIntentoActual();
        }

        /// <summary>
        /// Si el cliente gana el examen se marca como exitoso
        /// </summary>
        /// <param name="idIntento"> ID a buscar</param>
        public static void MarcarIntentoExitoso(int idIntento)
        {
            IntentoDB.MarcarIntentoExitoso(idIntento);
        }

    }
}
