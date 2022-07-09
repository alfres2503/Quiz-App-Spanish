using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entities
{
    /// <summary>
    /// Cliente/Usuario con todos sus atributos
    /// </summary>
    public class Cliente
    {
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte[] Imagen { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Contrasenna { get; set; }

        public TipoCliente Tipo
        {
            get
            {
                return (TipoCliente)IdTipo;
            }
        }

    }
}
