using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entities;

namespace Capa.DAL
{
    public class ClienteDB
    {
        /// <summary>
        /// Método que guarda el cliente en la base de datos, solo en caso de que no encuentre un dato con ese ID
        /// </summary>
        /// <param name="c">Cliente del cuál extraerá los datos </param>
        public static void AgregarCliente(Cliente c)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarCliente";

                comando.Parameters.AddWithValue("@id", c.Id);
                comando.Parameters.AddWithValue("@idtipo", c.IdTipo);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@email", c.Email);
                comando.Parameters.AddWithValue("@foto", c.Imagen);
                comando.Parameters.AddWithValue("@fechaN", c.FechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", c.Telefono);
                comando.Parameters.AddWithValue("@pais", c.Pais);
                comando.Parameters.AddWithValue("@contrasenna", c.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Retorna de la tabla Cliente el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns></returns>
        public static Cliente SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientePorID";
                comando.Parameters.AddWithValue("@Id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente c = new Cliente();
                    c.Id = (int)dr["IDCliente"];
                    c.IdTipo = (int)dr["IDTipo"];
                    c.Nombre = dr["Nombre"].ToString();
                    c.Apellido = dr["Apellido"].ToString();
                    c.Email = dr["Email"].ToString();
                    c.Imagen = (Byte[])dr["Fotografia"];
                    c.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    c.Telefono = dr["Telefono"].ToString();
                    c.Pais = dr["PaisNacimiento"].ToString();
                    c.Contrasenna = dr["Contrasenna"].ToString();

                    return c;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna de la tabla Cliente el dato con el telefono buscado
        /// </summary>
        /// <param name="telefono"> telefono a buscar</param>
        /// <returns></returns>
        public static Cliente SeleccionarPorTelefono(string telefono)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientePorTelefono";
                comando.Parameters.AddWithValue("@telefono", telefono);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente c = new Cliente();
                    c.Id = (int)dr["IDCliente"];
                    c.IdTipo = (int)dr["IDTipo"];
                    c.Nombre = dr["Nombre"].ToString();
                    c.Apellido = dr["Apellido"].ToString();
                    c.Email = dr["Email"].ToString();
                    c.Imagen = (Byte[])dr["Fotografia"];
                    c.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    c.Telefono = dr["Telefono"].ToString();
                    c.Pais = dr["PaisNacimiento"].ToString();
                    //c.Activo = Convert.ToBoolean(dr["Activo"]);
                    c.Contrasenna = dr["Contrasenna"].ToString();

                    return c;
                }
            }
            return null;
        }
        /// <summary>
        /// Retorna de la tabla Cliente el dato con el email buscado
        /// </summary>
        /// <param name="email"> email a buscar</param>
        /// <returns></returns>
        public static Cliente SeleccionarPorEmail(string email)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientePorEmail";
                comando.Parameters.AddWithValue("@email", email);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente c = new Cliente();
                    c.Id = (int)dr["IDCliente"];
                    c.IdTipo = (int)dr["IDTipo"];
                    c.Nombre = dr["Nombre"].ToString();
                    c.Apellido = dr["Apellido"].ToString();
                    c.Email = dr["Email"].ToString();
                    c.Imagen = (Byte[])dr["Fotografia"];
                    c.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    c.Telefono = dr["Telefono"].ToString();
                    c.Pais = dr["PaisNacimiento"].ToString();
                    c.Contrasenna = dr["Contrasenna"].ToString();

                    return c;
                }
            }
            return null;
        }
        /// <summary>
        /// Método para obtener todos los datos de la tabla Cliente
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Cliente</returns>
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente c = new Cliente();
                    c.Id = (int)dr["IDCliente"];
                    c.IdTipo = (int)dr["IDTipo"];
                    c.Nombre = dr["Nombre"].ToString();
                    c.Apellido = dr["Apellido"].ToString();
                    c.Email = dr["Email"].ToString();
                    c.Imagen = (Byte[])dr["Fotografia"];
                    c.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    c.Telefono = dr["Telefono"].ToString();
                    c.Pais = dr["PaisNacimiento"].ToString();
                    //c.Activo = Convert.ToBoolean(dr["Activo"]);
                    c.Contrasenna = dr["Contrasenna"].ToString();

                    lista.Add(c);
                }
            }
            return lista;
        }
        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public static void Delete(string id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_BorrarCliente";
                comando.Parameters.AddWithValue("@id", id);

                db.ExecuteNonQuery(comando);
            }
        }
        /// <summary>
        /// actualiza el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="c"> Cliente del cual extrae los datos</param>
        /// <param name="idViejo"> ID a buscar </param>
        public static void Update(Cliente c, int idViejo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCliente";
                comando.Parameters.AddWithValue("@idViejo", idViejo);
                comando.Parameters.AddWithValue("@id", c.Id);
                comando.Parameters.AddWithValue("@idtipo", c.IdTipo);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@email", c.Email);
                comando.Parameters.AddWithValue("@foto", c.Imagen);
                comando.Parameters.AddWithValue("@fechaN", c.FechaNacimiento);
                comando.Parameters.AddWithValue("@telefono", c.Telefono);
                comando.Parameters.AddWithValue("@pais", c.Pais);
                comando.Parameters.AddWithValue("@contrasenna", c.Contrasenna);

                db.ExecuteNonQuery(comando);
            }
        }


    }
}
