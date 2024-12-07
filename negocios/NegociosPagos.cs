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
    public class NegociosPagos
    {
        private DatosPagos _datosPagos = new DatosPagos();
        // Obtener todos los Pagos
        public DataTable ObtenerTodosPagosN()
        {
            return _datosPagos.ObtenerTodosPagos();
        }
        // Insertar nuevo Pagos
        public int InsertarPagosN(EntidadPagos pagos)
        {
            // Validaciones
            if (string.IsNullOrEmpty(pagos.MetodoPago))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.");
                return 0;
            }
            // Insertar en la base de datos
            int numRes = _datosPagos.InsertarPagos(pagos);
            return numRes;
        }
        // Editar Pagos
        public int EditarPagosN(EntidadPagos pagos)
        {
            // Validaciones
            if (string.IsNullOrEmpty(pagos.MetodoPago))
            {
                MessageBox.Show("El MetodoPago de los pagos es obligatorio.");
                return 0;
            }

            return _datosPagos.EditarPagos(pagos);
        }


        // Eliminar Pagos
        public int EliminarPagosN(int pagosID)
        {
            return _datosPagos.EliminarPagos(pagosID);
        }
        public DataTable ObtenerPagosPorPedidoIDN(int pedidoID)
        {
            return _datosPagos.ObtenerPagosPorPedidoID(pedidoID);
        }
    }
}