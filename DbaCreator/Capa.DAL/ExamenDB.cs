using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
    public class ExamenDB
    {
        /// <summary>
        /// Método que guarda el examen en la base de datos
        /// </summary>
        /// <param name="c">Examen del cuál extraerá los datos </param>
        public static void Agregar(Examen e)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarExamen";
                comando.Parameters.AddWithValue("@id", e.ID);
                comando.Parameters.AddWithValue("@idCertificacion", e.CertificacionA.Id);
                comando.Parameters.AddWithValue("@titulo", e.Titulo);
                comando.Parameters.AddWithValue("@minutos", e.Minutos);
                comando.Parameters.AddWithValue("@cantPreguntas", e.CantPreguntas);
                comando.Parameters.AddWithValue("@notaMinima", e.NotaMinima);

                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// Método para obtener todos los datos de la tabla Examen
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Examen</returns>
        public static List<Examen> ObtenerTodos()
        {
            List<Examen> lista = new List<Examen>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarExamenes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Examen e = new Examen();
                    e.ID = (int)dr["IDExamen"];
                    e.CertificacionA = CertificacionDB.SeleccionarPorId((int)dr["IDCertificacion"]);
                    e.Titulo = dr["Titulo"].ToString();
                    e.Minutos = (int)dr["Minutos"];
                    //e.CantPreguntas = (int)dr["CantPreguntas"];
                    e.CantPreguntas = PreguntaDB.SeleccionarPorExamen(e.ID).Count;
                    e.NotaMinima = Convert.ToDouble(dr["NotaMinima"]);

                    lista.Add(e);
                }
            }
            return lista;
        }
        /// <summary>
        /// Método que busca los examenes por certificación
        /// </summary>
        /// <param name="idCertificacion"> ID de certificación a buscar</param>
        /// <returns> retorna una lista de examenes que pertenecen a una certificación</returns>
        public static List<Examen> SeleccionarPorCertificacion(int idCertificacion)
        {
            List<Examen> lista = new List<Examen>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarExamenesPorCertificacion";
                comando.Parameters.AddWithValue("@IdCertificacion", idCertificacion);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Examen e = new Examen();
                    e.ID = (int)dr["IDExamen"];
                    e.CertificacionA = CertificacionDB.SeleccionarPorId((int)dr["IDCertificacion"]);
                    e.Titulo = dr["Titulo"].ToString();
                    e.Minutos = (int)dr["Minutos"];
                    e.CantPreguntas = PreguntaDB.SeleccionarPorExamen(e.ID).Count;
                    e.NotaMinima = Convert.ToDouble(dr["NotaMinima"]);

                    lista.Add(e);
                }
            }
            return lista;
        }

        /// <summary>
        /// Retorna de la tabla Examen el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns>Retorna de la tabla Examen el dato con el ID buscado</returns>
        public static Examen SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarExamenPorID";
                comando.Parameters.AddWithValue("@Id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Examen e = new Examen();
                    e.ID = (int)dr["IDExamen"];
                    e.CertificacionA = CertificacionDB.SeleccionarPorId((int)dr["IDCertificacion"]);
                    e.Titulo = dr["Titulo"].ToString();
                    e.Minutos = (int)dr["Minutos"];
                    //e.CantPreguntas = (int)dr["CantPreguntas"];
                    e.CantPreguntas = PreguntaDB.SeleccionarPorExamen(e.ID).Count;
                    e.NotaMinima = Convert.ToDouble(dr["NotaMinima"]);
                    return e;
                }
            }
            return null;
        }

        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public static void Borrar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_BorrarExamen";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// Actuliza el examen que tenga el ID buscado
        /// </summary>
        /// <param name="e">ID Buscado</param>
        public static void Actualizar(Examen e)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarExamen";

                comando.Parameters.AddWithValue("@id", e.ID);
                comando.Parameters.AddWithValue("@idCertificacion", e.CertificacionA.Id);
                comando.Parameters.AddWithValue("@titulo", e.Titulo);
                comando.Parameters.AddWithValue("@minutos", e.Minutos);
                comando.Parameters.AddWithValue("@cantPreguntas", e.CantPreguntas);
                comando.Parameters.AddWithValue("@notaMinima", e.NotaMinima);

                db.ExecuteNonQuery(comando);
            }
        }
    }
}
