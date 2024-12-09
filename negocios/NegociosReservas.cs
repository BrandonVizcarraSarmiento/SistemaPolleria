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
    public class NegociosReservas
    {
        private DatosReservas _datosReservas = new DatosReservas();
        // Obtener todos los Reservas
        public DataTable ObtenerTodosReservasN()
        {
            return _datosReservas.ObtenerTodosReservas();
        }
        // Insertar nuevo Reservas
        public int InsertarReservasN(EntidadReservas reservas)
        {
            // Validaciones
            if (reservas.FechaReserva == DateTime.MinValue) 
            {
                MessageBox.Show("La fecha de la reserva es obligatoria.");
                return 0; 
            }
            int result = _datosReservas.InsertarReservas(reservas); 
            return result;
        }
        // Editar Reservas
        public int EditarReservasN(EntidadReservas reservas)
        {
            // Validaciones
            if (reservas.FechaReserva == DateTime.MinValue) // Verifica si la FechaReserva es válida
            {
                MessageBox.Show("La fecha de la reserva es obligatoria.");
                return 0;
            }
            return _datosReservas.EditarReservas(reservas);
        }
        // Eliminar Pedidos
        public int EliminarReservasN(int ReservaID)
        {
            return _datosReservas.EliminarReservas(ReservaID);
        }
        public DataTable ObtenerReservasPorClienteID(int ClienteID)
        {
            return _datosReservas.ObtenerReservasPorClienteID(ClienteID);
        }
    }
}