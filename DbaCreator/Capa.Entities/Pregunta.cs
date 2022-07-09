using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Preguntas de los examenes, pueden contar con una imagen
    /// </summary>
    public class Pregunta
    {
        public int ID { get; set; }
        public int IDExamen { get; set; }
        public int IDCertificacion { get; set; }
        public string Enunciado { get; set; }
        public string Correcta { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public byte[] Imagen { get; set; }
    }
}
