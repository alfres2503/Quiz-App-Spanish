using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Examenes a realizar, cuenta con varias preguntas relacionadas en la base de datos
    /// </summary>
    public class Examen
    {
        public int ID { get; set; }
        public Certificacion CertificacionA { get; set; }
        public string Titulo { get; set; }
        public int Minutos { get; set; }
        public int CantPreguntas { get; set; }
        public double NotaMinima { get; set; }

        public string NombreCertificacion
        {
            get
            {
                return CertificacionA.Descripcion;
            }
        }
    }
}
