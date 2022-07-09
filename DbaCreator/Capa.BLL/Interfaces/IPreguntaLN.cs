using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    /// <summary>
    /// Interfaz pregunta, la documentación de los métodos está en la clase hijo
    /// </summary>
    public interface IPreguntaLN
    {
        List<Pregunta> SeleccionarPorExamen(int idExamen);
        void Guardar(Pregunta p);
        Pregunta ObtenerPorID(int id);
        void Borrar(int id);
    }

}
