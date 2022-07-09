using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Certificaciones
    /// </summary>
    public class Certificacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
