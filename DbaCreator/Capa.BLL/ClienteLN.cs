using Capa.DAL;
using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class ClienteLN: IClienteLN
    {
        /// <summary>
        /// Método que guarda el cliente en la base de datos, solo en caso de que no encuentre un dato con ese ID
        /// </summary>
        /// <param name="c">Cliente del cuál extraerá los datos </param>
        public void Guardar(Cliente c)
        {
            ClienteDB db = new ClienteDB();
            
            if (ClienteDB.SeleccionarPorId(c.Id)==null)
            {
                ClienteDB.AgregarCliente(c);
            } 
        }

        /// <summary>
        /// Retorna de la tabla Cliente el dato con el ID buscado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        /// <returns></returns>
        public Cliente ObtenerPorID(int id)
        {
            return ClienteDB.SeleccionarPorId(id);
        }

        /// <summary>
        /// Retorna de la tabla Cliente el dato con el telefono buscado
        /// </summary>
        /// <param name="telefono"> telefono a buscar</param>
        /// <returns></returns>
        public Cliente ObtenerPorTelefono(string telefono)
        {
            return ClienteDB.SeleccionarPorTelefono(telefono);
        }

        /// <summary>
        /// Retorna de la tabla Cliente el dato con el email buscado
        /// </summary>
        /// <param name="email"> email a buscar</param>
        /// <returns></returns>
        public Cliente ObtenerPorCorreo(string email)
        {
            return ClienteDB.SeleccionarPorEmail(email);
        }

        /// <summary>
        /// Método para obtener todos los datos de la tabla Cliente
        /// </summary>
        /// <returns>Retorna una lista con todos los datos de la tabla Cliente</returns>
        public List<Cliente> ObtenerTodos()
        {
            return ClienteDB.ObtenerClientes();
        }

        /// <summary>
        /// Borra el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="id"> ID a buscar</param>
        public void Borrar(string id)
        {
            ClienteDB.Delete(id);
        }

        /// <summary>
        /// actualiza el dato de la tabla con el ID enviado
        /// </summary>
        /// <param name="c"> Cliente del cual extrae los datos</param>
        /// <param name="idViejo"> ID a buscar </param>
        public void Actualizar(Cliente c, int idViejo)
        {
            ClienteDB.Update(c, idViejo);
        }
    }
    
}
