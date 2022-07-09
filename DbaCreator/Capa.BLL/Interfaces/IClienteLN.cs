using Capa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    /// <summary>
    /// Interfaz cliente, la documentación de los métodos está en la clase hijo
    /// </summary>
    public interface IClienteLN
    {
        void Guardar(Cliente c);
        Cliente ObtenerPorID(int id);
        Cliente ObtenerPorTelefono(string telefono);
        Cliente ObtenerPorCorreo(string email);
        List<Cliente> ObtenerTodos();
        void Borrar(string id);
        void Actualizar(Cliente c, int idViejo);
    }
}
