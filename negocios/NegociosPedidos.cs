using SistemaPolleria.common;
using SistemaPolleria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPolleria.negocios
{
    public class NegociosPedidos
    {
        private DatosPedidos _datosPedidos = new DatosPedidos();

        // Obtener todos los pedidos
        public DataTable ObtenerTodosPedidosN()
        {
            return _datosPedidos.ObtenerTodosPedidos();
        }
        // Insertar nuevo Pedidos
        public int InsertarPedidosN(EntidadPedidos pedidos)
        {
            // Validaciones
            if (string.IsNullOrEmpty(pedidos.Cliente))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.");
                return 0;
            }
            // Insertar en la base de datos
            int numRes = _datosPedidos.InsertarPedidos(pedidos);
            return numRes;
        }
        // Editar Pedidos
        public int EditarPedidosN(EntidadPedidos pedidos)
        {
            // Validaciones
            if (string.IsNullOrEmpty(pedidos.Cliente))
            {
                MessageBox.Show("El Cliente de los Pedidos es obligatorio.");
                return 0;
            }

            return _datosPedidos.EditarPedidos(pedidos);
        }

        // Eliminar Pedidos
        public int EliminarPedidosN(int pedidosID)
        {
            return _datosPedidos.EliminarPedidos(pedidosID);
        }
        public DataTable ObtenerPedidosPorClienteN(string cliente)
        {
            return _datosPedidos.ObtenerPedidosPorCliente(cliente);
        }
    }
}