using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class PreguntaLN : IPreguntaLN
    {
        /// <summary>
        /// Método para ver las preguntas de un examen
        /// </summary>
        /// <param name="idExamen">Examen a consultar</param>
        /// <returns> Retorna una lista de preguntas asignada a un Id de Examen</returns>
        public List<Pregunta> SeleccionarPorExamen(int idExamen)
        {
            return PreguntaDB.SeleccionarPorExamen(idExamen);
        }

        /// <summary>
        /// Guarda una pregunta en su tabla de la base de datos
        /// </summary>
        /// <param name="p">Objeto del que extrae los datos</param>
        public void Guardar(Pregunta p)
        {
            if (ObtenerPorID(p.ID) == null)
            {
                PreguntaDB.Agregar(p);
            }
            else
            {
                PreguntaDB.Actualizar(p);
            }
        }
        /// <summary>
        /// Sirve para buscar por ID una pregunta en específico 
        /// </summary>
        /// <param name="id">Pregunta a consultar</param>
        /// <returns>Retorna la pregunta cuyo Id sea igual al parámetro</returns>
        public Pregunta ObtenerPorID(int id)
        {
            return PreguntaDB.SeleccionarPorId(id);
        }
        /// <summary>
        /// Borra la pregunta cuyo id sea igual al parámetro
        /// </summary>
        /// <param name="id">Id de pregunta a consultar</param>
        public void Borrar(int id)
        {
            PreguntaDB.Borrar(id);
        }


    }
}
