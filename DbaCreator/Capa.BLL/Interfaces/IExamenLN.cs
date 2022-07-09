using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    /// <summary>
    /// Interfaz examen, la documentación de los métodos está en la clase hijo
    /// </summary>
    public interface IExamenLN
    {
        void Guardar(Examen e);
        List<Examen> ObtenerPorCertificacion(int idCertificacion);
        Examen ObtenerPorID(int id);
        List<Examen> ObtenerTodos();
        void Borrar(int id);
    }
}
