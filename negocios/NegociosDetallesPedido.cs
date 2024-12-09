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
    public class NegociosDetallesPedido
    {
        private DatosDetallesPedido _datosDetallesPedido = new DatosDetallesPedido();

        // Obtener todos los DetallesPedido
        public DataTable ObtenerTodosDetallesPedidoN()
        {
            return _datosDetallesPedido.ObtenerTodosDetallesPedido();
        }
        // Insertar nuevo DetallesPedido
        public int InsertarDetallesPedidoN(EntidadDetallesPedido detallesPedido)
        {
            // Validaciones
            if (detallesPedido.Cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return 0;
            }

            // Insertar en la base de datos
            int numRes = _datosDetallesPedido.InsertarDetallesPedido(detallesPedido);
            return numRes;
        }
        // Editar DetallesPedido
        public int EditarDetallesPedidoN(EntidadDetallesPedido detallesPedido)
        {
            // Validaciones
            if (detallesPedido.Cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return 0;
            }

            return _datosDetallesPedido.EditarDetallesPedido(detallesPedido);
        }

        // Eliminar Pedidos
        public int EliminarDetallesPedidoN(int pedidosID)
        {
            return _datosDetallesPedido.EliminarDetallesPedido(pedidosID);
        }
        public DataTable ObtenerDetallesPedidoPorPedidoIDN(int pedidoID)
        {
            return _datosDetallesPedido.ObtenerDetallesPedidoPorPedidoID(pedidoID);
        }
    }
}