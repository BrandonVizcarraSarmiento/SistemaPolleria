using SistemaPolleria.common;
using SistemaPolleria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaPolleria.negocios
{
    public class NegocioMetodoPago
    {
        private DatosMetodoPago _datosMetodoPago = new DatosMetodoPago();

        // Obtener todos los métodos de pago
        public DataTable ObtenerTodosMetodosPagoN()
        {
            return _datosMetodoPago.ObtenerTodosMetodosPago();
        }

        // Insertar nuevo método de pago
        public int InsertarMetodoPagoN(EntidadMetodoPago metodoPago)
        {
            if (string.IsNullOrWhiteSpace(metodoPago.Nombre))
            {
                MessageBox.Show("El nombre del método de pago no puede estar vacío.");
                return 0;
            }

            return _datosMetodoPago.InsertarMetodoPago(metodoPago);
        }

        // Editar método de pago
        public int EditarMetodoPagoN(EntidadMetodoPago metodoPago)
        {
            if (string.IsNullOrWhiteSpace(metodoPago.Nombre))
            {
                MessageBox.Show("El nombre del método de pago no puede estar vacío.");
                return 0;
            }

            return _datosMetodoPago.EditarMetodoPago(metodoPago);
        }

        // Eliminar método de pago
        public int EliminarMetodoPagoN(int metodoPagoID)
        {
            if (metodoPagoID <= 0)
            {
                MessageBox.Show("El ID del método de pago no es válido.");
                return 0;
            }

            return _datosMetodoPago.EliminarMetodoPago(metodoPagoID);
        }

        // Buscar método de pago por nombre
        public DataTable ObtenerMetodoPagoPorNombreN(string nombre)
        {
            return _datosMetodoPago.ObtenerMetodoPagoPorNombre(nombre);
        }
    }
}
