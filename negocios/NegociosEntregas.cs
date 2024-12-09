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
    public class NegociosEntregas
    {
        private DatosEntregas _datosEntregas = new DatosEntregas();

        // Obtener todos las Entregas
        public DataTable ObtenerTodosEntregasN()
        {
            return _datosEntregas.ObtenerTodosEntregas();
        }
        // Insertar nuevo Entregas
        public int InsertarEntregasN(EntidadEntregas entregas)
        {
            // Validaciones
            if (string.IsNullOrEmpty(entregas.EstadoEntrega))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.");
                return 0;
            }
            // Insertar en la base de datos
            int numRes = _datosEntregas.InsertarEntregas(entregas);
            return numRes;
        }

        // Editar Entregas
        public int EditarEntregasN(EntidadEntregas entregas)
        {
            // Validaciones
            if (string.IsNullOrEmpty(entregas.EstadoEntrega))
            {
                MessageBox.Show("El EstadoEntrega de los Pedidos es obligatorio.");
                return 0;
            }

            return _datosEntregas.EditarEntregas(entregas);
        }

        // Eliminar Entregas
        public int EliminarEntregasN(int entregaID)
        {
            return _datosEntregas.EliminarEntregas(entregaID);
        }
        public DataTable ObtenerPedidosPorClienteN(DateTime fechaEntrega)
        {
            return _datosEntregas.ObtenerEntregasPorfecha(fechaEntrega);
        }
    }
}