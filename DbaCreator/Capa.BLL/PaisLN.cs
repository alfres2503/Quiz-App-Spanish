using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class PaisLN
    {
        /// <summary>
        /// Usado para ver todos los países
        /// </summary>
        /// <returns>retorna una lista con todos los países</returns>
        public static List<Pais> ObtenerTodos()
        {
            return PaisDB.ObtenerTodos();
        }
    }
}
