using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    /// <summary>
    /// Interfaz de certificacionLN, la documentación de los métodos está en la clase hijo
    /// </summary>
    public interface ICertificacionLN
    {
        void Guardar(Certificacion c);
        Certificacion ObtenerPorID(int id);
        List<Certificacion> ObtenerTodos();
        void Borrar(int id);

    }
}
