using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Paises para el registro
    /// </summary>
    public class Pais
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
