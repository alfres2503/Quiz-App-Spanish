using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class TarjetaLN
    {
        /// <summary>
        /// Sirve para ver todas las tarjetas
        /// </summary>
        /// <returns>Retorna una lista con todas las tarjetas disponibles</returns>
        public static List<Tarjeta> ObtenerTodos()
        {
            return TarjetaDB.ObtenerTodos();
        }

    }
}
